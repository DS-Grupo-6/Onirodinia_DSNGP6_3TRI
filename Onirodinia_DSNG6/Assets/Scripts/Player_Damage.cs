using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Damage : MonoBehaviour
{
    private Helena player;
    void Awake() {
        player = GameObject.Find("Helena").GetComponent<Helena> ();
    }
//Verifica colisao objetos dano
    void OnTriggerEnter2D(Collider2D other) {

        if(other.CompareTag ("Object_Damage")){//Objetos que dao dano
            if (!player.invunerable){
                player.DamagePlayer ();
            }
        }        
    }
}
