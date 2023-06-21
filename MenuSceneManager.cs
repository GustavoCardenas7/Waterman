using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuSceneManager : MonoBehaviour
{
    [SerializeField] private Text m_mensaje = null;
    private MenuNetworkManager m_networkManager = null;
    private SceneManager m_sceneManager = null;

    public void Awake()
    {
        m_networkManager = GameObject.FindObjectOfType<MenuNetworkManager>();
        m_sceneManager = GameObject.FindObjectOfType<SceneManager>();
    }

    public void Start()
    {
        m_networkManager.UsuarioMenu(m_sceneManager.m_loginNombreDeusuarioInput.text, delegate(Respuesta2 respuesta)
        {
            m_mensaje.text = respuesta.mensaje;
        });
    }

    public void jugar() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("seleccionNiveles");
    }
}
