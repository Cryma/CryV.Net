#include <gamePatterns.h>

#include <spdlog/spdlog.h>
#include <chrono>

#include <memory/signature.h>
#include "crossmapping.h"

namespace hook
{
    GamePatterns::GamePatterns() {
        _frameCount = nullptr;
        _gameState = nullptr;
        _replayInterface = nullptr;
        _swapchain = nullptr;
        _addressToEntity = nullptr;
        _registrationTable = nullptr;
        _getLabelText = nullptr;
    }

    void GamePatterns::initialize() {
		auto logger = spdlog::get("hook");

		auto logos = memory::Signature("70 6C 61 74 66 6F 72 6D 3A").scan().as<char*>();
		if(logos == nullptr)
		{
			logger->critical("Logos pattern could not be found.");

			return;
		}

		std::fill_n(logos, 1, '\xC3');

        auto gameLegalSkip = memory::Signature("72 1F E8 ? ? ? ? 8B 0D").scan().as<char*>();
		if(gameLegalSkip == nullptr)
		{
			logger->critical("GameLegal skip pattern could not be found.");

			return;
		}

        std::fill_n(gameLegalSkip, 2, '\x90');

        _frameCount = memory::Signature("8B 15 ? ? ? ? 41 FF CF").scan().add(2).rip().as<decltype(_frameCount)>();
		if(_frameCount == nullptr)
		{
			logger->critical("FrameCount pattern could not be found.");

			return;
		}

        _gameState = memory::Signature("83 3D ? ? ? ? ? 8A D9 74 0A").scan().add(2).rip().as<decltype(_gameState)>();
		if(_gameState == nullptr)
		{
			logger->critical("GameState pattern could not be found.");

			return;
		}

        _swapchain = memory::Signature("48 8B 0D ? ? ? ? 48 8D 55 A0 48 8B 01").scan().add(3).rip().as<decltype(_swapchain)&>();
		const auto start = std::chrono::system_clock::now().time_since_epoch().count();
		while(_swapchain == nullptr)
		{
			Sleep(20);

			_swapchain = memory::Signature("48 8B 0D ? ? ? ? 48 8D 55 A0 48 8B 01").scan().add(3).rip().as<decltype(_swapchain)&>();

			if(start + 2500 < std::chrono::system_clock::now().time_since_epoch().count())
			{
				logger->critical("Swapchain pattern could not be found.");

				return;
			}
		}

        _addressToEntity = memory::Signature("48 89 5C 24 ? 48 89 74 24 ? 57 48 83 EC 20 8B 15 ? ? ? ? 48 8B F9 48 83 C1 10 33 DB").scan().as<decltype(_addressToEntity)>();
		if(_addressToEntity == nullptr)
		{
			logger->critical("AddressToEntity pattern could not be found.");

			return;
		}

        _registrationTable = memory::Signature("76 32 48 8B 53 40 48 8D 0D").scan().add(9).rip().as<decltype(_registrationTable)>();
		if(_registrationTable == nullptr)
		{
			logger->critical("RegistrationTable pattern could not be found.");

			return;
		}

    	_getLabelText = memory::Signature("75 ? E8 ? ? ? ? 8B 0D ? ? ? ? 65 48 8B 04 25 ? ? ? ? BA ? ? ? ? 48 8B 04 C8 8B 0C 02 D1 E9").scan().sub(19).as<decltype(_getLabelText)>();
		if(_getLabelText == nullptr)
		{
			logger->critical("GetLabelText pattern could not be found.");

			return;
		}

        char *replayTemporary = memory::Signature("48 8B 05 ? ? ? ? 41 8B 1E").scan().as<char*>() + 0xEE;
        _replayInterface = *(CReplayInterface**) (replayTemporary + *(DWORD*) (replayTemporary + 0x3) + 0x7);
		if(_replayInterface == nullptr)
		{
			logger->critical("ReplayInterface pattern could not be found.");

			return;
		}

        ScrNativeCallContext::SetVectorResults = memory::Signature("83 79 18 00 48 8B D1 74 4A FF 4A 18").scan().as<decltype(ScrNativeCallContext::SetVectorResults)>();
		if(ScrNativeCallContext::SetVectorResults == nullptr)
		{
			logger->critical("VectorResults pattern could not be found.");

			return;
		}

        auto storyModeSkip = memory::Signature("48 83 3D ? ? ? ? ? 88 05 ? ? ? ? 75 0B").scan().add(8).as<char*>();
		if(storyModeSkip == nullptr)
		{
			logger->critical("StoryModeSkip pattern could not be found.");

			return;
		}

        std::fill_n(storyModeSkip, 6, '\x90');

        auto modelCheckSkip = memory::Signature("48 85 C0 0F 84 ? ? ? ? 8B 48 50").scan().as<char*>();
		if(modelCheckSkip == nullptr)
		{
			logger->critical("ModelCheckSkip pattern could not be found.");

			return;
		}

        std::fill_n(modelCheckSkip, 24, '\x90');

        auto modelSpawnFix = memory::Signature("48 8B C8 FF 52 30 84 C0 74 05 48").scan().add(8).as<char*>();
		if(modelSpawnFix == nullptr)
		{
			logger->critical("ModelSpawnFix pattern could not be found.");

			return;
		}

        std::fill_n(modelSpawnFix, 2, '\x90');

		while(*_gameState == 0) {
			Sleep(50);
		}

        CrossMapping::initNativeMap();
    }

    int GamePatterns::addressToEntity(void *address) {
        return reinterpret_cast<int(*)(void *)>(_addressToEntity)(address);
    }

    CReplayInterface *GamePatterns::replayInterface() const {
        return _replayInterface;
    }

    IDXGISwapChain *GamePatterns::swapChain() const {
        return _swapchain;
    }

    GamePatterns::NativeRegistrationNew **GamePatterns::registrationTable() const {
        return _registrationTable;
    }

    GamePatterns::GetLabelText *GamePatterns::getLabelText() const {
        return _getLabelText;
    }

    eGameState *GamePatterns::gameState() const {
        return _gameState;
    }
}
