using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score2 : MonoBehaviour
{
    public Text scoreText = null;
    public Text tiempoText = null;
    public Text desafioText = null;
    private int score = 0;
    Stopwatch cronometro = new Stopwatch();
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "00";
        tiempoText.text = "00:00";
        desafioText.text = "";
        cronometro.Start();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.text = "x " + score;
        TimeSpan ts = cronometro.Elapsed;
        string tiempoTranscurrido = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
                    
        tiempoText.text = tiempoTranscurrido;
    }

    public void AddScore(int nuevoValor) {
        score += nuevoValor;
    }

    public void stopTime() {
        cronometro.Stop();
    }

    public void DesafioCompletado(int numero) {
        if(numero == 1) {
            desafioText.text = "Completado";
        } else if(numero == 0) {
            desafioText.text = "No completado";
        }
    }
}
