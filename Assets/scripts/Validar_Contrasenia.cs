using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Validar_Contrasenia : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    public Text textoMensaje;
    public GameObject cartelitoMensaje;

    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
        cartelitoMensaje.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContrasenia()
    {
        contraseniaUsuario = ingresoUsuario.text;
        if(contraseniaUsuario == contraseniaCorrecta)
        {
            cartelitoMensaje.SetActive(true);
            textoMensaje.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMensaje.SetActive(true);
            textoMensaje.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
