#pragma once

#include <vector>
#include <unordered_map>

namespace hook {
    typedef std::unordered_map<uint64_t, uint64_t> NativeMap;

    class CrossMapping {
    private:
        static NativeMap _nativeHashMap;
        static NativeMap _nativeCache;
        static std::vector<uint64_t> _unknownNatives;

    public:
        static void initNativeMap();
        static uint64_t mapNative(uint64_t inNative);

    private:
        static bool searchMap(NativeMap map, uint64_t inNative, uint64_t *outNative);
    };
}
