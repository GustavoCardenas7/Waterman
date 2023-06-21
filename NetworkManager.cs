using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.Networking;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    public void CrearUsuario(string nombre, string correo, string contrasena, Action<Respuesta> respuesta)
    {
        StartCoroutine(CO_CrearUsuario(nombre, correo, contrasena, respuesta));
    }

    private IEnumerator CO_CrearUsuario(string nombre, string correo, string contrasena, Action<Respuesta> respuesta)
    {
        WWWForm form = new WWWForm();
        form.AddField("nombreDeUsuario", nombre);
        form.AddField("correo", correo);
        form.AddField("contrasena", contrasena);

        UnityWebRequest w = UnityWebRequest.Post("http://localhost/Gamificacion/crearUsuario.php", form);

        yield return w.SendWebRequest();

        respuesta(JsonUtility.FromJson<Respuesta>(w.downloadHandler.text));
    }

    public void CheckUsuario(string nombre, string contrasena, Action<Respuesta> respuesta)
    {
        StartCoroutine(CO_CheckUsuario(nombre, contrasena, respuesta));
    }

    private IEnumerator CO_CheckUsuario(string nombre, string contrasena, Action<Respuesta> respuesta)
    {
        WWWForm form = new WWWForm();
        form.AddField("nombreDeUsuario", nombre);
        form.AddField("contrasena", contrasena);

        UnityWebRequest w = UnityWebRequest.Post("http://localhost/Gamificacion/checkUsuario.php", form);

        yield return w.SendWebRequest();

        respuesta(JsonUtility.FromJson<Respuesta>(w.downloadHandler.text));
    }
}

[Serializable]
public class Respuesta
{
    public bool done = false;
    public string mensaje = "";
}
