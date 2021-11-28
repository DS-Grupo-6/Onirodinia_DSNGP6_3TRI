using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleGameOver : MonoBehaviour
{
    public GameObject TelaGameOver;
    private string CenaAtual;
    public bool IsGameOver;
    // Start is called before the first frame update
    void Start()
    {
        CenaAtual = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;        
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.F))&&(IsGameOver))
        {
            IsGameOver = false;
            UnityEngine.SceneManagement.SceneManager.LoadScene(CenaAtual);
        }    
    }
    public void GameOver(){
        IsGameOver = true;
        TelaGameOver.SetActive(true);
    }
}
