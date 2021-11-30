// FallingPlatform .
// Adicione uma plataforma ao cenário. No "inspector" marque-a como "Ground", depois atribua a ela um 
// "RigidBody2D" (para adicionar gravidade a plataforma) e também um "TargetJoint2D". 
// Importante: trave o eixo "z" (função "Freeze Rotation") para dar sustentabilidade a plataforma.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Plataforma : MonoBehaviour

{
    public float fallingTime; // Variável usada para cronometrar o tempo. (Obs1)
    private TargetJoint2D target; 
    private BoxCollider2D boxColl;
    private Helena health;
    private Helena player;
private Controle_menu controleMenu;
void Awake() {
        player = GameObject.Find("Helena").GetComponent<Helena> ();
    }
    void Start()
    {
        target = GetComponent<TargetJoint2D>(); 
        boxColl = GetComponent<BoxCollider2D>(); 
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")  
        {                                         
           // Destroy(player);   
           player.health = 0; 
           controleMenu.GameOver();
          // player.DamagePlayer ();    
        }
    }
} 
