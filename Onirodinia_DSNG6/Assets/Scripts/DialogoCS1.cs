using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
        Array.Clear(txtFala,0,txtFala.Length);
        txtFala[0] = "O que tá acontecendo aqui?... Como tudo ficou assim? Agora pouco tava tudo certo. Será que isso é tipo aquelas histórias de sete além?";
        txtFala[1] = "Preciso achar ajuda, deve ter alguém por perto!";
        txtNomePersonagem = "Helena";
        cd.Fala(personagem, txtFala, txtNomePersonagem);
    }

    private void DialogoCutScene2(){
        Array.Clear(txtFala,0,txtFala.Length);
        txtFala[0] = "Bem agora que fui derrotado finalmente posso descansar, mas você... Se eu fosse você, teria mais cuidado para prosseguir!";
        txtFala[1] = "Nunca a vi tão obcecada por algo. E agora que estou fora de cena ... Os outros serão mais impiedosos!";
        txtNomePersonagem = "Atormentado";
        cd.Fala(personagem, txtFala, txtNomePersonagem);

        Array.Clear(txtFala,0,txtFala.Length);
        txtFala[0] = "Outros, do que você tá falando? O que tá acontecendo nessa cidade?";
        txtNomePersonagem = "Helena";
        cd.Fala(personagem, txtFala, txtNomePersonagem);

        Array.Clear(txtFala,0,txtFala.Length);
        txtFala[0] = "Você ainda não percebeu? Não acredito que uma garotinha idiota dessas tenha me vencido...";
        txtFala[1] = "Bem-vinda a Onirodinia! Essa é a cidade da imperatriz! Conquistada por ela e que nós, seus generais, mantemos em ordem sob o comando dela. Ela chegou a pouco tempo, trazendo o que os outros disseram ser caos, mas eu chamo de ordem!";
        txtNomePersonagem = "Atormentado";
        cd.Fala(personagem, txtFala, txtNomePersonagem);

        Array.Clear(txtFala,0,txtFala.Length);
        txtFala[0] = "Em ordem? Isso não parece estar em ordem! E se ela causou toda essa destruição, é ... É tirania!";
        txtNomePersonagem = "Helena";
        cd.Fala(personagem, txtFala, txtNomePersonagem);

        Array.Clear(txtFala,0,txtFala.Length);
        txtFala[0] = "Hahaha, e o que você esperava? Flores, debates e compreensão? Ninguém aprende assim! Desse jeito continuaríamos destruindo o mundo e a nós mesmos até que um dos dois acabasse primeiro. O que ela traz eu chamo de solução!";
        txtNomePersonagem = "Atormentado";
        cd.Fala(personagem, txtFala, txtNomePersonagem);

        Array.Clear(txtFala,0,txtFala.Length);
        txtFala[0] = "Você não pode estar falando sério...";
        txtNomePersonagem = "Helena";
        cd.Fala(personagem, txtFala, txtNomePersonagem);

        Array.Clear(txtFala,0,txtFala.Length);
        txtFala[0] = "Eu!? ... Falo seríssimo, mas não tenha medo, ela fará de você uma pessoa mais forte. Lembre-se disso!";
        txtFala[1] = "Ah, e não pense em desistir, continue sua jornada e talvez encontrará a sua família... Ou não ... Hahaha. Porém, uma última dica antes de eu sumir por completo: siga para o leste da ilha. Lá até uma garotinha idiota como você acharia respostas";
        txtNomePersonagem = "Atormentado";
        cd.Fala(personagem, txtFala, txtNomePersonagem);

        Array.Clear(txtFala,0,txtFala.Length);
        txtFala[0] = "Ok!? Agora tenho certeza de que aqui não é a Terra, tipo... claramente não é o meu mundo. Será que acredito nele? Bom, preciso ir para casa!";
        txtNomePersonagem = "Helena";
        cd.Fala(personagem, txtFala, txtNomePersonagem);

        Array.Clear(txtFala,0,txtFala.Length);
        txtFala[0] = "Ah, mande meus cumprimentos a Niliie! Ela vai adorar te conhecer!";
        txtNomePersonagem = "Atormentado";
        cd.Fala(personagem, txtFala, txtNomePersonagem);
    }
}
