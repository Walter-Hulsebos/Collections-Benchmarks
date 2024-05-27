using System.Runtime.CompilerServices;

using Unity.Collections;

using static System.Runtime.CompilerServices.MethodImplOptions;

using I32 = System.Int32;

public static class UnityCollectionsExtensions
{
    private const MethodImplOptions INLINE = AggressiveInlining;
    
    [MethodImpl(methodImplOptions: INLINE)]
    public static void Insert<T>(ref this NativeList<T> list, I32 index, T value)
        where T : unmanaged
    {
        list.InsertRange(index: index, count: 1);
        list[index: index] = value;
    }
}
