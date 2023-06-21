using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gotas : MonoBehaviour
{
    public Score score;
    public int puntos;
    public Score2 score2;
    public int puntos2;

    public void Start() {
        score = GameObject.Find("Score").GetComponent<Score>();
        score2 = GameObject.Find("Score2").GetComponent<Score2>();
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Water-Man") {
            puntos = 1;
            score.AddScore(puntos);
            puntos2 = 1;
            score2.AddScore(puntos2);
            Destroy(gameObject);
        }  
    }
}
