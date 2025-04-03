using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estacionamiento : MonoBehaviour
{
    public int hora;
    public bool estaAbierto;
    
    // Start is called before the first frame update
    void Start()
    {
        if(hora < 0 || hora > 24)
        {
            Debug.Log("te equivocaste de hora");
            return;s
        } else if(hora >= 10 && hora < 18)
        {
            estaAbierto = true;
            Debug.Log("el estacionamiento esta abierto: " + estaAbierto);
        } else
        {
            estaAbierto = false;
            Debug.Log("el estacionamiento esta abierto: " + estaAbierto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
