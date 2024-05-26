using JetBrains.Annotations;

using NUnit.Framework;

using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.PerformanceTesting;

using I32 = System.Int32;
using I64 = System.Int64;

internal static partial class CollectionBenchmarks
{
    #region Indexing

    private static readonly SampleGroup benchmark_nativelistburst_indexing_10 = new(name: "NativeList Burst Indexing Time (10)", SampleUnit.Nanosecond); 
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Indexing_10()
    {
        const I32 COUNT = 10;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __sum += __data[__index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_indexing_10)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_indexing_100 = new(name: "NativeList Burst Indexing Time (100)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Indexing_100()
    {
        const I32 COUNT = 100;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __sum += __data[__index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_indexing_100)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_indexing_1000 = new(name: "NativeList Burst Indexing Time (1000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Indexing_1000()
    {
        const I32 COUNT = 1000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, Allocator.Temp);
        // for (I32 __index = 0; __index < COUNT; __index += 1)
        // {
        //     __data.Add(__index);
        // }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __sum += __data[__index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_indexing_1000)
               //.SetUp(() => Setup(count: COUNT, out __data))
               .SetUp(() => Setup(count: COUNT, ref __data))
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_indexing_10000 = new(name: "NativeList Burst Indexing Time (10,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Indexing_10000()
    {
        const I32 COUNT = 10_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __sum += __data[__index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_indexing_10000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_indexing_100000 = new(name: "NativeList Burst Indexing Time (100,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Indexing_100000()
    {
        const I32 COUNT = 100_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __sum += __data[__index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_indexing_100000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_indexing_1000000 = new(name: "NativeList Burst Indexing Time (1,000,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Indexing_1000000()
    {
        const I32 COUNT = 1_000_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __sum += __data[__index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_indexing_1000000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    
    #endregion

    #region Search
    
    [BurstCompile]
    private struct NativeListSearchJob : IJob
    {
        [ReadOnly]
        public NativeList<I32> data;

        [ReadOnly]
        public readonly I32    searchValue;
        
        
        //public NativeArray<I32> result;
        public I32 result;

        //public NativeListSearchJob(NativeList<I32> data, I32 searchValue, NativeArray<I32> result)
        public NativeListSearchJob(NativeList<I32> data, I32 searchValue, I32 result)
        {
            this.data        = data;
            this.searchValue = searchValue;
            this.result      = result;
        }

        public void Execute()
        {
            //result[0] = data.IndexOf(searchValue);
            result = data.IndexOf(searchValue);
        }
    }

    private static readonly SampleGroup benchmark_nativelistburst_search_10 = new(name: "NativeList Burst Search Time (10)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Search_10()
    {
        const I32 COUNT = 10;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store the result to prevent optimization
        //NativeArray<int> result       = new(length: 1, Allocator.TempJob);
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    NativeListSearchJob __job = new(
                        data: __data,
                        searchValue: SEARCH_VALUE,
                        result: __foundIndex
                    );
                    
                    __job.Schedule().Complete();
                    //__job.Run();
                    //__job.result.Dispose();
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_search_10)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_search_100 = new(name: "NativeList Burst Search Time (100)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Search_100()
    {
        const I32 COUNT = 100;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    //__foundIndex = __data.IndexOf(SEARCH_VALUE);
                    NativeListSearchJob __job = new(
                                                    data: __data,
                                                    searchValue: SEARCH_VALUE,
                                                    result: __foundIndex
                                                   );
                    
                    __job.Schedule().Complete();
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_search_100)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_search_1000 = new(name: "NativeList Burst Search Time (1000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Search_1000()
    {
        const I32 COUNT = 1000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    //__foundIndex = __data.IndexOf(SEARCH_VALUE);
                    NativeListSearchJob __job = new(
                                                    data: __data,
                                                    searchValue: SEARCH_VALUE,
                                                    result: __foundIndex
                                                   );
                    __job.Schedule().Complete();
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_search_1000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_search_10000 = new(name: "NativeList Burst Search Time (10,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Search_10000()
    {
        const I32 COUNT = 10_000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    //__foundIndex = __data.IndexOf(SEARCH_VALUE);
                    NativeListSearchJob __job = new(
                                                    data: __data,
                                                    searchValue: SEARCH_VALUE,
                                                    result: __foundIndex
                                                   );
                    __job.Schedule().Complete();
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_search_10000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_search_100000 = new(name: "NativeList Burst Search Time (100,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Search_100000()
    {
        const I32 COUNT = 100_000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    //__foundIndex = __data.IndexOf(SEARCH_VALUE);
                    NativeListSearchJob __job = new(
                                                    data: __data,
                                                    searchValue: SEARCH_VALUE,
                                                    result: __foundIndex
                                                   );
                    
                    __job.Schedule().Complete();
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_search_100000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_search_1000000 = new(name: "NativeList Burst Search Time (1,000,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Search_1000000()
    {
        const I32 COUNT = 1_000_000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    //__foundIndex = __data.IndexOf(SEARCH_VALUE);
                    NativeListSearchJob __job = new(
                                                    data: __data,
                                                    searchValue: SEARCH_VALUE,
                                                    result: __foundIndex
                                                   );
                    
                    __job.Schedule().Complete();
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_search_1000000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }

    #endregion

    #region BinarySearch
    
    private static readonly SampleGroup benchmark_nativelistburst_binarysearch_10 = new(name: "NativeList Burst BinarySearch Time (10)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_BinarySearch_10()
    {
        const I32 COUNT = 10;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_binarysearch_10)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    
    private static readonly SampleGroup benchmark_nativelistburst_binarysearch_100 = new(name: "NativeList Burst BinarySearch Time (100)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_BinarySearch_100()
    {
        const I32 COUNT = 100;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_binarysearch_100)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_binarysearch_1000 = new(name: "NativeList Burst BinarySearch Time (1000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_BinarySearch_1000()
    {
        const I32 COUNT = 1000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_binarysearch_1000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_binarysearch_10000 = new(name: "NativeList Burst BinarySearch Time (10,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_BinarySearch_10000()
    {
        const I32 COUNT = 10_000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_binarysearch_10000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_binarysearch_100000 = new(name: "NativeList Burst BinarySearch Time (100,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_BinarySearch_100000()
    {
        const I32 COUNT = 100_000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_binarysearch_100000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_binarysearch_1000000 = new(name: "NativeList Burst BinarySearch Time (1,000,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_BinarySearch_1000000()
    {
        const I32 COUNT = 1_000_000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(__index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_binarysearch_1000000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }

    #endregion

    // [UsedImplicitly]
    // private static void Setup(in I32 count, ref NativeList<I32> data)
    // {
    //     //data = new NativeList<I32>(initialCapacity: count, Allocator.Temp);
    //     data.SetCapacity(capacity: count);
    //     
    //     for (I32 __index = 0; __index < count; __index += 1)
    //     {
    //         data.Add(__index);
    //     }
    // }
    // private static void Setup(int count, out NativeList<I32> data)
    // {
    //     data = new NativeList<I32>(initialCapacity: count, Allocator.Temp);
    //     for (I32 __index = 0; __index < count; __index += 1)
    //     {
    //         data.Add(__index);
    //     }
    // }
    
    #region Insertion

    private static readonly SampleGroup benchmark_nativelistburst_insert_10 = new(name: "NativeList Burst Insert Time (10)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Insertion_10()
    {
        const I32 COUNT = 10;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);

        // Variable to store accumulated sum to prevent optimization.
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        //__data.Insert(index: 0, value: __index);
                        __data.InsertRange(index: 0, count: 1);
                        __data[0] =  __index;
                        __sum     += __data[0]; // Use the modified list to prevent optimization
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_insert_10)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_insert_100 = new(name: "NativeList Burst Insert Time (100)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Insertion_100()
    {
        const I32 COUNT = 100;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);

        // Variable to store accumulated sum to prevent optimization.
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        //__data.Insert(index: 0, value: __index);
                        __data.InsertRange(index: 0, count: 1);
                        __data[0] =  __index;
                        __sum     += __data[0]; // Use the modified list to prevent optimization
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_insert_100)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_insert_1000 = new(name: "NativeList Burst Insert Time (1000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Insertion_1000()
    {
        const I32 COUNT = 1000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);

        // Variable to store accumulated sum to prevent optimization.
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        //__data.Insert(index: 0, value: __index);
                        __data.InsertRange(index: 0, count: 1);
                        __data[0] =  __index;
                        __sum     += __data[0]; // Use the modified list to prevent optimization
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_insert_1000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_insert_10000 = new(name: "NativeList Burst Insert Time (10,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Insertion_10000()
    {
        const I32 COUNT = 10_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, Allocator.Temp);

        // Variable to store accumulated sum to prevent optimization.
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        //__data.Insert(index: 0, value: __index);
                        __data.InsertRange(index: 0, count: 1);
                        __data[0] = __index;
                        __sum += __data[0]; // Use the modified list to prevent optimization
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_insert_10000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }

    #endregion
    
    #region Deletion

    private static readonly SampleGroup benchmark_nativelistburst_deletion_10 = new(name: "NativeList Burst Deletion Time (10)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Deletion_10()
    {
        const I32 COUNT = 10;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, Allocator.Temp);

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    while (__data.Length > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
                    {
                        __sum += __data[0]; // Use the list before removing to prevent optimization
                        //__data.RemoveAtSwapBack(index: 0);
                        __data.RemoveAt(index: 0);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_deletion_10)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_deletion_100 = new(name: "NativeList Burst Deletion Time (100)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Deletion_100()
    {
        const I32 COUNT = 100;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, Allocator.Temp);

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    while (__data.Length > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
                    {
                        __sum += __data[0]; // Use the list before removing to prevent optimization
                        //__data.RemoveAtSwapBack(index: 0);
                        __data.RemoveAt(index: 0);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_deletion_100)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_deletion_1000 = new(name: "NativeList Burst Deletion Time (1000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Deletion_1000()
    {
        const I32 COUNT = 1000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, Allocator.Temp);

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    while (__data.Length > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
                    {
                        __sum += __data[0]; // Use the list before removing to prevent optimization
                        //__data.RemoveAtSwapBack(index: 0);
                        __data.RemoveAt(index: 0);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_deletion_1000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_deletion_10000 = new(name: "NativeList Burst Deletion Time (10,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Deletion_10000()
    {
        const I32 COUNT = 10_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, Allocator.Temp);

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    while (__data.Length > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
                    {
                        __sum += __data[0]; // Use the list before removing to prevent optimization
                        //__data.RemoveAtSwapBack(index: 0);
                        __data.RemoveAt(index: 0);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_deletion_10000)
               .SetUp(() => Setup(count: COUNT, ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }

    #endregion

    #region 

    

    #endregion
}