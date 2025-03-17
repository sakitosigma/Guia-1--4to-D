using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int edadusuario;
    float sueldoUsuario;
    string domicilio;
    bool aprobo;

    // Start is called before the first frame update
    void Start()
    {
        edadusuario = 16;
        sueldoUsuario = 200.000F;
        aprobo = true;
        domicilio = "Libertador 1369";

        Debug.Log(edadusuario);
        Debug.Log(sueldoUsuario);
        Debug.Log(domicilio);
        Debug.Log(aprobo);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
