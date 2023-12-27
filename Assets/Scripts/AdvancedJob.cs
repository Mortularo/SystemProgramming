using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

public struct AdvancedJob : IJobParallelFor
{
    public NativeArray<Vector3> array;
    public void Execute(int index) { }
}
