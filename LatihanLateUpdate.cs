using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatihanLateUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void LateUpdate()
    {
        Debug.Log("Waktu untuk LateUpdate :" + Time.deltaTime);
    }
 
    }
}
