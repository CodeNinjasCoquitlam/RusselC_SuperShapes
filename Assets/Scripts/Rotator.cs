﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //rotate the object om the x axis
        transform.Rotate(Vector3.forward, Time.deltaTime * 30f);

    }
}
