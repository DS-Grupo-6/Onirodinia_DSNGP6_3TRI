using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoControle : MonoBehaviour
{
    //Componentes
    public GameObject objDialogo;
    public Image personagem;
    public Image imagemFundo;
    public Text txtFala;
    public Text txtNomePersonagem;
    private DialogoCS dialogo;
    public AudioSource somDigitacao;

    //Configuracoes
    public float tempoDigitacao;
    private string[] sentenca;
    private int index;
    void Start()
    {
        dialogo = FindObjectOfType<DialogoCS>();
    }
//Funcao mudar fundo
    public void MudarFundo(Sprite fundo){
        this.imagemFundo.sprite = fundo;
    }
//Funcao apresentar as falas
    public void Fala(Sprite pers, string[] txt, string nome)
    {
        objDialogo.SetActive(true);
        this.personagem.sprite = pers;
        this.sentenca = txt;
        this.txtNomePersonagem.text = nome;
        StartCoroutine(DigitarSentenca());
    }
//Apresentar letra a letra no dialogo
    IEnumerator DigitarSentenca()
    {
        somDigitacao.Play();
        foreach (char letras in this.sentenca[index].ToCharArray())
        {
            this.txtFala.text += letras;
            yield return new WaitForSeconds(this.tempoDigitacao);
        }
    }
//Pular para proxima sentenca
    public void ProximaSentenca()
    {
        //Verifica se o txt esta completo
        if(this.txtFala.text == this.sentenca[index])
        {
            //Verifica se ainda ha txt
            if((index < this.sentenca.Length - 1)&&(this.sentenca[index+1] != ""))
            {
                index++;
                this.txtFala.text = "";
                StartCoroutine(DigitarSentenca());
            }
            else if(dialogo.falasRestantes > 0){
                this.txtFala.text = "";
                this.index = 0;
                dialogo.IniciarDialogo();
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
        this.txtFala.text = "";
        this.index = 0;
        objDialogo.SetActive(false);
        if(dialogo.numeroCutScene == 1){
            UnityEngine.SceneManagement.SceneManager.LoadScene("Fase_0");
        }
        else if(dialogo.numeroCutScene == 2){
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        }        
    }
}
