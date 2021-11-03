using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleDialogo : MonoBehaviour
{
    //Componentes
    public GameObject objDialogo;
    public Image personagem;
    public Text txtFala;
    public Text txtNomePersonagem;

    //Configuracoes
    public float tempoDigitacao;
    private string[] sentenca;
    private int index;
//Funcao apresentar as falas
    public void Fala(Sprite pers, string[] txt, string nome)
    {
        objDialogo.SetActive(true);
        personagem.sprite = pers;
        sentenca = txt;
        txtNomePersonagem.text = nome;
        StartCoroutine(DigitarSentenca());
    }
//Apresentar letra a letra no dialogo
    IEnumerator DigitarSentenca()
    {
        foreach (char letras in sentenca[index].ToCharArray())
        {
            txtFala.text += letras;
            yield return new WaitForSeconds(tempoDigitacao);
        }
    }
//Pular para proxima sentenca
    public void ProximaSentenca()
    {
        //Verifica se o txt esta completo
        if(txtFala.text == sentenca[index])
        {
            //Verifica se ainda ha txt
            if(index < sentenca.Length - 1)
            {
                index++;
                txtFala.text = "";
                StartCoroutine(DigitarSentenca());
            }
            //Quando acabar txt
            else
            {
                PularDialogo();
            }
        }
    }
//Desativa dialogo e inicia fase 1
    public void PularDialogo()
    {
        txtFala.text = "";
        index = 0;
        objDialogo.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase_1");
    }
}
