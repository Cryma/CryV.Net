#pragma once

#include <vector>

#include <memory/memoryHandle.h>
#include <memory/memoryRegion.h>
#include <memory/module.h>

namespace hook
{
    namespace memory
    {
        class Signature
        {
        public:
            struct Element
            {
                std::uint8_t _data{};
                bool _wildcard{};
            };

            explicit Signature(const char *pattern) {
                auto toUpper = [](char c) -> char {
                    return c >= 'a' && c <= 'z' ? static_cast<char>(c + ('A' - 'a')) : static_cast<char>(c);
                };

                auto isHex = [&](char c) -> bool {
                    switch (toUpper(c)) {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                        return true;
                    default:
                        return false;

                    }
                };

                do {
                    if (*pattern == ' ') {
                        continue;
                    }

                    if (*pattern == '?') {
                        _elements.push_back(Element{ {}, true });
                        continue;
                    }

                    if(*(pattern + 1) && isHex(*pattern) && isHex(*(pattern + 1)))
                    {
                        char str[3] = { *pattern, *(pattern + 1), '\0' };
                        auto data = std::strtol(str, nullptr, 16);

                        _elements.push_back(Element{ static_cast<std::uint8_t>(data), false });
                    }
                } while (*(pattern++));
            }

            MemoryHandle scan(MemoryRegion region = Module(nullptr))
            {
                auto compareMemory = [](std::uint8_t *data, Element *element, std::size_t num) -> bool
                {
                    for(std::size_t i = 0; i < num; ++i)
                    {
                        if(element[i]._wildcard == false)
                        {
                            if(data[i] != element[i]._data)
                            {
                                return false;
                            }
                        }
                    }

                    return true;
                };

                for(std::uintptr_t i = region.base().as<std::uintptr_t>(), end = region.end().as<std::uintptr_t>(); i != end; ++i)
                {
                    if(compareMemory(reinterpret_cast<std::uint8_t*>(i), _elements.data(), _elements.size()))
                    {
                        return MemoryHandle(i);
                    }
                }

                return {};
            }

            private:
                std::vector<Element> _elements;
        };
    }
}
