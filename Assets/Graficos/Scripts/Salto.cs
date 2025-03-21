using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{

    public int miEdad = 23;

    public float miAltura = 5.0f;

    public string miNombre = "Violette";

    public bool tengoMelena = true; 

    public GameObject miCubo; 


    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("Hola. Mi nombre es "+miNombre+". Y tengo "+miEdad+" años.");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola. Mi nombre es "+miNombre+". Y tengo "+miEdad+" años.");    
    }
}
