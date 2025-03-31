using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guia1ej2 : MonoBehaviour
{
    public string nombreUsuario;
    public int edad;
    public float estatura;
    public bool donanteOrgano;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario + ", tengo " + edad + " años " + ", mido " + estatura + " y " + donanteOrgano + " es donante de organos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
