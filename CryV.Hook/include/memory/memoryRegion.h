#pragma once

#include <memory/memoryHandle.h>

namespace hook
{
    namespace memory
    {
        class MemoryRegion
        {
        public:
            constexpr explicit MemoryRegion(MemoryHandle base, std::size_t size) : _base(base), _size(size)
            {
            }

            constexpr MemoryHandle base() const
            {
                return _base;
            }

            constexpr MemoryHandle end()
            {
                return _base.add(_size);
            }

            constexpr std::size_t size() const
            {
                return _size;
            }

            constexpr bool contains(MemoryHandle p)
            {
                if(p.as<std::uintptr_t>() < _base.as<std::uintptr_t>())
                {
                    return false;
                }

                if(p.as<std::uintptr_t>() > _base.add(_size).as<std::uintptr_t>())
                {
                    return false;
                }

                return true;
            }

        protected:
            MemoryHandle _base;
            std::size_t _size;
        };
    }
}
