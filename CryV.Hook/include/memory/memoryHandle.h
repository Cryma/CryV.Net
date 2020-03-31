#pragma once

#include <cstdint>
#include <type_traits>

namespace hook
{
    namespace memory
    {
        class MemoryHandle
        {
        public:
            constexpr MemoryHandle(void* p = nullptr) : _ptr(p)
            {
            }

            explicit MemoryHandle(std::uintptr_t p) : _ptr(reinterpret_cast<void*>(p))
            {
            }

            template<typename T>
            constexpr std::enable_if_t<std::is_pointer_v<T>, T> as()
            {
                return static_cast<T>(_ptr);
            }

            template<typename T>
            constexpr std::enable_if_t<std::is_lvalue_reference_v<T>, T> as()
            {
                return *static_cast<std::add_pointer_t<std::remove_reference_t<T>>>(_ptr);
            }

            template<typename T>
            constexpr std::enable_if_t<std::is_same_v<T, std::uintptr_t>, T> as()
            {
                return reinterpret_cast<T>(_ptr);
            }

            template<typename T>
            constexpr MemoryHandle add(T offset)
            {
                return MemoryHandle(as<std::uintptr_t>() + offset);
            }

            template<typename T>
            constexpr MemoryHandle sub(T offset)
            {
                return MemoryHandle(as<std::uintptr_t>() - offset);
            }

            constexpr MemoryHandle rip()
            {
                if(_ptr == nullptr)
                {
                    return nullptr;
                }

                return add(as<std::int32_t&>()).add(4U);
            }

            constexpr explicit operator bool() noexcept
            {
                return _ptr;
            }

        protected:
            void *_ptr;
        };
    }
}
