#pragma once

#include <Windows.h>
#include <d3d11.h>
#include <memory>
#include <vector>
#include "hooking.h"

namespace hook {
    class GamePatterns;

    class D3DRenderer {
    private:
        std::shared_ptr<GamePatterns> _gamePatterns;

    public:
        explicit D3DRenderer(std::shared_ptr<GamePatterns> gamePatterns);
        ~D3DRenderer() noexcept;

        D3DRenderer(D3DRenderer const&) = delete;
        D3DRenderer(D3DRenderer&&) = delete;
        D3DRenderer& operator=(D3DRenderer const&) = delete;
        D3DRenderer& operator=(D3DRenderer&&) = delete;

		static void registerPresentCallback(D3DCallback callback);
		static void registerPreResizeCallback(D3DCallback callback);
		static void registerPostResizeCallback(D3DCallback callback);

		ID3D11Device* device() const;
		ID3D11DeviceContext* deviceContext() const;

		void present();
        void preResize();
        void postResize();

        void wndProc(HWND hwnd, UINT msg, WPARAM wparam, LPARAM lparam);

    private:
        ID3D11Device *_device{};
        ID3D11DeviceContext *_context{};

		static std::vector<D3DCallback> _presentCallbacks;
		static std::vector<D3DCallback> _preResizeCallbacks;
		static std::vector<D3DCallback> _postResizeCallbacks;

    };
}
