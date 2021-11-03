using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_menu : MonoBehaviour
{
    public GameObject menu;
    private bool estadoMenu;
//Iniciar cut scene da fase 1
    public void IniciarFase1(){ 
        UnityEngine.SceneManagement.SceneManager.LoadScene("CutScene1");
    }
//Fecha o jogo
    public void FecharJogo()
    {
        Application.Quit();
    } 
//Maxima e minimiza a barra de menu
    public void BarraMenu()
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
}
