using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidrantche : MonoBehaviour
{
    private Animator anim;
    public float jumpForce; // Variavel alteravel dentro do unity
    private AudioSource sound;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Awake() 
    {
        sound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Player")
        {
            anim.SetBool("jump", true);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            sound.Play();
        }

    }

    void OnCollisionExit2D(Collision2D collision) {
        anim.SetBool("jump", false);      
    }
}
