using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    //é necessário criar no unity um GameObject como um painel
    public GameObject PanelPause;
    private bool isPaused= false;

    void Start()
    {
        //não é necessário mudar nada nessa função
    }

    void Update()
    {
        if(!isPaused)
        {
            //aqui é necessário colocar todas as funções que não podem funcionar quando estiver pausado
            Move();
            Jump();
        }
        //pausa jogo
        if(Input.GetKeyDown(KeyCode.Escape)) 
        {
            PauseScreen();
        }
    }

    //essa é a função que irá ativa o painel no unity para pausar se já não estiver pausado
    void PauseScreen()
    {
        if(isPaused)
        {
            isPaused= false;
            PanelPause.SetActive(false);
        }
        else
        {
            isPaused= true;
            PanelPause.SetActive(true);
        }
    }
}