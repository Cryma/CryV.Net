#include <utility>

#include <hooking.h>

#include <sdk/natives.h>
#include <sdk/main.h>

#include <crossmapping.h>
#include <inputHook.h>

#include <MinHook.h>
#include "hook.h"
#include "scriptPatches.h"

static hook::GamePatterns::NativeHandler _originalGetFrameCount = nullptr;
static char *(__fastcall *_originalGetLabelText)(__int64 a1, BYTE *a2, __int64 a3);

static void __stdcall ScriptFunction(LPVOID);
static void *__cdecl hookGetFrameCount(hook::NativeContext *context);
static char *hookGetLabelText(__int64 a1, BYTE *a2, __int64 a3);

hook::Hooking::Hooking(std::shared_ptr<GamePatterns> gamePatterns, HookScript script) {
    _gamePatterns = std::move(gamePatterns);
    _d3dHook = nullptr;
    _script = script;

    _logger = spdlog::get("hook");

    _logger->info("Start hooking...");
}

void hook::Hooking::cleanup() {
    for (auto &hook : _hooks) {
        if (MH_DisableHook(hook) != MH_OK && MH_RemoveHook(hook) != MH_OK) {
            _logger->error("Failed to unhook %p", static_cast<void*>(hook));
        }
    }

    MH_Uninitialize();

    if (_d3dHook != nullptr) {
        delete _d3dHook;
        _d3dHook = nullptr;
    }
}

void hook::Hooking::onTickInit() {
    if (_mainFiber == nullptr) {
        _logger->debug("Creating main fiber");

        _mainFiber = ConvertThreadToFiber(nullptr);
    }

    if (timeGetTime() < _wakeAt) {
        return;
    }

    static HANDLE scriptFiber;
    if (scriptFiber) {
//        _logger->trace("Switch to script fiber");

        SwitchToFiber(scriptFiber);
    } else {
        _logger->debug("Creating script fiber");

        scriptFiber = CreateFiber(NULL, ScriptFunction, nullptr);
    }
}

HookScript hook::Hooking::script() const {
    return _script;
}

hook::GamePatterns::NativeHandler hook::Hooking::getNativeHandler(uint64_t originalHash) {
    auto &handler = _handlerCache[originalHash];

    if (handler == nullptr) {
        handler = this->handler(originalHash);
    }

    return handler;
}

bool hook::Hooking::initializeHooks() {
    _d3dHook = new VMTHook(_gamePatterns->swapChain(), 18);

    if (MH_Initialize() != MH_OK) {
        _logger->error("Could not initialize MinHook!");

        return false;
    }

    MH_CreateHook(_gamePatterns->getLabelText(), &hookGetLabelText, (void**) &_originalGetLabelText);
    MH_EnableHook(_gamePatterns->getLabelText());

    while(*_gamePatterns->gameState() != GameStatePlaying) {
        Sleep(50);
    }

    if (input::initialize() == false) {
        _logger->error("Could not initialize input hook!");

        return false;
    }

    if (hookNative() == false) {
        _logger->error("Could not initialize native hooks!");

        return false;
    }

    return true;
}

bool hook::Hooking::hookNative() {
    return native(0x812595A0644CE1DE, &hookGetFrameCount, &_originalGetFrameCount);
}

hook::GamePatterns::NativeHandler hook::Hooking::handler(uint64_t originalHash) {
    const auto newHash = CrossMapping::mapNative(originalHash);
    if (newHash == 0) {
        return nullptr;
    }

    auto *table = _gamePatterns->registrationTable()[newHash & 0xFF];

    for (; table; table = table->getNextRegistration()) {
        for (uint32_t i = 0; i < table->getNumEntries(); i++) {
            if (newHash == table->getHash(i)) {
                return table->handlers[i];
            }
        }
    }

    return nullptr;
}

void scriptWait(DWORD time) {
    // pause execution since wake time
    auto wakeTime = timeGetTime() + time;
    if (wakeTime == hook::_wakeAt) {
        wakeTime++;
    }

    hook::_wakeAt = wakeTime;

    SwitchToFiber(hook::_mainFiber);
}

void __stdcall ScriptFunction(LPVOID) {
    try {
        spdlog::get("hook")->debug("Start script");

        hook::ScriptPatches::patchMultiplayerVehicles();

        hook::hooking->script()();
    } catch (...) {
        spdlog::get("hook")->error("Unknown error starting script");
    }
}

void *__cdecl hookGetFrameCount(hook::NativeContext *context) {
    hook::hooking->onTickInit();

    return context;
}

char *hookGetLabelText(__int64 a1, BYTE *a2, __int64 a3) {
    if (hook::textLabelScript != nullptr) {
        std::string customLabel;
        if (hook::textLabelScript((const char*) a2, customLabel)) {
            return (char *) customLabel.c_str();
        }
    }

    return _originalGetLabelText(a1, a2, a3);
}
