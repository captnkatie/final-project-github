using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textscript : MonoBehaviour
{
    public float time = 3; //Seconds to read the text

    void Start()
    {
        Destroy(gameObject, time);
    }
}
