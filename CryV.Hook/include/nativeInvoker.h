#pragma once

#include <Windows.h>
#include <cstdint>

namespace hook {
    class ScrNativeCallContext
    {
    protected:

        void* _return;
        uint32_t _argCount;
        void* _args;
        uint32_t _dataCount;
        alignas(uintptr_t)uint8_t _vectorSpace[192];

    public:
        template<typename T>
        T getArgument(int idx)
        {
            intptr_t * arguments = static_cast<intptr_t*>(_args);
            return *static_cast<T*>(&arguments[idx]);
        }

        template<typename T>
        void setResult(int idx, T value)
        {
            intptr_t * returnValues = static_cast<intptr_t*>(_return);
            *static_cast<T*>(&returnValues[idx]) = value;
        }

        int getArgumentCount() const
        {
            return _argCount;
        }

        template<typename T>
        T getResult(int idx)
        {
            intptr_t * returnValues = static_cast<intptr_t*>(_return);
            return *static_cast<T*>(&returnValues[idx]);
        }

        static void(*SetVectorResults)(ScrNativeCallContext*);
    };

    class NativeContext : public ScrNativeCallContext
    {
    private:
        enum
        {
            MaxNativeParams = 16,
            ArgSize = 8,
        };

        uint8_t _tempStack[MaxNativeParams * ArgSize];

    public:
        NativeContext()
        {
            _args = &_tempStack;
            _return = &_tempStack;

            _argCount = 0;
            _dataCount = 0;
        }

        template <typename T>
        void push(T value)
        {
            if ( sizeof( T ) > ArgSize )
            {
                throw "Argument has an invalid size";
            }

            if ( sizeof( T ) < ArgSize )
            {
                *reinterpret_cast<uintptr_t*>( _tempStack + ArgSize * _argCount ) = 0;
            }

            *reinterpret_cast<T*>( _tempStack + ArgSize * _argCount ) = value;
            _argCount++;
        }

        void reverse()
        {
            uintptr_t tempValues[MaxNativeParams];
            const auto args = static_cast<uintptr_t*>(_args);

            for (uint32_t i = 0; i < _argCount; i++)
            {
                const int target = _argCount - i - 1;
                tempValues[target] = args[i];
            }

            memcpy(_tempStack, tempValues, sizeof _tempStack);
        }

        template <typename T>
        T getResult()
        {
            return *reinterpret_cast<T*>(_tempStack);
        }

    };

    struct Pass
    {
        template<typename ...T> Pass( T... ) {}
    };

    class NativeManagerContext : public NativeContext
    {
    public:

        NativeManagerContext() : NativeContext() {}

        void reset()
        {
            _argCount = 0;
            _dataCount = 0;
        }

        void* getResultPointer() const
        {
            return _return;
        }

    };
}

void nativeInit(UINT64 hash);
void nativePush64(UINT64 value);
uint64_t *nativeCall();
