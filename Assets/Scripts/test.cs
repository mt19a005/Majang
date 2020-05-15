using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int ID;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "HAI")
        {
            ID = collider.gameObject.GetComponent<Hai>().haiID;
            Debug.Log(ID, collider.gameObject);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
    }
}
