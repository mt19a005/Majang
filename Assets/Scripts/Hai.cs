using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hai : MonoBehaviour
{
    GameObject gameMasterOBJ;
    GameMaster gameMaster;
    HaiDictionary haiDictionary;

    public int haiID;
    string readTexturePass = "Texture/Materials/";
    // Start is called before the first frame update
    void Awake()
    {
        gameMasterOBJ = GameObject.FindGameObjectWithTag("GameMaster");
        gameMaster = gameMasterOBJ.GetComponent<GameMaster>();
        haiDictionary = gameMaster.haiDictionary;

    }
    void Start()
    {
        while (true)
        {
            haiID = GenerateRandom();
            
            if (haiDictionary.TakeHai(haiID) == "Take")
            {
                //C
                Debug.Log(haiID, gameObject);
                break;
            }
        }
        readTexturePass = readTexturePass + haiID.ToString();
        //C
        //Debug.Log(readTexturePass);
        gameObject.GetComponent<Renderer>().material = (Material)Resources.Load(readTexturePass);
    }

    public int GenerateRandom()
    {
        int random = new System.Random(Convert.ToInt32(Guid.NewGuid().ToString("N").Substring(0, 8), 16)).Next(1, 38);
        return random;
    }
}
