using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Random=UnityEngine.Random;

public class WaterManMovement : MonoBehaviour
{
    public float speed = 0.4f;
    Vector2 dest = Vector2.zero;
    public Score score;
    public int puntos;
    public int puntosDesafio;

    public Score2 score2;
    public int puntos2;
    public int puntosDesafio2;

    public int vidas;
    public int vidas2 = 3;
    public bool desafio1;
    public bool desafio2;
    public int scene;
    public GameObject nivel = null;
    public GameObject victoria = null;
    public GameObject reloj = null;
    public GameObject gotas = null;
    public GameObject iconoDesafio = null;
    
    public int puntos3;

    private int banderaDesafio;
    public int nivelBandera;

    void Start()
    {
        dest = transform.position;
        score = GameObject.Find("Score").GetComponent<Score>();
        score2 = GameObject.Find("Score2").GetComponent<Score2>();
        desafio1 = false;
        desafio2 = false;
        scene = Random.Range(1, 8);
        reloj.SetActive(false);
        gotas.SetActive(false);
        iconoDesafio.SetActive(false);
        puntos3 = 0;
        nivelBandera = 1;
    }

    void FixedUpdate()
    {
        // Move closer to Destination
        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(p);

        // Check for Input if not moving
        if ((Vector2)transform.position == dest)
        {
            if (Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up))
            {
                dest = (Vector2)transform.position + Vector2.up;
                Vector2 dir = dest - (Vector2)transform.position;
                GetComponent<Animator>().SetFloat("DirY", dir.y);
            }
                
            if (Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right))
            {
                dest = (Vector2)transform.position + Vector2.right;
                Vector2 dir = dest - (Vector2)transform.position;
                GetComponent<Animator>().SetFloat("DirX", dir.x);
            }
                
            if (Input.GetKey(KeyCode.DownArrow) && valid(-Vector2.up))
            {
                dest = (Vector2)transform.position - Vector2.up;
                Vector2 dir = dest - (Vector2)transform.position;
                GetComponent<Animator>().SetFloat("DirY", dir.y);
            }
                
            if (Input.GetKey(KeyCode.LeftArrow) && valid(-Vector2.right))
            {
                dest = (Vector2)transform.position - Vector2.right;
                Vector2 dir = dest - (Vector2)transform.position;
                GetComponent<Animator>().SetFloat("DirX", dir.x);
            }  
        } 

        if(vidas2 == 0) {
            if(scene == 1) {
                UnityEngine.SceneManagement.SceneManager.LoadScene("gameOver1");
            }else if(scene == 2) {
                UnityEngine.SceneManagement.SceneManager.LoadScene("gameOver2");
            }else if(scene == 3) {
                UnityEngine.SceneManagement.SceneManager.LoadScene("gameOver3");
            }else if(scene == 4) {
                UnityEngine.SceneManagement.SceneManager.LoadScene("gameOver4");
            }else if(scene == 5) {
                UnityEngine.SceneManagement.SceneManager.LoadScene("gameOver5");
            }else if(scene == 6) {
                UnityEngine.SceneManagement.SceneManager.LoadScene("gameOver6");
            }else if(scene == 7) {
                UnityEngine.SceneManagement.SceneManager.LoadScene("gameOver7");
            }
        }
    }

    bool valid(Vector2 dir)
    {
        // Cast Line from 'next to Pac-Man' to 'Pac-Man'
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>());
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "RespuestaC") {
            if(vidas2 == 3 && nivelBandera == 1) {
                desafio1 = true;
                desafio2 = false;
            }else if(puntos3 == 56 && nivelBandera == 2) {
                desafio2 = true;
                desafio1 = false;
            }

            if(desafio1 == true && nivelBandera == 1) {
                puntosDesafio = 20;
                puntos = 10 + puntosDesafio;
                score.AddScore(puntos);
                Debug.Log("Respuesta Correcta");
                score.stopTime();

                puntosDesafio2 = 20;
                puntos2 = 10 + puntosDesafio2;
                score2.AddScore(puntos2);
                Debug.Log("Respuesta Correcta");
                score2.stopTime();
                Debug.Log(banderaDesafio);
                banderaDesafio = 1;
                score2.DesafioCompletado(banderaDesafio);
                //Debug.Log(puntos);
                showVictoria();
            } else if(desafio2 == true && nivelBandera == 2) {
                puntosDesafio = 40;
                puntos = 10 + puntosDesafio;
                score.AddScore(puntos);
                Debug.Log("Respuesta Correcta");
                score.stopTime();

                puntosDesafio2 = 20;
                puntos2 = 10 + puntosDesafio2;
                score2.AddScore(puntos2);
                Debug.Log("Respuesta Correcta");
                score2.stopTime();
                Debug.Log(banderaDesafio);
                banderaDesafio = 1;
                score2.DesafioCompletado(banderaDesafio);
                //Debug.Log(puntos);
                showVictoria();
            } 
            else {
                puntos = 10;
                score.AddScore(puntos);
                Debug.Log("Respuesta Correcta");
                score.stopTime();

                puntos2 = 10;
                score2.AddScore(puntos2);
                Debug.Log("Respuesta Correcta");
                score2.stopTime();
                banderaDesafio = 0;
                score2.DesafioCompletado(banderaDesafio);
                //Debug.Log(puntos);
                showVictoria();
            }
            
        }
        else if (col.gameObject.tag == "RespuestaI") {
            vidas2--;
            vidas = -1;
            score.Vidas(vidas);
            Debug.Log("Respuesta Incorrecta");
        }
        else if (col.gameObject.tag == "Botella") {
            vidas2--;
            vidas = -1;
            score.Vidas(vidas);
        }

        else if (col.gameObject.tag == "Gota") {
            puntos3++;
        }
    }

    public void showVictoria()
    {
        nivel.SetActive(false);
        victoria.SetActive(true);
        reloj.SetActive(true);
        gotas.SetActive(true);
        iconoDesafio.SetActive(true);
    }
}
