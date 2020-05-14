using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    ConcurrentDictionary<int, int> tehai;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        tehai = new ConcurrentDictionary<int, int>();
        // CubeプレハブをGameObject型で取得
        obj = (GameObject) Resources.Load("Prefab/Cube");

    }

    //void takeHai()
    //{
    //    Instantiate(obj, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
    //    tehai.Add(obj.GetComponent<Hai>().haiID);
    //}

    ConcurrentDictionary<int, int> getTehai()
    {
        return tehai;
    }
}
