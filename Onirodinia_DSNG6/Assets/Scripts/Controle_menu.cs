using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject vericacaoSair;
    //public Controle_Game_Over cgo;
    public bool estadoMenu = false;
    void Start(){
        //cgo = FindObjectOfType<Controle_Game_Over>();
    }
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) 
        {
            MenuPause();
        }
        /*if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name != "Game_Over"){
            cgo.CenaAtual = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        }*/     
    }
//Iniciar cena
    public void IniciarCena(string cena){ 
        UnityEngine.SceneManagement.SceneManager.LoadScene(cena);
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
