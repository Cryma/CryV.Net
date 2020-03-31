#include "hook.h"

#include "sdk/main.h"
#include "d3dRenderer.h"
#include "gamePatterns.h"
#include "hooking.h"

#include <filesystem>

#ifndef ALMP_HOOK_LOG_FILE
#define ALMP_HOOK_LOG_FILE "almp.log"
#endif

static std::string _logDirectory;
static std::shared_ptr<hook::GamePatterns> _gamePatterns = nullptr;
static std::shared_ptr<hook::D3DRenderer> _d3dRenderer = nullptr;
static std::shared_ptr<hook::VMTHook> _swapchainHook = nullptr;

namespace hook {
	std::shared_ptr<Hooking> hooking = nullptr;
	std::shared_ptr<spdlog::sinks::basic_file_sink_mt> loggerFileSink = nullptr;

	TextLabelScript textLabelScript;

	HRESULT swapchainPresent(IDXGISwapChain* swapChain, UINT syncInterval, UINT flags) {
		_d3dRenderer->present();

		return _swapchainHook->GetOriginal<decltype(&swapchainPresent)>(8)(swapChain, syncInterval, flags);
	}

	HRESULT swapchainResizeBuffers(IDXGISwapChain* swapChain, UINT bufferCount, UINT width, UINT height, DXGI_FORMAT newFormat, UINT flags) {
		_d3dRenderer->preResize();

		auto result = _swapchainHook->GetOriginal<decltype(&swapchainResizeBuffers)>(13)(swapChain, bufferCount, width, height, newFormat, flags);

		if (SUCCEEDED(result))
		{
			_d3dRenderer->postResize();
		}

		return result;
	}

	DWORD WINAPI startup(LPVOID) {
		// TODO: Add return value and handle errors in initialization here
		_gamePatterns->initialize();

		_d3dRenderer = std::make_shared<hook::D3DRenderer>(_gamePatterns);
		_swapchainHook = std::make_shared<hook::VMTHook>(_gamePatterns->swapChain(), 19);
		_swapchainHook->Hook(swapchainPresent, 8);
		_swapchainHook->Hook(swapchainResizeBuffers, 13);

		_swapchainHook->Enable();

		if (hooking->initializeHooks() == false) {
			hooking->cleanup();
		}

		return TRUE;
	}
}

void startHook(HMODULE, HookScript hookScript, TextLabelScript textLabelScript) {
	// create logger if not existing
	if (hook::loggerFileSink == nullptr) {
	    createHookLog();
	}

	hook::textLabelScript = textLabelScript;
	_gamePatterns = std::make_shared<hook::GamePatterns>();

	hook::hooking = std::make_unique<hook::Hooking>(_gamePatterns, hookScript);

	CreateThread(nullptr, NULL, static_cast<LPTHREAD_START_ROUTINE>(hook::startup), nullptr, NULL, nullptr);
}

void setHookLogDirectory(const std::string &directory) {
    if (std::filesystem::exists(directory) == false) {
        return;
    }

    _logDirectory = directory;
}

void createHookLog() {
    std::string path;

    if (_logDirectory.empty() == false) {
        path = _logDirectory + "/" + ALMP_HOOK_LOG_FILE;
    } else {
        path = ALMP_HOOK_LOG_FILE;
    }

    hook::loggerFileSink = std::make_shared<spdlog::sinks::basic_file_sink_mt>(path);

    auto logger = std::make_shared<spdlog::logger>("hook", hook::loggerFileSink);
    logger->set_level(spdlog::level::trace);
    logger->flush_on(spdlog::level::trace);
    spdlog::register_logger(logger);

    logger->info("==========");
}

