#pragma once

#include <vector>
#include <string>
#include <d3d11.h>

#include <sdk/types.h>

typedef void(*HookScript)();
typedef bool(*TextLabelScript)(const char *label, std::string &customLabel);

void startHook(HMODULE module, HookScript hookScript, TextLabelScript textLabelScript);
void scriptWait(DWORD time);
void setHookLogDirectory(const std::string &directory);
void createHookLog();

typedef void(*KeyboardHandler)(DWORD key, WORD repeats, BYTE scanCode, BOOL isExtended, BOOL isWithAlt, BOOL wasDownBefore, BOOL isUpNow);
void keyboardRegister(KeyboardHandler handler);

int getAllVehicles(std::vector<int32_t> &vehicles);
CVehicle *getVehicleFromHandle(const Vehicle &vehicleHandle);

int getAllPeds(std::vector<int32_t> &peds);
CPed *getPedFromHandle(const Ped &pedHandle);

int getAllObjects(std::vector<int32_t> &objects);
CObject *getObjectFromHandle(const Object &objectHandle);

CVehicleInterface* getVehicleInterface();
int getEntityFromPointer(void* pointer);

typedef void(*D3DCallback)();
void registerD3DPresentCallback(D3DCallback callback);
void registerD3DPreResizeCallback(D3DCallback callback);
void registerD3DPostResizeCallback(D3DCallback callback);

ID3D11Device* d3d11Device();
ID3D11DeviceContext* d3d11DeviceContext();
IDXGISwapChain* d3d11SwapChain();
