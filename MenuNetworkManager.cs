using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.Networking;
using UnityEngine;

public class MenuNetworkManager : MonoBehaviour
{
    public void UsuarioMenu(string nombre, Action<Respuesta2> respuesta)
    {
        StartCoroutine(CO_UsuarioMenu(nombre, respuesta));
    }

    private IEnumerator CO_UsuarioMenu(string nombre, Action<Respuesta2> respuesta)
    {
        nombre = "GustavoC7";
        UnityWebRequest w = UnityWebRequest.Get("http://localhost/Gamificacion/menuPrincipal.php?nombreDeUsuario= " + nombre);

        yield return w.SendWebRequest();

        respuesta(JsonUtility.FromJson<Respuesta2>(w.downloadHandler.text));
    }

    
}

[Serializable]
public class Respuesta2
{
    public bool done = false;
    public string mensaje = "";
}
