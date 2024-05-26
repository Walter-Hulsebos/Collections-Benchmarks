using NUnit.Framework;

using Unity.PerformanceTesting;
using Unity.Collections;

using I32 = System.Int32;
using I64 = System.Int64;

internal static partial class CollectionBenchmarks
{
    #region Indexing
    
    private static readonly SampleGroup benchmark_nativearray_indexing_10 = new(name: "NativeArray Indexing Time (10)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_Indexing_10()
    {
        const I32 COUNT = 10; 
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[index: __index] = __index;
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
               .SampleGroup(sampleGroup: benchmark_nativearray_indexing_10)
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativearray_indexing_100 = new(name: "NativeArray Indexing Time (100)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_Indexing_100()
    {
        const I32 COUNT = 100; 
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[index: __index] = __index;
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
               .SampleGroup(sampleGroup: benchmark_nativearray_indexing_100)
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativearray_indexing_1000 = new(name: "NativeArray Indexing Time (1000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_Indexing_1000()
    {
        const I32 COUNT = 1000; 
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[index: __index] = __index;
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
               .SampleGroup(sampleGroup: benchmark_nativearray_indexing_1000)
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativearray_indexing_10000 = new(name: "NativeArray Indexing Time (10,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_Indexing_10000()
    {
        const I32 COUNT = 10_000; 
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[index: __index] = __index;
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
               .SampleGroup(sampleGroup: benchmark_nativearray_indexing_10000)
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativearray_indexing_100000 = new(name: "NativeArray Indexing Time (100,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_Indexing_100000()
    {
        const I32 COUNT = 100_000; 
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[index: __index] = __index;
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
               .SampleGroup(sampleGroup: benchmark_nativearray_indexing_100000)
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativearray_indexing_1000000 = new(name: "NativeArray Indexing Time (1,000,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_Indexing_1000000()
    {
        const I32 COUNT = 1_000_000; 
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[index: __index] = __index;
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
               .SampleGroup(sampleGroup: benchmark_nativearray_indexing_1000000)
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
    }
    
    // Similarly, convert the other indexing tests to use NativeArray

    #endregion

    #region Search
    
    private static readonly SampleGroup benchmark_nativearray_search_10 = new(name: "NativeArray Search Time (10)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_Search_10()
    {
        const I32 COUNT = 10;
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[index: __index] = __index;
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE  = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativearray_search_10)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativearray_search_100 = new(name: "NativeArray Search Time (100)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_Search_100()
    {
        const I32 COUNT = 100;
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[index: __index] = __index;
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE  = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativearray_search_100)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativearray_search_1000 = new(name: "NativeArray Search Time (1000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_Search_1000()
    {
        const I32 COUNT = 1000;
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[index: __index] = __index;
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE  = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativearray_search_1000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativearray_search_10000 = new(name: "NativeArray Search Time (10,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_Search_10000()
    {
        const I32 COUNT = 10_000;
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[index: __index] = __index;
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE  = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativearray_search_10000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativearray_search_100000 = new(name: "NativeArray Search Time (100,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_Search_100000()
    {
        const I32 COUNT = 100_000;
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[index: __index] = __index;
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE  = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativearray_search_100000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    private static readonly SampleGroup benchmark_nativearray_search_1000000 = new(name: "NativeArray Search Time (1,000,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_Search_1000000()
    {
        const I32 COUNT = 1_000_000;
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[index: __index] = __index;
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE  = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativearray_search_1000000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
        __data.Dispose();
    }
    
    // Similarly, convert the other search tests to use NativeArray

    #endregion
    
    #region BinarySearch
    
    private static readonly SampleGroup benchmark_nativearray_binary_search_10 = new(name: "Array Binary Search Time (10)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_BinarySearch_10()
    {
        const I32 COUNT = 10;
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[__index] = __index;
        }
        ////Array.Sort(array: __data);

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE  = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativearray_binary_search_10)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_nativearray_binary_search_100 = new(name: "Array Binary Search Time (100)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_BinarySearch_100()
    {
        const I32 COUNT = 100;
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[__index] = __index;
        }
        //Array.Sort(array: __data);

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE  = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(value: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativearray_binary_search_100)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_nativearray_binary_search_1000 = new(name: "Array Binary Search Time (1000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_BinarySearch_1000()
    {
        const I32 COUNT = 1000;
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[__index] = __index;
        }
        //Array.Sort(array: __data);

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
               .SampleGroup(sampleGroup: benchmark_nativearray_binary_search_1000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_nativearray_binary_search_10000 = new(name: "Array Binary Search Time (10,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_BinarySearch_10000()
    {
        const I32 COUNT = 10_000;
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[__index] = __index;
        }
        ////Array.Sort(array: __data);

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
               .SampleGroup(sampleGroup: benchmark_nativearray_binary_search_10000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_nativearray_binary_search_100000 = new(name: "Array Binary Search Time (100,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_BinarySearch_100000()
    {
        const I32 COUNT = 100_000;
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[__index] = __index;
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
               .SampleGroup(sampleGroup: benchmark_nativearray_binary_search_100000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_nativearray_binary_search_1000000 = new(name: "Array Binary Search Time (1,000,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeArray_BinarySearch_1000000()
    {
        const I32 COUNT = 1_000_000;
        //Prepare data
        NativeArray<I32> __data = new(length: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data[__index] = __index;
        }
        //Array.Sort(array: __data);

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
               .SampleGroup(sampleGroup: benchmark_nativearray_binary_search_1000000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }

    #endregion
}