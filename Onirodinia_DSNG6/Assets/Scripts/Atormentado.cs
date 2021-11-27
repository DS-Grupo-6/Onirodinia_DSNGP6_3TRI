using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Atormentado : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anim;
    public float Speed;
    public float StoppingDistance;
    private Transform Target;
    public int InitialHealth;
    private int Health;
    public int TimeHealth;
    // Start is called before the first frame update
    void Start()
    {
        try{
            rig = GetComponent<Rigidbody2D>(); 
            anim = GetComponent<Animator>();
            Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

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
        Move();
        Death();       
    }

    void Move()
    {
        if(Vector2.Distance(transform.position, Target.position) > StoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
        }
    }

    IEnumerator Damage()
    {
        for(int i=0; i<InitialHealth; i++){
            yield return new WaitForSeconds(TimeHealth);
            Health --;
        }        
    }

    void Death(){
        if(Health<=0){
            UnityEngine.SceneManagement.SceneManager.LoadScene("CutScene_2");
        }
    }
}
