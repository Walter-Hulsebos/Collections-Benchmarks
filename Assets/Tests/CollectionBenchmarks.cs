using I32 = System.Int32;

internal static partial class CollectionBenchmarks
{
    private const I32 WARMUP_COUNT      = 32; //Warmup is necessary to ensure the JIT compiler has compiled the methods before measuring.
    private const I32 MEASUREMENT_COUNT = 128;
    
    //Array
    //NativeArray
    //List
    //NativeList
    //HashSet
    //NativeHashSet
    //Dictionary
    //NativeHashMap
}