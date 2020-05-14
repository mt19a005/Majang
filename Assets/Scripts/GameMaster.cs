using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    
    public HaiDictionary haiDictionary;
    // Start is called before the first frame update
    void Start()
    {
        haiDictionary = gameObject.AddComponent<HaiDictionary>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
