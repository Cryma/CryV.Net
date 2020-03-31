#pragma once

#include <Windows.h>
#include <vector>
#include <unordered_map>

#include <spdlog/spdlog.h>
#include <MinHook.h>

#include <sdk/main.h>
#include <sdk/types.h>

#include <d3d11.h>
#include <gamePatterns.h>

namespace hook {
    static HANDLE _mainFiber;
    static DWORD _wakeAt;

    class Hooking {
    private:
        std::shared_ptr<spdlog::logger> _logger;
        std::shared_ptr<GamePatterns> _gamePatterns;

        VMTHook *_d3dHook;
        std::vector<LPVOID> _hooks;
        std::unordered_map<uint64_t, GamePatterns::NativeHandler> _handlerCache;
        HookScript _script;

    public:
        Hooking(std::shared_ptr<GamePatterns> gamePatterns, HookScript script);
        bool initializeHooks();
        void cleanup();

        void onTickInit();

        HookScript script() const;

        GamePatterns::NativeHandler getNativeHandler(uint64_t originalHash);

    private:
        bool hookNative();
        GamePatterns::NativeHandler handler(uint64_t originalHash);

        template<typename T>
        bool native(DWORD64 hash, LPVOID hookFunction, T **trampoline) {
            if (*reinterpret_cast<LPVOID*>(trampoline) != nullptr) {
                return true;
            }

            const auto originalFunction = getNativeHandler(hash);
            if (originalFunction != 0) {
                const auto hookStatus = MH_CreateHook(originalFunction, hookFunction, reinterpret_cast<LPVOID*>(trampoline));

                if ((hookStatus == MH_OK || hookStatus == MH_ERROR_ALREADY_CREATED) && MH_EnableHook(originalFunction) == MH_OK) {
                    return true;
                }
            }

            _logger->error("Hook creation failed");

            return false;
        }
    };
}
