using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{
    public int edadusuario;
    public Text miTexto;
    // Start is called before the first frame update
    void Start()
    {
        if (edadusuario >= 18)
        {
            miTexto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        }
        else
        {
            miTexto.text = "No es mayor de edad";
            Debug.Log("No es mayor de edad");
        }
    }
    

    
}
