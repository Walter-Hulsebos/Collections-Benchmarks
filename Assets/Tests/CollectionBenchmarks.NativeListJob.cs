using System.Diagnostics.CodeAnalysis;

using JetBrains.Annotations;

using NUnit.Framework;

using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.PerformanceTesting;

using I32 = System.Int32;
using I64 = System.Int64;

[SuppressMessage(category: "ReSharper", checkId: "AccessToDisposedClosure")]
internal static partial class CollectionBenchmarks
{
    
    #region Deletion
    
    [BurstCompile]
    private struct NativeListDeletionJob : IJob
    {
        public NativeList<I32>      data;
        public NativeReference<I64> sum;

        public void Execute()
        {
            I64 __localSum = 0;
            while (data.Length > 0)
            {
                __localSum += data[index: 0];
                data.RemoveAt(index: 0);
            }
            sum.Value = __localSum;
        }
    }

    private static readonly SampleGroup benchmark_nativelistburst_deletion_10 = new(name: "NativeList Burst Deletion Time (10)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Deletion_10()
    {
        const I32 COUNT = 10;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.TempJob);
        NativeReference<I64> __sumReference = new(allocator: Allocator.TempJob);
        
        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    NativeListDeletionJob __job = new()
                    {
                        data = __data,
                        sum  = __sumReference,
                    };

                    //Schedule and complete the job within one frame.
                    __job.Schedule().Complete();
                    __sum += __sumReference.Value;
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_deletion_10)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out
        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
        __sumReference.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_deletion_100 = new(name: "NativeList Burst Deletion Time (100)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Deletion_100()
    {
        const I32 COUNT = 100;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.TempJob);
        NativeReference<I64> __sumReference = new(allocator: Allocator.TempJob);
        
        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    NativeListDeletionJob __job = new()
                    {
                        data = __data,
                        sum  = __sumReference,
                    };

                    //Schedule and complete the job within one frame.
                    __job.Schedule().Complete();
                    __sum += __sumReference.Value;
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_deletion_100)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
        __sumReference.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_deletion_1000 = new(name: "NativeList Burst Deletion Time (1000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Deletion_1000()
    {
        const I32 COUNT = 1000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.TempJob);
        NativeReference<I64> __sumReference = new(allocator: Allocator.TempJob);
        
        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    NativeListDeletionJob __job = new()
                    {
                        data = __data,
                        sum  = __sumReference,
                    };

                    //Schedule and complete the job within one frame.
                    __job.Schedule().Complete();
                    __sum += __sumReference.Value;
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_deletion_1000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
        __sumReference.Dispose();
    }
    private static readonly SampleGroup benchmark_nativelistburst_deletion_10000 = new(name: "NativeList Burst Deletion Time (10,000)", unit: SampleUnit.Nanosecond);
    [Test, Performance]
    public static void BenchmarkNativeListBurst_Deletion_10000()
    {
        const I32 COUNT = 10_000;
        const I64 SUM = (I64)COUNT * (COUNT - 1) / 2 * (WARMUP_COUNT + MEASUREMENT_COUNT); // Sum of all values from 0 to COUNT - 1, multiplied by the total number of iterations
        //Prepare data
        NativeList<I32> __data = new(initialCapacity: COUNT, allocator: Allocator.TempJob);
        NativeReference<I64> __sumReference = new(allocator: Allocator.TempJob);
        
        // Variable to store accumulated sum to prevent optimization
        I64 __sum = 0;
        //Measure
        Measure.Method(action: () =>
                {
                    NativeListDeletionJob __job = new()
                    {
                        data = __data,
                        sum  = __sumReference,
                    };

                    //Schedule and complete the job within one frame.
                    __job.Schedule().Complete();
                    __sum += __sumReference.Value;
                })
               .WarmupCount(count: WARMUP_COUNT)
               .MeasurementCount(count: MEASUREMENT_COUNT)
               .SampleGroup(sampleGroup: benchmark_nativelistburst_deletion_10000)
               .SetUp(action: () => Setup(count: COUNT, data: ref __data))               
               .Run();

        // Use the result in some way to ensure the compiler doesn't optimize it out

        UnityEngine.Debug.Log(message:
                              $"expected: {SUM}\n " +
                              $"actual: {__sum}");
        Assert.AreEqual(expected: SUM, actual: __sum);
        __data.Dispose();
        __sumReference.Dispose();
    }

    #endregion
}