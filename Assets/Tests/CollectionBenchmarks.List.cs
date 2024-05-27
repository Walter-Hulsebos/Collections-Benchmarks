using System.Collections.Generic;

using JetBrains.Annotations;

using NUnit.Framework;

using Unity.PerformanceTesting;

using I32  = System.Int32;
using I64  = System.Int64;

internal static partial class CollectionBenchmarks
{
    #region Indexing
    
    private static readonly SampleGroup benchmark_list_indexing_10 = new(name: "List Indexing Time (10)", unit: SampleUnit.Nanosecond); 
    [Test, Performance]
    public static void BenchmarkList_Indexing_10()
    {
        const I32 COUNT = 10;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new (capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < __data.Count; __index += 1)
                    {
                        __sum += __data[index: __index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_indexing_10)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_list_indexing_100 = new(name: "List Indexing Time (100)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Indexing_100()
    {
        const I32 COUNT = 100;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new (capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < __data.Count; __index += 1)
                    {
                        __sum += __data[index: __index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_indexing_100)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_list_indexing_1000 = new(name: "List Indexing Time (1000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Indexing_1000()
    {
        const I32 COUNT = 1000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new (capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < __data.Count; __index += 1)
                    {
                        __sum += __data[index: __index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_indexing_1000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_list_indexing_10000 = new(name: "List Indexing Time (10,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Indexing_10000()
    {
        const I32 COUNT = 10_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new (capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < __data.Count; __index += 1)
                    {
                        __sum += __data[index: __index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_indexing_10000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_list_indexing_100000 = new(name: "List Indexing Time (100,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Indexing_100000()
    {
        const I32 COUNT = 100_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new (capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < __data.Count; __index += 1)
                    {
                        __sum += __data[index: __index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_indexing_100000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_list_indexing_1000000 = new(name: "List Indexing Time (1,000,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Indexing_1000000()
    {
        const I32 COUNT = 1_000_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new (capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < __data.Count; __index += 1)
                    {
                        __sum += __data[index: __index];
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_indexing_1000000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    
    #endregion

    #region Search
    
    private static readonly SampleGroup benchmark_list_search_10 = new(name: "List Search Time (10)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Search_10()
    {
        const I32 COUNT = 10;
        //const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_search_10)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_list_search_100 = new(name: "List Search Time (100)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Search_100()
    {
        const I32 COUNT = 100;
        //const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_search_100)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_list_search_1000 = new(name: "List Search Time (1000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Search_1000()
    {
        const I32 COUNT = 1000;
        //const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_search_1000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_list_search_10000 = new(name: "List Search Time (10,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Search_10000()
    {
        const I32 COUNT = 10_000;
        //const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_search_10000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_list_search_100000 = new(name: "List Search Time (100,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Search_100000()
    {
        const I32 COUNT = 100_000;
        //const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_search_100000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_list_search_1000000 = new(name: "List Search Time (1,000,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Search_1000000()
    {
        const I32 COUNT = 1_000_000;
        //const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.IndexOf(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_search_1000000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    
    #endregion

    #region BinarySearch
    
    private static readonly SampleGroup benchmark_list_binary_search_10 = new(name: "List Binary Search Time (10)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_BinarySearch_10()
    {
        const I32 COUNT = 10;
        //const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_binary_search_10)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_list_binary_search_100 = new(name: "List Binary Search Time (100)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_BinarySearch_100()
    {
        const I32 COUNT = 100;
        //const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_binary_search_100)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_list_binary_search_1000 = new(name: "List Binary Search Time (1000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_BinarySearch_1000()
    {
        const I32 COUNT = 1000;
        //const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_binary_search_1000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_list_binary_search_10000 = new(name: "List Binary Search Time (10,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_BinarySearch_10000()
    {
        const I32 COUNT = 10_000;
        //const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_binary_search_10000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_list_binary_search_100000 = new(name: "List Binary Search Time (100,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_BinarySearch_100000()
    {
        const I32 COUNT = 100_000;
        //const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_binary_search_100000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }
    private static readonly SampleGroup benchmark_list_binary_search_1000000 = new(name: "List Binary Search Time (1,000,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_BinarySearch_1000000()
    {
        const I32 COUNT = 1_000_000;
        //const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        I32       __foundIndex = -1;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __foundIndex = __data.BinarySearch(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_binary_search_1000000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreNotEqual(expected: -1, actual: __foundIndex);
    }

    #endregion

    [UsedImplicitly]
    private static void Setup(in I32 count, ref List<I32> data)
    {
        data = new List<I32>(capacity: count);
        
        for (I32 __index = 0; __index < count; __index += 1)
        {
            data.Add(item: __index);
        }
    }
    
    #region Insertion
    
    private static readonly SampleGroup benchmark_list_insert_10 = new(name: "List Insert Time (10)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Insertion_10()
    {
        const I32 COUNT = 10;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);

        // Variable to store accumulated sum to prevent optimization.
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __data.Insert(index: 0, item: __index);
                        __sum += __data[index: 0]; // Use the modified list to prevent optimization
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_insert_10)

               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_list_insert_100 = new(name: "List Insert Time (100)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Insertion_100()
    {
        const I32 COUNT = 100;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);

        // Variable to store accumulated sum to prevent optimization.
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __data.Insert(index: 0, item: __index);
                        __sum += __data[index: 0]; // Use the modified list to prevent optimization
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_insert_100)

               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_list_insert_1000 = new(name: "List Insert Time (1000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Insertion_1000()
    {
        const I32 COUNT = 1000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);

        // Variable to store accumulated sum to prevent optimization.
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __data.Insert(index: 0, item: __index);
                        __sum += __data[index: 0]; // Use the modified list to prevent optimization
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_insert_1000)

               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_list_insert_10000 = new(name: "List Insert Time (10,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Insertion_10000()
    {
        const I32 COUNT = 10_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);

        // Variable to store accumulated sum to prevent optimization.
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __data.Insert(index: 0, item: __index);
                        __sum += __data[index: 0]; // Use the modified list to prevent optimization
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_insert_10000)

               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();
        
        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    // private static readonly SampleGroup benchmark_list_insert_100000 = new(name: "List Insert Time (100,000)", SampleUnit.Nanosecond);
    // [Test, Performance]
    // public static void BenchmarkList_Insertion_100000()
    // {
    //     const I32 COUNT = 100_000;
    //     //Prepare data
    //     List<I32> __data = new(capacity: COUNT);
    //
    //     // Variable to store accumulated sum to prevent optimization.
    //     I64 __sum = 0;
    //     //Measure
    //     Measure.Method(action: () =>
    //             {
    //                 for (I32 __index = 0; __index < COUNT; __index += 1)
    //                 {
    //                     __data.Insert(index: 0, item: __index);
    //                     __sum += __data[0]; // Use the modified list to prevent optimization
    //                 }
    //             })
    //            .WarmupCount(count: WARMUP_COUNT)
    //            .MeasurementCount(count: MEASUREMENT_COUNT)
    //            .SampleGroup(sampleGroup: benchmark_list_insert_100000)
    //            .GC()
    //            .SetUp(() => Setup(count: COUNT, ref __data))
    //            .Run();
    //     
    //     // Use the result in some way to ensure the compiler doesn't optimize it out
    //     Assert.AreNotEqual(expected: 0, actual: __sum);
    // }
    // private static readonly SampleGroup benchmark_list_insert_1000000 = new(name: "List Insert Time (1,000,000)", SampleUnit.Nanosecond);
    // [Test, Performance]
    // public static void BenchmarkList_Insertion_1000000()
    // {
    //     const I32 COUNT = 1_000_000;
    //     //Prepare data
    //     List<I32> __data = new(capacity: COUNT);
    //
    //     // Variable to store accumulated sum to prevent optimization.
    //     I64 __sum = 0;
    //     //Measure
    //     Measure.Method(action: () =>
    //             {
    //                 for (I32 __index = 0; __index < COUNT; __index += 1)
    //                 {
    //                     __data.Insert(index: 0, item: __index);
    //                     __sum += __data[0]; // Use the modified list to prevent optimization
    //                 }
    //             })
    //            .WarmupCount(count: WARMUP_COUNT)
    //            .MeasurementCount(count: MEASUREMENT_COUNT)
    //            .SampleGroup(sampleGroup: benchmark_list_insert_1000000)
    //            .GC()
    //            .SetUp(() => Setup(count: COUNT, ref __data))
    //            .Run();
    //     
    //     // Use the result in some way to ensure the compiler doesn't optimize it out
    //     Assert.AreNotEqual(expected: 0, actual: __sum);
    // }
    
    #endregion
    
    #region Deletion
    
    private static readonly SampleGroup benchmark_list_deletion_10 = new(name: "List Deletion Time (10)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Deletion_10()
    {
        const I32 COUNT = 10;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    while (__data.Count > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
                    {
                        __sum += __data[index: 0]; // Use the list before removing to prevent optimization
                        __data.RemoveAt(index: 0);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_deletion_10)

               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_list_deletion_100 = new(name: "List Deletion Time (100)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Deletion_100()
    {
        const I32 COUNT = 100;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    while (__data.Count > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
                    {
                        __sum += __data[index: 0]; // Use the list before removing to prevent optimization
                        __data.RemoveAt(index: 0);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_deletion_100)

               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_list_deletion_1000 = new(name: "List Deletion Time (1000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Deletion_1000()
    {
        const I32 COUNT = 1000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    while (__data.Count > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
                    {
                        __sum += __data[index: 0]; // Use the list before removing to prevent optimization
                        __data.RemoveAt(index: 0);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_deletion_1000)

               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_list_deletion_10000 = new(name: "List Deletion Time (10,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkList_Deletion_10000()
    {
        const I32 COUNT = 10_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        List<I32> __data = new(capacity: COUNT);

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    while (__data.Count > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
                    {
                        __sum += __data[index: 0]; // Use the list before removing to prevent optimization
                        __data.RemoveAt(index: 0);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_list_deletion_10000)

               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    // private static readonly SampleGroup benchmark_list_deletion_100000 = new(name: "List Deletion Time (100,000)", SampleUnit.Nanosecond);
    // [Test, Performance]
    // public static void BenchmarkList_Deletion_100000()
    // {
    //     const I32 COUNT = 100_000;
    //     //Prepare data
    //     List<I32> __data = new(capacity: COUNT);
    //
    //     //Measure
    //     I64 __sum = 0;
    //     Measure.Method(action: () =>
    //             {
    //                 while (__data.Count > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
    //                 {
    //                     __sum += __data[0]; // Use the list before removing to prevent optimization
    //                     __data.RemoveAt(index: 0);
    //                 }
    //             })
    //            .WarmupCount(count: WARMUP_COUNT)
    //            .MeasurementCount(count: MEASUREMENT_COUNT)
    //            .SampleGroup(sampleGroup: benchmark_list_deletion_100000)
    //            .GC()
    //            .SetUp(() => Setup(count: COUNT, ref __data))
    //            .Run();
    //
    //     // Use the result in some way to ensure the compiler doesn't optimize it out
    //     Assert.AreNotEqual(expected: 0, actual: __sum);
    // }
    // private static readonly SampleGroup benchmark_list_deletion_1000000 = new(name: "List Deletion Time (1,000,000)", SampleUnit.Nanosecond);
    // [Test, Performance]
    // public static void BenchmarkList_Deletion_1000000()
    // {
    //     const I32 COUNT = 1_000_000;
    //     //Prepare data
    //     List<I32> __data = new(capacity: COUNT);
    //
    //     //Measure
    //     I64 __sum = 0;
    //     Measure.Method(action: () =>
    //             {
    //                 while (__data.Count > 0) //Using a while loop to eat up the whole list, easier than a reverse for loop.
    //                 {
    //                     __sum += __data[0]; // Use the list before removing to prevent optimization
    //                     __data.RemoveAt(index: 0);
    //                 }
    //             })
    //            .WarmupCount(count: WARMUP_COUNT)
    //            .MeasurementCount(count: MEASUREMENT_COUNT)
    //            .SampleGroup(sampleGroup: benchmark_list_deletion_1000000)
    //            .GC()
    //            .SetUp(() => Setup(count: COUNT, ref __data))
    //            .Run();
    //
    //     // Use the result in some way to ensure the compiler doesn't optimize it out
    //     Assert.AreNotEqual(expected: 0, actual: __sum);
    // }
    
    #endregion
}