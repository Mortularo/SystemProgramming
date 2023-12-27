using System.Collections;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
public class OtherObject : MonoBehaviour
{
    private NativeArray<Vector3> array;
    private JobHandle handle;
    void Start()
    {
        this.array = new NativeArray<Vector3>(100, Allocator.TempJob);
        AdvancedJob job = new AdvancedJob();
        job.array = this.array;
        this.handle = job.Schedule(100, 5);
        this.handle.Complete();
        StartCoroutine(JobCoroutine());
    }
    IEnumerator JobCoroutine()
    {
        while (this.handle.IsCompleted == false)
        {
            yield return new WaitForEndOfFrame();
        }
        foreach (Vector3 vector in this.array)
        {
            print(vector);
        }
        this.array.Dispose();
    }
}


