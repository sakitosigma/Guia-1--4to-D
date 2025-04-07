using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio : MonoBehaviour
{
    public float pesos;
    public float cambioFinal;
    public string moneda;

    // Start is called before the first frame update
    void Start()
    {
        
        if (pesos < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }
        else if (moneda == "E" || moneda == "e")
        {
            cambioFinal = pesos / 1177f;
            Debug.Log(pesos + "Pesos son " + cambioFinal + "Euros");
        }
        else if (moneda == "D" || moneda == "d")
        {
            cambioFinal = pesos / 1310f;
            Debug.Log(pesos + "Pesos son " + cambioFinal + "Dolares");
        }
        else if (moneda == "R" || moneda == "r")
        {
            cambioFinal = pesos / 183;
            Debug.Log(pesos + "Pesos son " + cambioFinal + "Reales");
        } 
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
