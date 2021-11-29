using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject vericacaoSair;
    public GameObject TelaGameOver;
    public bool estadoMenu = false;
    public bool IsGameOver = false;
    private string CenaAtual;
    void Start(){
        CenaAtual = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
    }
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) 
        {
            MenuPause();
        }
        Reiniciar();   
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
    public void GameOver(){
        if(!IsGameOver){
            TelaGameOver.SetActive(true);
            IsGameOver = true;
        }
    }
    public void Reiniciar(){
        if((Input.GetKeyDown(KeyCode.F))&&(IsGameOver))
        {
            TelaGameOver.SetActive(false);
            IsGameOver = false;
            UnityEngine.SceneManagement.SceneManager.LoadScene(CenaAtual);
        }
    }
}
