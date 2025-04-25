using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int vidas = 3;

    public bool estoyMuerto = false;

    public static GameManager Instance { get; private set; }
    
    void Awake(){
       if(Instance == null ){
            Instance = this;
       }
        
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
