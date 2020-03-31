#include "d3dRenderer.h"

#include "gamePatterns.h"

namespace hook {
	std::vector<D3DCallback> D3DRenderer::_presentCallbacks;
	std::vector<D3DCallback> D3DRenderer::_preResizeCallbacks;
	std::vector<D3DCallback> D3DRenderer::_postResizeCallbacks;

    D3DRenderer::D3DRenderer(std::shared_ptr<GamePatterns> gamePatterns) {
        _gamePatterns = gamePatterns;

		void* d3dDevice{};
		if(SUCCEEDED(_gamePatterns->swapChain()->GetDevice(__uuidof(ID3D11Device), &d3dDevice)) == false)
		{
			return;
		}

		_device = static_cast<ID3D11Device*>(d3dDevice);
		_device->GetImmediateContext(&_context);
    }

    D3DRenderer::~D3DRenderer() noexcept {}

    void D3DRenderer::registerPresentCallback(D3DCallback callback)
    {
		_presentCallbacks.push_back(callback);
    }

    void D3DRenderer::registerPreResizeCallback(D3DCallback callback)
    {
		_preResizeCallbacks.push_back(callback);
    }

    void D3DRenderer::registerPostResizeCallback(D3DCallback callback)
    {
		_postResizeCallbacks.push_back(callback);
    }

    ID3D11Device* D3DRenderer::device() const
    {
		return _device;
    }

    ID3D11DeviceContext* D3DRenderer::deviceContext() const
    {
		return _context;
    }

    void D3DRenderer::present()
    {
	    for(const auto callback : _presentCallbacks)
	    {
			callback();
	    }
    }

    void D3DRenderer::preResize()
    {
		for (const auto callback : _preResizeCallbacks)
		{
			callback();
		}
    }

    void D3DRenderer::postResize()
    {
		for (const auto callback : _postResizeCallbacks)
		{
			callback();
		}
    }

    void D3DRenderer::wndProc(HWND hwnd, UINT msg, WPARAM wparam, LPARAM lparam) {}
}
