using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd : MonoBehaviour
{
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = (GameObject)Resources.Load("Prefab/Cube");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Instantiate(obj, gameObject.transform.position, Quaternion.identity);
        }
    }
}
