using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Atormentado : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anim;
    private Helena Player;
    private Controle_menu controleMenu;
    public float Speed;
    public float StoppingDistance;
    public float InitialDistance;
    private Transform Target;
    public int InitialHealth;
    public int Health;
    public int TimeHealth;
    private bool CanMove = false;
    private bool ColisaoPlayer = false;
    private bool Ataque = false;
    public int TimeWait;
    // Start is called before the first frame update
    void Start()
    {
        try{
            rig = GetComponent<Rigidbody2D>(); 
            anim = GetComponent<Animator>();
            Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Helena> ();
            controleMenu = GameObject.Find("ControleMenu").GetComponent<Controle_menu> ();

            Health = InitialHealth;
            StartCoroutine(Damage());
        }
        catch(Exception e){
            Debug.Log("Erro: "+ e);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!controleMenu.IsGameOver){
            Move();
            Death();
        }       
    }

    void Move()
    {
        if(Vector2.Distance(transform.position, Target.position) < InitialDistance){
            CanMove = true;
        }
        if((CanMove)&&(!Ataque)){
            StartCoroutine(Atack());
        }
        if(transform.position.x < Target.position.x){
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
        else{
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }
    }

    IEnumerator Damage()
    {
        for(int i=0; i<InitialHealth; i++){
            yield return new WaitForSeconds(TimeHealth);
            Health --;
        }        
    }

    IEnumerator Atack()
    {
        if((CanMove)&&(Vector2.Distance(transform.position, Target.position) > StoppingDistance)){
            anim.SetBool("atack", true);
            transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
            if(ColisaoPlayer){
                if(!Player.invunerable){
                    Player.DamagePlayer();
                }
                Ataque = true;
                CanMove = false;
                anim.SetBool("atack", false);    
                yield return new WaitForSeconds(TimeWait);
                CanMove = true;
                Ataque = false;
            }
        }
    }

    void Death(){
        if(Health<=0){
            UnityEngine.SceneManagement.SceneManager.LoadScene("CutScene_2");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        try{
            if(collision.gameObject.tag == "Player")
            {
                ColisaoPlayer = true;
            }
        }
        catch(Exception e){
            Debug.Log("Erro: "+ e);

        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        try{
            if(collision.gameObject.tag == "Player")
            {
                ColisaoPlayer = false;
            }
        }
        catch(Exception e){
            Debug.Log("Erro: "+ e);

        }
    }
}
