using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentDataStringTutorial : MonoBehaviour
{
    /* // Singleton PARTE 1
    // Instancia compartida para que el script sea accesible por todos los scripts
    public static PersistentDataStringTutorial sharedInstance;
    */
    
    /* // Variables
    // Variables que queremos guardar
    public string username;
    */

    /* // Singleton PARTE 2
    private void Awake()
    {
        // Nos aseguramos de que la instancia sea única
        if (sharedInstance == null)
        {
            sharedInstance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    */
}
