using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalitos : MonoBehaviour
{
    public int dias;
    public string tipoAnimal;
    public int alimento;
    public float precio;
    
    // Start is called before the first frame update
    void Start()
    {
        if (tipoAnimal == "G" || tipoAnimal == "g")
        {
            alimento = dias * 300;
            Debug.Log("Para ese período se necesitan " + alimento + " gramos de alimento");
            precio = (alimento / 100) * 80;
            Debug.Log("Para ese período se necesitan " + precio + " pesos");
        }
        else if (tipoAnimal == "PP")
        {
            alimento = dias * 400;
            Debug.Log("Para ese período se necesitan " + alimento + " gramos de alimento");
            precio = (alimento / 100) * 80;
            Debug.Log("Para ese período se necesitan " + precio + " pesos");
        } 
        else if (tipoAnimal == "PG")
        {
            alimento = dias * 700;
            Debug.Log("Para ese período se necesitan " + alimento + " gramos de alimento");
            precio = (alimento / 100) * 80;
            Debug.Log("Para ese período se necesitan " + precio + " pesos");
        } else
        {
            Debug.Log("pusiste un valor erroneo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
