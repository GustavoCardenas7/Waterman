using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreText = null;
    public Text vidasText = null;
    public Text tiempoText = null;
    private int score = 0;
    private int vidas = 3;
    Stopwatch cronometro = new Stopwatch();
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "00";
        vidasText.text = "0";
        tiempoText.text = "00:00";
        cronometro.Start();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.text = "x " + score;
        vidasText.text = "x " + vidas;
        TimeSpan ts = cronometro.Elapsed;
        string tiempoTranscurrido = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
                    
        tiempoText.text = tiempoTranscurrido;
    }

    public void AddScore(int nuevoValor) {
        score += nuevoValor;
    }

    public void Vidas(int nuevoValor) {
        vidas += nuevoValor;
    }

    public void stopTime() {
        cronometro.Stop();
    }
}
