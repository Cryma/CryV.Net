#pragma once

#include <sdk/main.h>

#include "CryV.h"

#ifdef _WIN32
#define CRYV_API extern "C" __declspec(dllexport)
#else
#define CRYV_API extern "C"
#endif

CRYV_API void EntryPoint();
