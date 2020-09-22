using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatihanFixedUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void FixedUpdate()
    {
        Debug.Log("Waktu untuk FixedUpdate :" + Time.deltaTime);
    }
     
    }
}
