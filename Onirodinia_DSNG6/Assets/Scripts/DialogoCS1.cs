using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoCS1 : MonoBehaviour
{
    public Sprite personagem;
    public string[] txtFala;
    public string txtNomePersonagem;
    private ControleDialogo cd;
    // Start is called before the first frame update
    void Start()
    {
        cd = FindObjectOfType<ControleDialogo>();
        new WaitForSeconds(1); //delay
        DialogoCutScene1();
    }
    //Dialogos referentes a cut scene 1
    private void DialogoCutScene1(){
        txtFala[0] = "O que tá acontecendo aqui?... Como tudo ficou assim? Agora pouco tava tudo certo. Será que isso é tipo aquelas histórias de sete além?";
        txtFala[1] = "Preciso achar ajuda, deve ter alguém por perto!";
        txtNomePersonagem = "Helena";
        cd.Fala(personagem, txtFala, txtNomePersonagem);
    }
}
