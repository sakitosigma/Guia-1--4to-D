﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parImpar : MonoBehaviour
{
    public int num1;
    
    // Start is called before the first frame update
    void Start()
    {
        if(num1 > 0)
        {
            if(num1 % 2 == 0)
            {
                Debug.Log("El numero es par");
            } else
            {
                Debug.Log("El numero es impar");
            }
        } else
        {
            Debug.Log("el numero no es mayor a 0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
