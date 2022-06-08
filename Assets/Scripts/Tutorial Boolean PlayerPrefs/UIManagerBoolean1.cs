using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManagerBoolean1 : MonoBehaviour
{
    /*
    // Necesitamos acceder al Toggle
    public Toggle musicToggle;
    */
    
    /*
    private void Start()
    {
        if (PlayerPrefs.HasKey("MUSIC_ON"))
        {
            musicToggle.isOn = IntToBool(PlayerPrefs.GetInt("MUSIC_ON"));
        }
    }
    */

    /*
    // Función que nos permitirá guardar el booleano que indica si la música está activada o no
    public void SaveMusicValue()
    {
        // Primero obtenemos el valor booleano del Toggle
        bool isMusicOn = musicToggle.isOn;

        // Luego, guardamos el valor booleano con PlayerPrefs
        PlayerPrefs.SetInt("MUSIC_ON", BoolToInt(isMusicOn));
    }

    private int BoolToInt(bool b)
    {
        // Operador ternario
        // * Si b = true, devolvemos 1
        // * Si b = false, devolvemos 0
        return b ? 1 : 0;
    }
    
    private bool IntToBool(int i)
    {
        // * Si i == 0 es true, devolvemos !true = false. En otras palabras, si i = 0, devolvemos false
        // * Si i == 0 es false, devolvemos !false = true. En otras palabras, si i = 1, devolvemos true
        return !(i == 0);
    }
    */
}