int getAllVehicles(std::vector<int32_t>& vehicles) {
	for (auto i = 0; i < _gamePatterns->replayInterface()->VehicleInterface->MaxVehicles; i++) {
		auto* vehicle = _gamePatterns->replayInterface()->VehicleInterface->getVehicle(i);

		const auto handle = _gamePatterns->replayInterface()->VehicleInterface->VehicleList->VehicleHandles[i].Handle;
		if (handle == 65535) {
			continue;
		}

		vehicles.push_back(_gamePatterns->addressToEntity(vehicle));
	}

	return _gamePatterns->replayInterface()->VehicleInterface->CurrentVehicles;
}

CVehicle* getVehicleFromHandle(const Vehicle& vehicleHandle) {
	const auto vehicleInterface = _gamePatterns->replayInterface()->VehicleInterface;

	for (auto i = 0; i < vehicleInterface->MaxVehicles; i++) {
		auto* vehicle = vehicleInterface->getVehicle(i);
		if (vehicle == nullptr)
		{
			continue;
		}

		const auto handle = _gamePatterns->addressToEntity(vehicle);
		if (handle == vehicleHandle) {
			return vehicle;
		}
	}

	return nullptr;
}

int getAllPeds(std::vector<int32_t>& peds) {
	const auto pedInterface = _gamePatterns->replayInterface()->PedInterface;

	for (auto i = 0; i < pedInterface->MaxPeds; i++) {
		auto* ped = pedInterface->getPed(i);

		const auto handle = pedInterface->PedList->PedHandles[i].Handle;
		if (handle == 65535) {
			continue;
		}

		peds.push_back(_gamePatterns->addressToEntity(ped));
	}

	return pedInterface->CurrentPeds;
}

CPed* getPedFromHandle(const Ped& pedHandle) {
	const auto pedInterface = _gamePatterns->replayInterface()->PedInterface;
	for (auto i = 0; i < pedInterface->MaxPeds; i++) {
		auto* ped = pedInterface->getPed(i);
		if (ped == nullptr)
		{
			continue;
		}

		const auto handle = _gamePatterns->addressToEntity(ped);
		if (handle == pedHandle) {
			return ped;
		}
	}

	return nullptr;
}

int getAllObjects(std::vector<int32_t>& objects) {
	const auto objectInterface = _gamePatterns->replayInterface()->ObjectInterface;

	for (auto i = 0; i < objectInterface->CurrentObjects; i++) {
		auto* object = objectInterface->getObject(i);

		const auto handle = objectInterface->ObjectList->ObjectHandles[i].Handle;
		if (handle == 65535) {
			continue;
		}

		objects.push_back(_gamePatterns->addressToEntity(object));
	}

	return objectInterface->CurrentObjects;
}

CObject* getObjectFromHandle(const Object& objectHandle) {
	const auto objectInterface = _gamePatterns->replayInterface()->ObjectInterface;

	for (auto i = 0; i < objectInterface->CurrentObjects; i++) {
		auto* object = objectInterface->getObject(i);

		const auto handle = objectInterface->ObjectList->ObjectHandles[i].Handle;
		if (handle == objectHandle) {
			return object;
		}
	}

	return nullptr;
}

CVehicleInterface* getVehicleInterface() {
	return _gamePatterns->replayInterface()->VehicleInterface;
}

int getEntityFromPointer(void* pointer)
{
	return _gamePatterns->addressToEntity(pointer);
}

void registerD3DPresentCallback(D3DCallback callback)
{
	_d3dRenderer->registerPresentCallback(callback);
}

void registerD3DPreResizeCallback(D3DCallback callback)
{
	_d3dRenderer->registerPreResizeCallback(callback);
}

void registerD3DPostResizeCallback(D3DCallback callback)
{
	_d3dRenderer->registerPostResizeCallback(callback);
}

ID3D11Device* d3d11Device()
{
	return _d3dRenderer->device();
}

ID3D11DeviceContext* d3d11DeviceContext()
{
	return _d3dRenderer->deviceContext();
}

IDXGISwapChain* d3d11SwapChain()
{
	return _gamePatterns->swapChain();
}
