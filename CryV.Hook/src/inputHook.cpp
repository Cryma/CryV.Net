#include <inputHook.h>

WNDPROC _wndProc;
HWND _window;

LRESULT APIENTRY hook::input::WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam) {
    wndProc(hwnd, uMsg, wParam, lParam);

    return CallWindowProc(_wndProc, hwnd, uMsg, wParam, lParam);
}

bool hook::input::initialize() {
    _window = FindWindowA("grcWindow", NULL);

    _wndProc = (WNDPROC) SetWindowLongPtr(_window, GWLP_WNDPROC, (LONG_PTR) WndProc);

    return _wndProc != NULL;
}

void hook::input::remove() {
    SetWindowLongPtr(_window, GWLP_WNDPROC, (LONG_PTR) _wndProc);
}

void hook::input::wndProc(HWND /*hwnd*/, UINT uMsg, WPARAM wParam, LPARAM lParam) {
    for (auto & function : _wndProcCb) {
        function(uMsg, wParam, lParam);
    }

    if (uMsg == WM_KEYDOWN || uMsg == WM_KEYUP || uMsg == WM_SYSKEYDOWN || uMsg == WM_SYSKEYUP) {
        for (auto & function : _keyboardFunctions) {
            function((DWORD) wParam, lParam & 0xFFFF, (lParam >> 16) & 0xFF, (lParam >> 24) & 1,
                (uMsg == WM_SYSKEYDOWN || uMsg == WM_SYSKEYUP), (lParam >> 30) & 1,
                (uMsg == WM_SYSKEYUP || uMsg == WM_KEYUP));
        }
    }
}

void keyboardRegister(KeyboardHandler handler) {
    hook::input::_keyboardFunctions.insert(handler);
}
