using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tehai : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.parent = transform;
        Debug.Log("Enter"); // ログを表示する
        //collision.transform.parent = null;
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit"); // ログを表示する
        collision.transform.parent = null;
        Debug.Log(collision.transform.position); // ログを表示する
    }
}
