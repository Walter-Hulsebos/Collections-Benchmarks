using System;
using System.Collections.Generic;

using JetBrains.Annotations;

using NUnit.Framework;

using Unity.Collections;
using Unity.PerformanceTesting;

using UnityEngine;

using I32 = System.Int32;
using I64 = System.Int64;

using B08 = System.Boolean;

internal static partial class CollectionBenchmarks
{
    #region Insertion

    private static readonly SampleGroup benchmark_nativehashset_insertion_10 = new(name: "NativeHashSet Insertion Time (10)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Insertion_10()
    {
        const I32 COUNT = 10;
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);

        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __data.Add(item: __index);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_insertion_10)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreEqual(expected: COUNT, actual: __data.Count);
    }
    private static readonly SampleGroup benchmark_nativehashset_insertion_100 = new(name: "NativeHashSet Insertion Time (100)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Insertion_100()
    {
        const I32 COUNT = 100;
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);

        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __data.Add(item: __index);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_insertion_100)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreEqual(expected: COUNT, actual: __data.Count);
    }
    private static readonly SampleGroup benchmark_nativehashset_insertion_1000 = new(name: "NativeHashSet Insertion Time (1000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Insertion_1000()
    {
        const I32 COUNT = 1000;
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);

        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __data.Add(item: __index);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_insertion_1000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreEqual(expected: COUNT, actual: __data.Count);
    }
    private static readonly SampleGroup benchmark_nativehashset_insertion_10000 = new(name: "NativeHashSet Insertion Time (10,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Insertion_10000()
    {
        const I32 COUNT = 10_000;
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);

        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __data.Add(item: __index);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_insertion_10000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreEqual(expected: COUNT, actual: __data.Count);
    }
    private static readonly SampleGroup benchmark_nativehashset_insertion_100000 = new(name: "NativeHashSet Insertion Time (100,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Insertion_100000()
    {
        const I32 COUNT = 100_000;
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);

        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __data.Add(item: __index);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_insertion_100000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreEqual(expected: COUNT, actual: __data.Count);
    }
    private static readonly SampleGroup benchmark_nativehashset_insertion_1000000 = new(name: "NativeHashSet Insertion Time (1,000,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Insertion_1000000()
    {
        const I32 COUNT = 1_000_000;
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);

        //Measure
        Measure.Method(action: () =>
                {
                    for (I32 __index = 0; __index < COUNT; __index += 1)
                    {
                        __data.Add(item: __index);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_insertion_1000000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.AreEqual(expected: COUNT, actual: __data.Count);
    }
    
    #endregion

    #region Search

    private static readonly SampleGroup benchmark_nativehashset_search_10 = new(name: "NativeHashSet Search Time (10)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Search_10()
    {
        const I32 COUNT = 10;
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        B08       __found      = false;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __found = __data.Contains(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_search_10)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.IsTrue(condition: __found);
    }
    private static readonly SampleGroup benchmark_nativehashset_search_100 = new(name: "NativeHashSet Search Time (100)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Search_100()
    {
        const I32 COUNT = 100;
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        B08       __found      = false;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __found = __data.Contains(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_search_100)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.IsTrue(condition: __found);
    }
    private static readonly SampleGroup benchmark_nativehashset_search_1000 = new(name: "NativeHashSet Search Time (1000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Search_1000()
    {
        const I32 COUNT = 1000;
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        B08       __found      = false;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __found = __data.Contains(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_search_1000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.IsTrue(condition: __found);
    }
    private static readonly SampleGroup benchmark_nativehashset_search_10000 = new(name: "NativeHashSet Search Time (10,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Search_10000()
    {
        const I32 COUNT = 10_000;
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        B08       __found      = false;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __found = __data.Contains(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_search_10000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.IsTrue(condition: __found);
    }
    private static readonly SampleGroup benchmark_nativehashset_search_100000 = new(name: "NativeHashSet Search Time (100,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Search_100000()
    {
        const I32 COUNT = 100_000;
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        B08       __found      = false;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __found = __data.Contains(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_search_100000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.IsTrue(condition: __found);
    }
    private static readonly SampleGroup benchmark_nativehashset_search_1000000 = new(name: "NativeHashSet Search Time (1,000,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Search_1000000()
    {
        const I32 COUNT = 1_000_000;
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        // Variable to store the result to prevent optimization
        B08       __found      = false;
        const I32 SEARCH_VALUE = COUNT - 1; // Value to search for

        // Measure
        Measure.Method(action: () =>
                {
                    __found = __data.Contains(item: SEARCH_VALUE);
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_search_1000000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        Assert.IsTrue(condition: __found);
    }
    
    #endregion

    #region Deletion

    private static readonly SampleGroup benchmark_nativehashset_deletion_10 = new(name: "NativeHashSet Deletion Time (10)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Deletion_10()
    {
        const I32 COUNT = 10;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    for (I32 __index = COUNT - 1; __index >= 0 ; __index--)
                    {
                        __sum += __index; // Use the values before removing to prevent optimization
                        __data.Remove(item: __index);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_deletion_10)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_nativehashset_deletion_100 = new(name: "NativeHashSet Deletion Time (100)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Deletion_100()
    {
        const I32 COUNT = 100;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    for (I32 __index = COUNT - 1; __index >= 0 ; __index--)
                    {
                        __sum += __index; // Use the values before removing to prevent optimization
                        __data.Remove(item: __index);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_deletion_100)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_nativehashset_deletion_1000 = new(name: "NativeHashSet Deletion Time (1000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Deletion_1000()
    {
        const I32 COUNT = 1000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    for (I32 __index = COUNT - 1; __index >= 0 ; __index--)
                    {
                        __sum += __index; // Use the values before removing to prevent optimization
                        __data.Remove(item: __index);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_deletion_1000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_nativehashset_deletion_10000 = new(name: "NativeHashSet Deletion Time (10,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Deletion_10000()
    {
        const I32 COUNT = 10_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    for (I32 __index = COUNT - 1; __index >= 0 ; __index--)
                    {
                        __sum += __index; // Use the values before removing to prevent optimization
                        __data.Remove(item: __index);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_deletion_10000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_nativehashset_deletion_100000 = new(name: "NativeHashSet Deletion Time (100,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Deletion_100000()
    {
        const I32 COUNT = 100_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    for (I32 __index = COUNT - 1; __index >= 0 ; __index--)
                    {
                        __sum += __index; // Use the values before removing to prevent optimization
                        __data.Remove(item: __index);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_deletion_100000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }
    private static readonly SampleGroup benchmark_nativehashset_deletion_1000000 = new(name: "NativeHashSet Deletion Time (1,000,000)", SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeHashSet_Deletion_1000000()
    {
        const I32 COUNT = 1_000_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeHashSet<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.Temp);
        for (I32 __index = 0; __index < COUNT; __index += 1)
        {
            __data.Add(item: __index);
        }

        //Measure
        I64 __sum = 0;
        Measure.Method(action: () =>
                {
                    for (I32 __index = COUNT - 1; __index >= 0 ; __index--)
                    {
                        __sum += __index; // Use the values before removing to prevent optimization
                        __data.Remove(item: __index);
                    }
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativehashset_deletion_1000000)
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
    }

    #endregion
}