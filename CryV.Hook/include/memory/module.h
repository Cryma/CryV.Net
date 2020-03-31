#pragma once

#include <Windows.h>

#include <memory/memoryRegion.h>

namespace hook
{
    namespace memory
    {
        class Module : public MemoryRegion
        {
        public:
            explicit Module(std::nullptr_t) : Module(static_cast<char*>(nullptr))
            {
            }

            explicit Module(const char *name) : Module(GetModuleHandleA(name))
            {
            }

            Module(HMODULE hmodule) : MemoryRegion(hmodule, 0)
            {
                const auto dosHeader = _base.as<IMAGE_DOS_HEADER*>();
                const auto ntHeader = _base.add(dosHeader->e_lfanew).as<IMAGE_NT_HEADERS64*>();
                _size = ntHeader->OptionalHeader.SizeOfImage;
            }

            IMAGE_DOS_HEADER *getDosHeader()
            {
                return _base.as<IMAGE_DOS_HEADER*>();
            }

            IMAGE_NT_HEADERS64 *getNtHeaders()
            {
                return _base.add(_base.as<IMAGE_DOS_HEADER*>()->e_lfanew).as<IMAGE_NT_HEADERS64*>();
            }

        private:
            template<typename TReturn, typename TOffset>
            TReturn getRVA(TOffset rva)
            {
                return _base.add(rva).as<TReturn>();
            }
        };
    }
}
