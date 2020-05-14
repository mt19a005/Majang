using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class HaiDictionary : MonoBehaviour
{
    public Dictionary<int, int> haiDic = new Dictionary<int, int>();
    public int haiTotal = 136;
    public void Start()
    {
        foreach (int i in Enumerable.Range(0, 38))
        {
            if (i % 10 != 0)
            {
                haiDic[i] = 4;
            }
            continue;
        }
        //C
        //foreach (var k in haiDic)
        //{
        //    Debug.Log(k.Key + ", " + k.Value);
        //}
    }



    public string TakeHai(int haiNum)
    {
        if(haiNum % 10 == 0 || haiDic[haiNum] == 0)
        {
            return "OneMore";
        }
        haiDic[haiNum]--;
        haiTotal--;
        return "Take";
    }
}