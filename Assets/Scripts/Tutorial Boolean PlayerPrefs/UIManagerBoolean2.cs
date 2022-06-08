using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManagerBoolean2 : MonoBehaviour
{
    /*
    // Necesitamos acceder al Texto TMPro
    public TextMeshProUGUI isMusicOnText;
    // Necesitamos acceder al Audio Source
    public AudioSource musicAudioSource;

    private void Start()
    {
        // Accedemos a la información guardada en PlayerPrefs y la transformamos de vuelta a booleano
        bool isMusicOn = IntToBool(PlayerPrefs.GetInt("MUSIC_ON"));
        
        // Queremos mostrar si la música está activa o no en la variable de tipo TextMeshProUGUI
        // Operador ternario:
        // * Si isMusicOn = true, message = "activada"
        // * Si isMusicOn = false, message = "desactivada"
        string message = isMusicOn ? "activada" : "desactivada";
        isMusicOnText.text = $"La música está {message}";
        
        // Queremos reproducir música si está activada o mutearla si está desactivada
        // * Si isMusicOn = true, queremos que mute = false
        // * Si isMusicOn = false, queremos que mute = true
        musicAudioSource.mute = !isMusicOn;
    }

    private bool IntToBool(int i)
    {
        // * Si i == 0 es true, devolvemos !true = false. En otras palabras, si i = 0, devolvemos false
        // * Si i == 0 es false, devolvemos !false = true. En otras palabras, si i = 1, devolvemos true
        return !(i == 0);
    }
    */
}
