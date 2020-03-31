#pragma once

#include <Windows.h>
#include <memory>
#include <spdlog/sinks/basic_file_sink.h>

#include "sdk/main.h"

#include "gamePatterns.h"
#include "hooking.h"

namespace hook {
    extern std::shared_ptr<Hooking> hooking;
    extern std::shared_ptr<spdlog::sinks::basic_file_sink_mt> loggerFileSink;
    extern TextLabelScript textLabelScript;
}
