using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject vericacaoSair;
    public bool estadoMenu = false;
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) 
        {
            MenuPause();
        }        
    }
//Iniciar cut scene da fase 1
    public void IniciarFase1(){ 
        UnityEngine.SceneManagement.SceneManager.LoadScene("CutScene1");
    }
    //Iniciar tela menu inicia
    public void IniciarMenuInicial(){ 
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
//Fecha o jogo
    public void FecharJogo()
    {
        Application.Quit();
    } 
//Maxima e minimiza a barra de menu
    public void MenuPause()
    {
        if(!estadoMenu){
            menu.SetActive(true);
            estadoMenu = true;
        }
        else{
            menu.SetActive(false);
            estadoMenu = false;
        }
    }
//Verifica se o usuario quer ou não fechar o jogo
    public void VerificacaoSair(bool estado){
        if (estado){
            vericacaoSair.SetActive(true);
        }
        else{
            vericacaoSair.SetActive(false);
        }
    }
}
