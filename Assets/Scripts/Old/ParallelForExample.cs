using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class ParallelForExample : MonoBehaviour
{
    // Start is called before the first frame update
    void OldStart()
    {
        Parallel.For(0, 1000, (i) =>
        {
            Debug.Log($"{Thread.CurrentThread.ManagedThreadId} : {i}");
        });
    }

    void Start()
    {
        Parallel.Invoke( () =>
        {
            Debug.Log(1);
        },
        () => 
        {
            Debug.Log(2);
        },
        () =>
        {
            Debug.Log(3);
        });
    }

    void ParallelTest()
    {

    }
    // Update is called once per frame
    void Update()
    {
        List<string> alpha = new List<string>();
        alpha.Add("A");
        alpha.Add("B");
        alpha.Add("C");
        alpha.Add("D");
        alpha.Add("E");
        alpha.Add("F");
        alpha.Add("G");
        alpha.Add("H");

        Parallel.ForEach(alpha, new ParallelOptions { MaxDegreeOfParallelism = 4 }, fruit =>
        {
            Debug.Log($"Alphabet: {fruit}, Thread Id= {Thread.CurrentThread.ManagedThreadId}");
        });
    }
}
