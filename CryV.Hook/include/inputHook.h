#pragma once

#include <Windows.h>
#include <set>

#include "sdk/main.h"

#define KeyStateDown(key)(GetAsyncKeyState(key) & 0x8000) != 0
#define KeyStateToggled(key) GetKeyState(key) & 0x0001) != 0

namespace hook::input {
    bool initialize();
    void remove();

    static std::set<KeyboardHandler> _keyboardFunctions;

    typedef void(*TWndProcFn)(UINT uMsg, WPARAM wParam, LPARAM lParam);
    static std::set<TWndProcFn> _wndProcCb;

    static LRESULT APIENTRY WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
    static void wndProc(HWND /*hwnd*/, UINT uMsg, WPARAM wParam, LPARAM lParam);
}
