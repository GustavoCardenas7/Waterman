using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class HighScoreControl : MonoBehaviour
{
    
    public string addScoreURL =
            "http://localhost/Gamificacion/addscore.php";
    public string highscoreURLScore =
             "http://localhost/Gamificacion/displayScore.php?";
    public string highscoreURLTime =
             "http://localhost/Gamificacion/displayTime.php?";

    public Text posicionResult;
    public Text nameResultText;
    public Text timeResultText;
    public Text scoreResultText;
    public Text levelResultText;

    public Text posicionResult2;
    public Text nameResultText2;
    public Text timeResultText2;
    public Text scoreResultText2;
    public Text levelResultText2;

    public Text posicionResult3;
    public Text nameResultText3;
    public Text timeResultText3;
    public Text scoreResultText3;
    public Text levelResultText3;

    public Text posicionResult4;
    public Text nameResultText4;
    public Text timeResultText4;
    public Text scoreResultText4;
    public Text levelResultText4;

    public Text posicionResult5;
    public Text nameResultText5;
    public Text timeResultText5;
    public Text scoreResultText5;
    public Text levelResultText5;

    public Text posicionResult6;
    public Text nameResultText6;
    public Text timeResultText6;
    public Text scoreResultText6;
    public Text levelResultText6;

    public Text posicionResult7;
    public Text nameResultText7;
    public Text timeResultText7;
    public Text scoreResultText7;
    public Text levelResultText7;

    public InputField m_nombreDeUsuarioInput = null;
    public InputField m_tiempoInput = null;
    public InputField m_scoreInput = null;
    public InputField m_levelInput = null;
    public GameObject m_menu = null;
    public GameObject m_tabla1 = null;
    public GameObject m_tabla2 = null;
    public GameObject m_tabla3 = null;
    public GameObject m_tabla4 = null;
    public GameObject m_tabla5 = null;
    public GameObject m_tabla6 = null;
    public GameObject m_tabla7 = null;

    public void GetScoreByScoreBtn1()
    {
        posicionResult.text = "Posición\n \n";
        nameResultText.text = "Nombre\n \n";
        timeResultText.text = "Tiempo\n \n";
        scoreResultText.text = "Puntuación\n \n";
        levelResultText.text = "Nivel\n \n";

        StartCoroutine(GetScoresByScore(1));
    }

    public void GetScoreByTimeBtn1()
    {
        posicionResult.text = "Posición\n \n";
        nameResultText.text = "Nombre\n \n";
        timeResultText.text = "Tiempo\n \n";
        scoreResultText.text = "Puntuación\n \n";
        levelResultText.text = "Nivel\n \n";

        StartCoroutine(GetScoresByTime(1));
    }

    public void GetScoreByScoreBtn2()
    {
        posicionResult2.text = "Posición\n \n";
        nameResultText2.text = "Nombre\n \n";
        timeResultText2.text = "Tiempo\n \n";
        scoreResultText2.text = "Puntuación\n \n";
        levelResultText2.text = "Nivel\n \n";

        StartCoroutine(GetScoresByScore2(2));
    }

    public void GetScoreByTimeBtn2()
    {
        posicionResult2.text = "Posición\n \n";
        nameResultText2.text = "Nombre\n \n";
        timeResultText2.text = "Tiempo\n \n";
        scoreResultText2.text = "Puntuación\n \n";
        levelResultText2.text = "Nivel\n \n";

        StartCoroutine(GetScoresByTime2(2));
    }

    public void GetScoreByScoreBtn3()
    {
        posicionResult3.text = "Posición\n \n";
        nameResultText3.text = "Nombre\n \n";
        timeResultText3.text = "Tiempo\n \n";
        scoreResultText3.text = "Puntuación\n \n";
        levelResultText3.text = "Nivel\n \n";

        StartCoroutine(GetScoresByScore3(3));
    }

    public void GetScoreByTimeBtn3()
    {
        posicionResult3.text = "Posición\n \n";
        nameResultText3.text = "Nombre\n \n";
        timeResultText3.text = "Tiempo\n \n";
        scoreResultText3.text = "Puntuación\n \n";
        levelResultText3.text = "Nivel\n \n";

        StartCoroutine(GetScoresByTime3(3));
    }

    public void GetScoreByScoreBtn4()
    {
        posicionResult4.text = "Posición\n \n";
        nameResultText4.text = "Nombre\n \n";
        timeResultText4.text = "Tiempo\n \n";
        scoreResultText4.text = "Puntuación\n \n";
        levelResultText4.text = "Nivel\n \n";

        StartCoroutine(GetScoresByScore4(4));
    }

    public void GetScoreByTimeBtn4()
    {
        posicionResult4.text = "Posición\n \n";
        nameResultText4.text = "Nombre\n \n";
        timeResultText4.text = "Tiempo\n \n";
        scoreResultText4.text = "Puntuación\n \n";
        levelResultText4.text = "Nivel\n \n";

        StartCoroutine(GetScoresByTime4(4));
    }

    public void GetScoreByScoreBtn5()
    {
        posicionResult5.text = "Posición\n \n";
        nameResultText5.text = "Nombre\n \n";
        timeResultText5.text = "Tiempo\n \n";
        scoreResultText5.text = "Puntuación\n \n";
        levelResultText5.text = "Nivel\n \n";

        StartCoroutine(GetScoresByScore5(5));
    }

    public void GetScoreByTimeBtn5()
    {
        posicionResult5.text = "Posición\n \n";
        nameResultText5.text = "Nombre\n \n";
        timeResultText5.text = "Tiempo\n \n";
        scoreResultText5.text = "Puntuación\n \n";
        levelResultText5.text = "Nivel\n \n";

        StartCoroutine(GetScoresByTime5(5));
    }

    public void GetScoreByScoreBtn6()
    {
        posicionResult6.text = "Posición\n \n";
        nameResultText6.text = "Nombre\n \n";
        timeResultText6.text = "Tiempo\n \n";
        scoreResultText6.text = "Puntuación\n \n";
        levelResultText6.text = "Nivel\n \n";

        StartCoroutine(GetScoresByScore6(6));
    }

    public void GetScoreByTimeBtn6()
    {
        posicionResult6.text = "Posición\n \n";
        nameResultText6.text = "Nombre\n \n";
        timeResultText6.text = "Tiempo\n \n";
        scoreResultText6.text = "Puntuación\n \n";
        levelResultText6.text = "Nivel\n \n";

        StartCoroutine(GetScoresByTime6(6));
    }

    public void GetScoreByScoreBtn7()
    {
        posicionResult7.text = "Posición\n \n";
        nameResultText7.text = "Nombre\n \n";
        timeResultText7.text = "Tiempo\n \n";
        scoreResultText7.text = "Puntuación\n \n";
        levelResultText7.text = "Nivel\n \n";

        StartCoroutine(GetScoresByScore7(7));
    }

    public void GetScoreByTimeBtn7()
    {
        posicionResult7.text = "Posición\n \n";
        nameResultText7.text = "Nombre\n \n";
        timeResultText7.text = "Tiempo\n \n";
        scoreResultText7.text = "Puntuación\n \n";
        levelResultText7.text = "Nivel\n \n";

        StartCoroutine(GetScoresByTime7(7));
    }

    public void SendScoreBtn()
    {
        StartCoroutine(PostScores(m_nombreDeUsuarioInput.text, m_tiempoInput.text, m_scoreInput.text, m_levelInput.text));
        m_nombreDeUsuarioInput.text = "";
        m_tiempoInput.text = "";
        m_scoreInput.text = "";
        m_levelInput.text = "";
    }

    IEnumerator GetScoresByScore(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLScore+"numero="+numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText.text += splitData[i];
                        posicionResult.text += pos + 1;
                        posicionResult.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText.text += splitData[i];
                    else if(i % 4 == 2)
                        scoreResultText.text += splitData[i];
                    else if(i % 4 == 3)
                         levelResultText.text += splitData[i];
                }
            }
        }
    }

    IEnumerator GetScoresByTime(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLTime+"numero="+numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText.text += splitData[i];
                        posicionResult.text += pos + 1;
                        posicionResult.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText.text += splitData[i];
                    else if (i % 4 == 2)
                        scoreResultText.text += splitData[i];
                    else if (i % 4 == 3)
                        levelResultText.text += splitData[i];
                }
            }
        }
    }

    IEnumerator GetScoresByScore2(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLScore + "numero=" + numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText2.text += splitData[i];
                        posicionResult2.text += pos + 1;
                        posicionResult2.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText2.text += splitData[i];
                    else if (i % 4 == 2)
                        scoreResultText2.text += splitData[i];
                    else if (i % 4 == 3)
                        levelResultText2.text += splitData[i];
                }
            }
        }
    }

    IEnumerator GetScoresByTime2(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLTime + "numero=" + numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText2.text += splitData[i];
                        posicionResult2.text += pos + 1;
                        posicionResult2.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText2.text += splitData[i];
                    else if (i % 4 == 2)
                        scoreResultText2.text += splitData[i];
                    else if (i % 4 == 3)
                        levelResultText2.text += splitData[i];
                }
            }
        }
    }

    IEnumerator GetScoresByScore3(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLScore + "numero=" + numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText3.text += splitData[i];
                        posicionResult3.text += pos + 1;
                        posicionResult3.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText3.text += splitData[i];
                    else if (i % 4 == 2)
                        scoreResultText3.text += splitData[i];
                    else if (i % 4 == 3)
                        levelResultText3.text += splitData[i];
                }
            }
        }
    }

    IEnumerator GetScoresByTime3(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLTime + "numero=" + numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText3.text += splitData[i];
                        posicionResult3.text += pos + 1;
                        posicionResult3.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText3.text += splitData[i];
                    else if (i % 4 == 2)
                        scoreResultText3.text += splitData[i];
                    else if (i % 4 == 3)
                        levelResultText3.text += splitData[i];
                }
            }
        }
    }

    IEnumerator GetScoresByScore4(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLScore + "numero=" + numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText4.text += splitData[i];
                        posicionResult4.text += pos + 1;
                        posicionResult4.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText4.text += splitData[i];
                    else if (i % 4 == 2)
                        scoreResultText4.text += splitData[i];
                    else if (i % 4 == 3)
                        levelResultText4.text += splitData[i];
                }
            }
        }
    }

    IEnumerator GetScoresByTime4(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLTime + "numero=" + numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText4.text += splitData[i];
                        posicionResult4.text += pos + 1;
                        posicionResult4.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText4.text += splitData[i];
                    else if (i % 4 == 2)
                        scoreResultText4.text += splitData[i];
                    else if (i % 4 == 3)
                        levelResultText4.text += splitData[i];
                }
            }
        }
    }

    IEnumerator GetScoresByScore5(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLScore + "numero=" + numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText5.text += splitData[i];
                        posicionResult5.text += pos + 1;
                        posicionResult5.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText5.text += splitData[i];
                    else if (i % 4 == 2)
                        scoreResultText5.text += splitData[i];
                    else if (i % 4 == 3)
                        levelResultText5.text += splitData[i];
                }
            }
        }
    }

    IEnumerator GetScoresByTime5(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLTime + "numero=" + numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText5.text += splitData[i];
                        posicionResult5.text += pos + 1;
                        posicionResult5.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText5.text += splitData[i];
                    else if (i % 4 == 2)
                        scoreResultText5.text += splitData[i];
                    else if (i % 4 == 3)
                        levelResultText5.text += splitData[i];
                }
            }
        }
    }

    IEnumerator GetScoresByScore6(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLScore + "numero=" + numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText6.text += splitData[i];
                        posicionResult6.text += pos + 1;
                        posicionResult6.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText6.text += splitData[i];
                    else if (i % 4 == 2)
                        scoreResultText6.text += splitData[i];
                    else if (i % 4 == 3)
                        levelResultText6.text += splitData[i];
                }
            }
        }
    }

    IEnumerator GetScoresByTime6(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLTime + "numero=" + numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText6.text += splitData[i];
                        posicionResult6.text += pos + 1;
                        posicionResult6.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText6.text += splitData[i];
                    else if (i % 4 == 2)
                        scoreResultText6.text += splitData[i];
                    else if (i % 4 == 3)
                        levelResultText6.text += splitData[i];
                }
            }
        }
    }

    IEnumerator GetScoresByScore7(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLScore + "numero=" + numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText7.text += splitData[i];
                        posicionResult7.text += pos + 1;
                        posicionResult7.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText7.text += splitData[i];
                    else if (i % 4 == 2)
                        scoreResultText7.text += splitData[i];
                    else if (i % 4 == 3)
                        levelResultText7.text += splitData[i];
                }
            }
        }
    }

    IEnumerator GetScoresByTime7(int numero)
    {
        UnityWebRequest hs_get = UnityWebRequest.Get(highscoreURLTime + "numero=" + numero);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
            Debug.Log("There was an error getting the high score: " + hs_get.error);
        else
        {
            int pos = 0;
            string dataText = hs_get.downloadHandler.text;
            MatchCollection mc = Regex.Matches(dataText, @"_");
            if (mc.Count > 0)
            {
                string[] splitData = Regex.Split(dataText, @"_");
                for (int i = 0; i < mc.Count; i++)
                {
                    if (i % 4 == 0)
                    {
                        nameResultText7.text += splitData[i];
                        posicionResult7.text += pos + 1;
                        posicionResult7.text += "\n";
                        pos++;
                    }
                    else if (i % 4 == 1)
                        timeResultText7.text += splitData[i];
                    else if (i % 4 == 2)
                        scoreResultText7.text += splitData[i];
                    else if (i % 4 == 3)
                        levelResultText7.text += splitData[i];
                }
            }
        }
    }

    private IEnumerator PostScores(string nombre, string tiempo, string score, string nivel)
    {
        WWWForm form = new WWWForm();
        form.AddField("nombreDeUsuario", nombre);
        form.AddField("tiempoTotal", tiempo);
        form.AddField("puntuacionTotal", score);
        form.AddField("nivel", nivel);

        UnityWebRequest w = UnityWebRequest.Post(addScoreURL, form);

        yield return w.SendWebRequest();
    }

    public void showMenu()
    {
        m_tabla1.SetActive(false);
        m_tabla2.SetActive(false);
        m_tabla3.SetActive(false);
        m_tabla4.SetActive(false);
        m_tabla5.SetActive(false);
        m_tabla6.SetActive(false);
        m_tabla7.SetActive(false);
        m_menu.SetActive(true);
    }

    public void ShowTabla1()
    {
        m_tabla1.SetActive(true);
        m_tabla2.SetActive(false);
        m_tabla3.SetActive(false);
        m_tabla4.SetActive(false);
        m_tabla5.SetActive(false);
        m_tabla6.SetActive(false);
        m_tabla7.SetActive(false);
        m_menu.SetActive(false);
    }

    public void ShowTabla2()
    {
        m_tabla1.SetActive(false);
        m_tabla2.SetActive(true);
        m_tabla3.SetActive(false);
        m_tabla4.SetActive(false);
        m_tabla5.SetActive(false);
        m_tabla6.SetActive(false);
        m_tabla7.SetActive(false);
        m_menu.SetActive(false);
    }

    public void ShowTabla3()
    {
        m_tabla1.SetActive(false);
        m_tabla2.SetActive(false);
        m_tabla3.SetActive(true);
        m_tabla4.SetActive(false);
        m_tabla5.SetActive(false);
        m_tabla6.SetActive(false);
        m_tabla7.SetActive(false);
        m_menu.SetActive(false);
    }

    public void ShowTabla4()
    {
        m_tabla1.SetActive(false);
        m_tabla2.SetActive(false);
        m_tabla3.SetActive(false);
        m_tabla4.SetActive(true);
        m_tabla5.SetActive(false);
        m_tabla6.SetActive(false);
        m_tabla7.SetActive(false);
        m_menu.SetActive(false);
    }

    public void ShowTabla5()
    {
        m_tabla1.SetActive(false);
        m_tabla2.SetActive(false);
        m_tabla3.SetActive(false);
        m_tabla4.SetActive(false);
        m_tabla5.SetActive(true);
        m_tabla6.SetActive(false);
        m_tabla7.SetActive(false);
        m_menu.SetActive(false);
    }

    public void ShowTabla6()
    {
        m_tabla1.SetActive(false);
        m_tabla2.SetActive(false);
        m_tabla3.SetActive(false);
        m_tabla4.SetActive(false);
        m_tabla5.SetActive(false);
        m_tabla6.SetActive(true);
        m_tabla7.SetActive(false);
        m_menu.SetActive(false);
    }

    public void ShowTabla7()
    {
        m_tabla1.SetActive(false);
        m_tabla2.SetActive(false);
        m_tabla3.SetActive(false);
        m_tabla4.SetActive(false);
        m_tabla5.SetActive(false);
        m_tabla6.SetActive(false);
        m_tabla7.SetActive(true);
        m_menu.SetActive(false);
    }
}
