using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidrantche : MonoBehaviour
{
   
   private Animator animation;

   void Start()
   {
       animation = GetComponent<Animator>();
   }
   
    public float jumpForce; // Variavel alteravel dentro do unity 

    void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Player")
        {
            animation.SetTrigger("jump");
            collision.gameObject.GetComponent<RigidBody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}

/* Perimeiro crie uma nova animação para o hidrante, após ter a animação criada vá na aba "Animations" (ou na pasta em que 
as animações estão salvas, mas dentro do Unity) e selecine a animação do Hidrante. No "Inspector" você deve desmarcar a 
opção "Loop Time", depois vá na área de status das animações e crie um novo status vazio (pode renomea-lo como Idle), 
marque o novo status como padrão e ligue uma transição indo e voltando na animação do hidrante. Na parte que liga o Idle    
no hidrante crie um parâmetro e nomeie como "jump" (lembre-se de ir no Inspector -> Comditions e ative o "jump"), não há   
necessidade de colocar uma transição do hidrante de volta para o Idle. Por fim no inspector do Idle -> Hidrante vá em 
"Settings" e desmarque as funções "Has Exit Time" e "Fixed Duration", e zere o "Transition Duration". 
Importante: não desmarque o "Has Exit Time" do Hidrante -> Idle. */   
