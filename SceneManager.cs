using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    [Header("Login")]
    [SerializeField] public InputField m_loginNombreDeusuarioInput = null;
    [SerializeField] private InputField m_loginContrasenaInput = null;
    [SerializeField] private Text m_mensaje2 = null;

    [Header("Registrarse")]
    [SerializeField] private GameObject m_registroUI = null;
    [SerializeField] private GameObject m_loginUI = null;
    [SerializeField] private Text m_mensaje = null;
    [SerializeField] private InputField m_nombreDeUsuarioInput = null;
    [SerializeField] private InputField m_correoInput = null;
    [SerializeField] private InputField m_contrasenaInput = null;

    private NetworkManager m_networkManager = null;
    private SceneManager m_sceneManager = null;


    public void Awake()
    {
        m_networkManager = GameObject.FindObjectOfType<NetworkManager>();
        m_sceneManager = GameObject.FindObjectOfType<SceneManager>();
    }

    public void submitLogin()
    {
        if (m_loginNombreDeusuarioInput.text == "" || m_loginContrasenaInput.text == "")
        {
            m_mensaje2.text = "Faltan campos por llenar";
            StartCoroutine(ExampleCoroutine2());
            return;
        }

        m_mensaje2.text = "Procesando...";

        m_networkManager.CheckUsuario(m_loginNombreDeusuarioInput.text, m_loginContrasenaInput.text, delegate (Respuesta respuesta)
        {
            m_mensaje2.text = respuesta.mensaje;
            StartCoroutine(ExampleCoroutine2());

            if (m_mensaje2.text == "Bienvenido")
            {
                DontDestroyOnLoad(m_sceneManager);
                UnityEngine.SceneManagement.SceneManager.LoadScene("MenuPrincipal");
            }
        });

        
    }

    public void submitRegistro()
    {
        if(m_nombreDeUsuarioInput.text == "" || m_correoInput.text == "" || m_contrasenaInput.text == "")
        {
            m_mensaje.text = "Faltan campos por llenar";
            StartCoroutine(ExampleCoroutine());
            return;
        }

        m_mensaje.text = "Procesando...";

        m_networkManager.CrearUsuario(m_nombreDeUsuarioInput.text, m_correoInput.text, m_contrasenaInput.text, delegate(Respuesta respuesta)
        {
            m_mensaje.text = respuesta.mensaje;
            if(m_mensaje.text == "Usuario creado con exito")
            {
                m_nombreDeUsuarioInput.text = "";
                m_correoInput.text = "";
                m_contrasenaInput.text = "";
            }
            StartCoroutine(ExampleCoroutine());
        });
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(5);
        m_mensaje.text = "";
    }

    IEnumerator ExampleCoroutine2()
    {
        yield return new WaitForSeconds(5);
        m_mensaje2.text = "";
    }

    public void showLogin()
    {
        m_registroUI.SetActive(false);
        m_loginUI.SetActive(true);
    }

    public void ShowRegistro()
    {
        m_registroUI.SetActive(true);
        m_loginUI.SetActive(false);
    }
}
