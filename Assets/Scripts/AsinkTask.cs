using System.Threading.Tasks;
using UnityEngine;

public class AsynkTask : MonoBehaviour
{
    void Start()
    {
        PrintAsync();
    }
    async void PrintAsync()
    {
        await Task.Delay(1000);
        Debug.Log($"Message was printed over 1 second.");

    }
}

