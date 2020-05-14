using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    ConcurrentDictionary<int, int> tehai;
    int atama = 0;
    int syuntu = 0;
    int kotu = 0;

    int pair;
    int tmpPair = -999;

    private void Awake()
    {
        tehai = new ConcurrentDictionary<int, int>();
        foreach (int i in Enumerable.Range(0, 44))
        {
            tehai[i] = 0;
        }
    }
    private void Start()
    {
        //tehai[1] = 1;
        //tehai[2] = 2;
        //tehai[3] = 2;
        //tehai[4] = 1;
        //tehai[5] = 2;
        //tehai[6] = 2;
        //tehai[7] = 2;
        //tehai[8] = 0;
        //tehai[9] = 1;

        tehai[1] = 1;
        tehai[2] = 0;
        tehai[3] = 2;
        tehai[4] = 0;
        tehai[5] = 0;
        tehai[6] = 1;
        tehai[7] = 1;
        tehai[8] = 0;
        tehai[9] = 0;

        tehai[11] = 1;
        tehai[12] = 0;
        tehai[13] = 0;
        tehai[14] = 0;
        tehai[15] = 1;
        tehai[16] = 0;
        tehai[17] = 0;
        tehai[18] = 1;
        tehai[19] = 1;

        tehai[21] = 0;
        tehai[22] = 0;
        tehai[23] = 1;
        tehai[24] = 0;
        tehai[25] = 0;
        tehai[26] = 0;
        tehai[27] = 0;
        tehai[28] = 0;
        tehai[29] = 0;

        tehai[31] = 1;
        tehai[33] = 0;
        tehai[35] = 0;
        tehai[37] = 0;

        tehai[39] = 1;
        tehai[41] = 1;
        tehai[43] = 1;



        // キーで昇順
        //IOrderedEnumerable<KeyValuePair<int, int>> sortedTehai =
        //    tehai.OrderBy(selector =>
        //    {
        //        return selector.Key;
        //    });

        //foreach (var a in tehai)
        //{
        //    Debug.Log(a);
        //}
        hante();
    }


    void hante()
    {
        var tempTehai = new ConcurrentDictionary<int, int>(tehai);
        //単騎以外（順子→刻子）
        foreach (var a in tehai)
        {
            tehai = new ConcurrentDictionary<int, int>(tempTehai);
            atama = 0;
            syuntu = 0;
            kotu = 0;
            //頭
            if (a.Value >= 2)
            {
                Debug.Log("atama = " + a.Key);
                atama++;
                tehai[a.Key] -= 2;

                Syuntu();
                Kotu();
                Syanten();
                Debug.Log("Pair = " + pair);
                if (pair == 5)
                {
                    Debug.Log("<color=#ff0000ff>上がり！</color>");
                }
                else if (pair == 4)
                {
                    Debug.Log("<color=#ff0000ff>テンパイです！</color>");
                }
                else
                {
                    Debug.Log("<color=#ff0000ff>" + (4 - pair) + " 向聴です！</color>");
                }
            }
        }

        //単騎以外（刻子→順子）
        foreach (var a in tehai)
        {
            tehai = new ConcurrentDictionary<int, int>(tempTehai);
            atama = 0;
            syuntu = 0;
            kotu = 0;
            //頭
            if (a.Value >= 2)
            {
                Debug.Log("atama = " + a.Key);
                atama++;
                tehai[a.Key] -= 2;

                Kotu();
                Syuntu();
                Syanten();
                Debug.Log("Pair = " + pair);
                if (pair == 5)
                {
                    Debug.Log("<color=#ff0000ff>上がり！</color>");
                }
                else if (pair == 4)
                {
                    Debug.Log("<color=#ff0000ff>テンパイです！</color>");
                }
                else
                {
                    Debug.Log("<color=#ff0000ff>" + (4 - pair) + " 向聴です！</color>");
                }
            }
        }
        //単騎（順子→刻子）
        Debug.Log("単騎");
        tehai = new ConcurrentDictionary<int, int>(tempTehai);
        atama = 0;
        syuntu = 0;
        kotu = 0;
        Syuntu();
        Kotu();
        Syanten();
        Debug.Log("Pair = " + pair);
        if (pair == 5)
        {
            Debug.Log("<color=#ff0000ff>上がり！</color>");
        }
        else if (pair == 4)
        {
            Debug.Log("<color=#ff0000ff>テンパイです！</color>");
        }
        else
        {
            Debug.Log("<color=#ff0000ff>" + (4 - pair) + " 向聴です！</color>");
        }

        //単騎（刻子→順子）
        tehai = new ConcurrentDictionary<int, int>(tempTehai);
        atama = 0;
        syuntu = 0;
        kotu = 0;
        Kotu();
        Syuntu();
        Syanten();
        Debug.Log("Pair = " + pair);
        if (pair == 5)
        {
            Debug.Log("<color=#ff0000ff>上がり！</color>");
        }
        else if (pair == 4)
        {
            Debug.Log("<color=#ff0000ff>テンパイです！</color>");
        }
        else
        {
            Debug.Log("<color=#ff0000ff>" + (4 - pair) + " 向聴です！</color>");
        }

        if (tmpPair == 5)
        {
            Debug.Log("上がり！");
        }
        else if (tmpPair == 4)
        {
            Debug.Log("テンパイです！");
        }
        else
        {
            Debug.Log((4 - tmpPair) + " 向聴です！");
        }



    }
    void Syuntu()
    {
        //順子
        foreach (var b in tehai)
        {
            //C
            //Debug.Log("<color=#0000ffff>順子検索対象 = " + b.Key + "</color>");
            if(b.Key <= 30) {
                foreach (var c in Enumerable.Range(0, b.Value))
                {
                    if (tehai[b.Key] >= 1 && tehai[b.Key + 1] >= 1 && tehai[b.Key + 2] >= 1)
                    {
                        Debug.Log(b.Key + ", " + (b.Key + 1) + ", " + (b.Key + 2) + " は順子");
                        syuntu++;
                        tehai[b.Key]--;
                        tehai[b.Key + 1]--;
                        tehai[b.Key + 2]--;
                    }
                }
            }
        }
    }

    void Kotu()
    {
        //刻子
        foreach (var b in tehai)
        {
            //C
            //Debug.Log("<color=#0000ffff>刻子検索対象 = " + b.Key + "</color>");
            if (tehai[b.Key] >= 3)
            {
                Debug.Log(b.Key + " は刻子");
                kotu++;
                tehai[b.Key] -= 3;
            }
        }
    }
    void Syanten()
    {

        pair = atama + syuntu + kotu;
        if (tmpPair < pair)
        {
            tmpPair = pair;
        }
    }
}
