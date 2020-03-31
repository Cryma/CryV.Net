#include <nativeInvoker.h>

#include "hook.h"

static hook::NativeManagerContext _context;
static UINT64 _hash;

void(*hook::ScrNativeCallContext::SetVectorResults)(hook::ScrNativeCallContext*) = nullptr;

void nativeInit(UINT64 hash) {
    _context.reset();
    _hash = hash;
}

void nativePush64(UINT64 value) {
    _context.push(value);
}

uint64_t *nativeCall() {
    const auto function = hook::hooking->getNativeHandler(_hash);

    if (function != nullptr) {
        void* exceptionAddress;

        __try {
            function(&_context);
            hook::ScrNativeCallContext::SetVectorResults(&_context);
        } __except (exceptionAddress = (GetExceptionInformation())->ExceptionRecord->ExceptionAddress, EXCEPTION_EXECUTE_HANDLER) {
        }
    }

    return reinterpret_cast<uint64_t*>(_context.getResultPointer());
}
