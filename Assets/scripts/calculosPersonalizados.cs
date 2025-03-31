using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculosPersonalizados : MonoBehaviour
{
    public float num1;
    public float num2;
    public float ResultadoSuma;
    public float ResultadoResta;
    public float ResultadoMultiplicacion;
    public float ResultadoDivision;
    // Start is called before the first frame update
    void Start()
    {
        ResultadoSuma = num1 + num2;
        ResultadoResta = num1 - num2;
        ResultadoMultiplicacion = num1 * num2;
        ResultadoDivision = num1 / num2;
        Debug.Log("La suma entre " + num1 + " y " + num2 + " es " + ResultadoSuma);
        Debug.Log("La resta entre " + num1 + " y " + num2 + " es " + ResultadoResta);
        Debug.Log("La multiplicacion entre " + num1 + " y " + num2 + " es " + ResultadoMultiplicacion);
        Debug.Log("La divicion entre " + num1 + " y " + num2 + " es " + ResultadoDivision);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
