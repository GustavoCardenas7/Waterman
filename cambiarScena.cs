using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarScena : MonoBehaviour
{
    public int scene;
    
    void Start() {
        scene = Random.Range(1, 8);
    }
    
    public void regresar() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuPrincipal");
    }

    public void continuar() {
        if(scene == 1) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("continuar1");
        }else if(scene == 2) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("continuar2");
        }else if(scene == 3) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("continuar3");
        }else if(scene == 4) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("continuar4");
        }else if(scene == 5) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("continuar5");
        }else if(scene == 6) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("continuar6");
        }else if(scene == 7) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("continuar7");
        }
    }

    public void nivel1() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel1");
    }
    public void nivel2() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel2");
    }
    public void nivel3() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel3");
    }
    public void nivel4() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel4");
    }
    public void nivel5() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel5");
    }
    public void nivel6() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel6");
    }
    public void nivel7() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel7");
    }
}
