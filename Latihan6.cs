using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan6 : MonoBehaviour
{
    int[] intarray;

    // Start is called before the first frame update
    void Start()
    {
        intarray[0] = 10;
        intarray[1] = 20;
        intarray[2] = 30;
        intarray[3] = 40;
        Debug.Log("Menampilkan Seluruh Array");
        foreach (int a in intarray)
        {
            Debug.Log(a);
        }
        Debug.Log("Nilai Index ke 2 adalah " + intarray[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
