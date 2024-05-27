using JetBrains.Annotations;

using NUnit.Framework;

using Unity.Collections;
using Unity.PerformanceTesting;

using I32 = System.Int32;
using I64 = System.Int64;

internal static partial class CollectionBenchmarks
{
    #region Indexing

    private static readonly SampleGroup benchmark_nativelist_indexing_10 = new(name: "NativeList Indexing Time (10)", unit: SampleUnit.Nanosecond); 
    [Test, Performance]
    public static void BenchmarkNativeList_Indexing_10()
    {
        const I32 COUNT = 10;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __sum += __data[index: __index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_indexing_10)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_indexing_100 = new(name: "NativeList Indexing Time (100)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Indexing_100()
    {
        const I32 COUNT = 100;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __sum += __data[index: __index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_indexing_100)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_indexing_1000 = new(name: "NativeList Indexing Time (1000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Indexing_1000()
    {
        const I32 COUNT = 1000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);
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
                        __sum += __data[index: __index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_indexing_1000)
               //.SetUp(() => Setup(count: COUNT, out __data))
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_indexing_10000 = new(name: "NativeList Indexing Time (10,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Indexing_10000()
    {
        const I32 COUNT = 10_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __sum += __data[index: __index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_indexing_10000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_indexing_100000 = new(name: "NativeList Indexing Time (100,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Indexing_100000()
    {
        const I32 COUNT = 100_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __sum += __data[index: __index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_indexing_100000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_indexing_1000000 = new(name: "NativeList Indexing Time (1,000,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Indexing_1000000()
    {
        const I32 COUNT = 1_000_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __sum += __data[index: __index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_indexing_1000000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
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

    private static readonly SampleGroup benchmark_nativelist_search_10 = new(name: "NativeList Search Time (10)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Search_10()
    {
        const I32 COUNT = 10;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_search_10)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_search_100 = new(name: "NativeList Search Time (100)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Search_100()
    {
        const I32 COUNT = 100;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_search_100)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_search_1000 = new(name: "NativeList Search Time (1000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Search_1000()
    {
        const I32 COUNT = 1000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_search_1000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_search_10000 = new(name: "NativeList Search Time (10,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Search_10000()
    {
        const I32 COUNT = 10_000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_search_10000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_search_100000 = new(name: "NativeList Search Time (100,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Search_100000()
    {
        const I32 COUNT = 100_000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_search_100000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_search_1000000 = new(name: "NativeList Search Time (1,000,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Search_1000000()
    {
        const I32 COUNT = 1_000_000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_search_1000000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }

    #endregion

    #region BinarySearch
    
    private static readonly SampleGroup benchmark_nativelist_binarysearch_10 = new(name: "NativeList BinarySearch Time (10)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_BinarySearch_10()
    {
        const I32 COUNT = 10;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_binarysearch_10)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    
    private static readonly SampleGroup benchmark_nativelist_binarysearch_100 = new(name: "NativeList BinarySearch Time (100)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_BinarySearch_100()
    {
        const I32 COUNT = 100;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_binarysearch_100)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_binarysearch_1000 = new(name: "NativeList BinarySearch Time (1000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_BinarySearch_1000()
    {
        const I32 COUNT = 1000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_binarysearch_1000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_binarysearch_10000 = new(name: "NativeList BinarySearch Time (10,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_BinarySearch_10000()
    {
        const I32 COUNT = 10_000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_binarysearch_10000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_binarysearch_100000 = new(name: "NativeList BinarySearch Time (100,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_BinarySearch_100000()
    {
        const I32 COUNT = 100_000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_binarysearch_100000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_binarysearch_1000000 = new(name: "NativeList BinarySearch Time (1,000,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_BinarySearch_1000000()
    {
        const I32 COUNT = 1_000_000;
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(value: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_binarysearch_1000000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }

    #endregion

    [UsedImplicitly]
    private static void Setup(I32 count, ref NativeList<I32> data)
    {
        data.Clear();
        data.SetCapacity(capacity: count);
        
        for (I32 __index = 0; __index < count; __index += 1)
        {
            data.Add(value: __index);
        }
    }
    // private static void Setup(int count, out NativeList<I32> data)
    // {
    //     data = new NativeList<I32>(initialCapacity: count, Allocator.Temp);
    //     for (I32 __index = 0; __index < count; __index += 1)
    //     {
    //         data.Add(__index);
    //     }
    // }
    
    #region Insertion

    private static readonly SampleGroup benchmark_nativelist_insertion_10 = new(name: "NativeList Insertion Time (10)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Insertion_10()
    {
        const I32 COUNT = 10;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);

        // Variable to store accumulated sum to prevent optimization.
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        //__data.Insert(index: 0, value: __index);
                        __data.InsertRange(index: 0, count: 1);
                        __data[index: 0] =  __index;
                        __sum            += __data[index: 0]; // Use the modified list to prevent optimization
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_insertion_10)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_insertion_100 = new(name: "NativeList Insertion Time (100)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Insertion_100()
    {
        const I32 COUNT = 100;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);

        // Variable to store accumulated sum to prevent optimization.
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        //__data.Insert(index: 0, value: __index);
                        __data.InsertRange(index: 0, count: 1);
                        __data[index: 0] =  __index;
                        __sum            += __data[index: 0]; // Use the modified list to prevent optimization
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_insertion_100)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_insertion_1000 = new(name: "NativeList Insertion Time (1000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Insertion_1000()
    {
        const I32 COUNT = 1000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);

        // Variable to store accumulated sum to prevent optimization.
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        //__data.Insert(index: 0, value: __index);
                        __data.InsertRange(index: 0, count: 1);
                        __data[index: 0] =  __index;
                        __sum            += __data[index: 0]; // Use the modified list to prevent optimization
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_insertion_1000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_insertion_10000 = new(name: "NativeList Insertion Time (10,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Insertion_10000()
    {
        const I32 COUNT = 10_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new (initialCapacity: COUNT, allocator: Allocator.Temp);

        // Variable to store accumulated sum to prevent optimization.
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        //__data.Insert(index: 0, value: __index);
                        __data.InsertRange(index: 0, count: 1);
                        __data[index: 0] =  __index;
                        __sum            += __data[index: 0]; // Use the modified list to prevent optimization
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_insertion_10000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
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

    private static readonly SampleGroup benchmark_nativelist_deletion_10 = new(name: "NativeList Deletion Time (10)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Deletion_10()
    {
        const I32 COUNT = 10;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    while (__data.Length > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
                    {
                        __sum += __data[index: 0]; // Use the list before removing to prevent optimization
                        //__data.RemoveAtSwapBack(index: 0);
                        __data.RemoveAt(index: 0);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_deletion_10)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_deletion_100 = new(name: "NativeList Deletion Time (100)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Deletion_100()
    {
        const I32 COUNT = 100;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    while (__data.Length > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
                    {
                        __sum += __data[index: 0]; // Use the list before removing to prevent optimization
                        //__data.RemoveAtSwapBack(index: 0);
                        __data.RemoveAt(index: 0);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_deletion_100)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_deletion_1000 = new(name: "NativeList Deletion Time (1000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Deletion_1000()
    {
        const I32 COUNT = 1000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    while (__data.Length > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
                    {
                        __sum += __data[index: 0]; // Use the list before removing to prevent optimization
                        //__data.RemoveAtSwapBack(index: 0);
                        __data.RemoveAt(index: 0);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_deletion_1000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelist_deletion_10000 = new(name: "NativeList Deletion Time (10,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeList_Deletion_10000()
    {
        const I32 COUNT = 10_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    while (__data.Length > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
                    {
                        __sum += __data[index: 0]; // Use the list before removing to prevent optimization
                        //__data.RemoveAtSwapBack(index: 0);
                        __data.RemoveAt(index: 0);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelist_deletion_10000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
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