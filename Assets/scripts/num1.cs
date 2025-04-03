using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class num1 : MonoBehaviour
{
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        num2 += 2;
        Debug.Log(num2);
        Debug.Log(num2 * num2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
