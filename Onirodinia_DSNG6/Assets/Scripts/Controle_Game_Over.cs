using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_Game_Over : MonoBehaviour
{
    public string CenaAtual;
    //Verifica se "F" foi pressionada e inicia fase 1
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(CenaAtual);
        }
    }
}
