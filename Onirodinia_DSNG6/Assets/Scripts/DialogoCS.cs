using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DialogoCS : MonoBehaviour
{
    public Sprite Helena;
    public Sprite Atormentado;
    public Sprite Fundo1, Fundo2, Fundo3, Fundo4, Fundo5;
    private string[] txtFala = {"","",""};
    private string txtNomePersonagem;
    private DialogoControle cd;
    public float numeroCutScene;
    public float falasRestantes=0;
    // Start is called before the first frame update
    void Start()
    {
        cd = FindObjectOfType<DialogoControle>();
        new WaitForSeconds(1); //delay
        IniciarDialogo();
    }
    public void IniciarDialogo(){
        if(numeroCutScene == 1){
            StartCoroutine(DialogoCutScene1());
        }
        else if(numeroCutScene == 2){
            if(falasRestantes == 0){
                falasRestantes = 9;
            }
            StartCoroutine(DialogoCutScene2());
        }
    }
    //Dialogos referentes a cut scene 1
    IEnumerator DialogoCutScene1(){
        cd.MudarFundo(Fundo1);
        yield return new WaitForSeconds(5);
        cd.MudarFundo(Fundo2);
        yield return new WaitForSeconds(5);
        cd.MudarFundo(Fundo3);

        if(falasRestantes == 0){
            txtFala[0] = "O que tá acontecendo aqui?... Como tudo ficou assim? Agora pouco tava tudo certo. Será que isso é tipo aquelas histórias de sete além?";
            txtFala[1] = "Preciso achar ajuda, deve ter alguém por perto!";
            txtFala[2] = "";
            txtNomePersonagem = "Helena";

            cd.Fala(Helena, txtFala, txtNomePersonagem);
        }
    }

    IEnumerator DialogoCutScene2(){
        cd.MudarFundo(Fundo4);
        yield return new WaitForSeconds(1);

        if(falasRestantes == 9){
            txtFala[0] = "Bem agora que fui derrotado finalmente posso descansar, mas você... Se eu fosse você, teria mais cuidado para prosseguir!";
            txtFala[1] = "Nunca a vi tão obcecada por algo. E agora que estou fora de cena ... Os outros serão mais impiedosos!";
            txtFala[2] = "";
            txtNomePersonagem = "Atormentado";
            cd.Fala(Atormentado, txtFala, txtNomePersonagem);
        }
        else if(falasRestantes == 8){
            txtFala[0] = "Outros, do que você tá falando? O que tá acontecendo nessa cidade?";
            txtFala[1] = "";
            txtFala[2] = "";
            txtNomePersonagem = "Helena";
            cd.Fala(Helena, txtFala, txtNomePersonagem);
        }
        else if(falasRestantes == 7){
            txtFala[0] = "Você ainda não percebeu? Não acredito que uma garotinha idiota dessas tenha me vencido...";
            txtFala[1] = "Bem-vinda a Onirodinia! Essa é a cidade da imperatriz! Conquistada por ela e que nós, seus generais, mantemos em ordem sob o comando dela.";
            txtFala[2] = " Ela chegou a pouco tempo, trazendo o que os outros disseram ser caos, mas eu chamo de ordem!";
            txtNomePersonagem = "Atormentado";
            cd.Fala(Atormentado, txtFala, txtNomePersonagem);
        }
        else if(falasRestantes == 6){
            txtFala[0] = "Em ordem? Isso não parece estar em ordem! E se ela causou toda essa destruição, é ... É tirania!";
            txtFala[1] = "";
            txtFala[2] = "";
            txtNomePersonagem = "Helena";
            cd.Fala(Helena, txtFala, txtNomePersonagem);
        }
        else if(falasRestantes == 5){
            txtFala[0] = "Hahaha, e o que você esperava? Flores, debates e compreensão? Ninguém aprende assim!";
            txtFala[1] = "Desse jeito continuaríamos destruindo o mundo e a nós mesmos até que um dos dois acabasse primeiro. O que ela traz eu chamo de solução!";
            txtFala[2] = "";
            txtNomePersonagem = "Atormentado";
            cd.Fala(Atormentado, txtFala, txtNomePersonagem);
        }
        else if(falasRestantes == 4){
            txtFala[0] = "Você não pode estar falando sério...";
            txtFala[1] = "";
            txtFala[2] = "";
            txtNomePersonagem = "Helena";
            cd.Fala(Helena, txtFala, txtNomePersonagem);
        }
        else if(falasRestantes == 3){
            txtFala[0] = "Eu!? ... Falo seríssimo, mas não tenha medo, ela fará de você uma pessoa mais forte. Lembre-se disso!";
            txtFala[1] = "Ah, e não pense em desistir, continue sua jornada e talvez encontrará a sua família... Ou não ... Hahaha.";
            txtFala[2] = "Porém, uma última dica antes de eu sumir por completo: siga para o leste da ilha. Lá até uma garotinha idiota como você acharia respostas.";
            txtNomePersonagem = "Atormentado";
            cd.Fala(Atormentado, txtFala, txtNomePersonagem);
        }
        else if(falasRestantes == 2){
            txtFala[0] = "Ok!? Agora tenho certeza de que aqui não é a Terra, tipo... claramente não é o meu mundo. Será que acredito nele? Bom, preciso ir para casa!";
            txtFala[1] = "";
            txtFala[2] = "";
            txtNomePersonagem = "Helena";
            cd.Fala(Helena, txtFala, txtNomePersonagem);
        }
        else if(falasRestantes == 1){
            txtFala[0] = "Ah, mande meus cumprimentos a Niliie! Ela vai adorar te conhecer!";
            txtFala[1] = "";
            txtFala[2] = "";
            txtNomePersonagem = "Atormentado";
            cd.Fala(Atormentado, txtFala, txtNomePersonagem);
        }
        falasRestantes--; 
    }
}
