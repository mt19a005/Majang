using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    ConcurrentDictionary<int, int> tehai = new ConcurrentDictionary<int, int>();
    // Start is called before the first frame update
    void Start()
    {
        tehai[1] = 3;
        tehai[2] = 3;
        tehai[3] = 3;
        tehai[6] = 3;
        tehai[8] = 2;
        var karitehai = new Dictionary<int, int>(tehai);

        karitehai[1]--;

        foreach (var a in tehai)
        {
            Debug.Log(a);
        }

    }

}
