using System.Collection;
using System.Collection.Generic;
using UnityEngine;

public class DashMove : MonoBehaviuor{

    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;

    public GameObject dashEffect;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    void Update()
    {
        if(direction == 0)
        {
            if(Input.GetKeyDown(KeyCode.A)){
                Instantiate(dashEffect, transform.position, Quaternion.identity);
                direction = 1;
            } else if(Input.GetKeyDown(KeyCode.D)){
                Instantiate(dashEffect, transform.position, Quaternion.identity);
                direction = 2;
            } else if(Input.GetKeyDown(KeyCode.W)){
                Instantiate(dashEffect, transform.position, Quaternion.identity);
                direction = 3;
            } else if(Input.GetKeyDown(KeyCode.S)){
                Instantiate(dashEffect, transform.position, Quaternion.identity);
                direction = 4;
            }
        }

        else
        {
            if(dashTime <= 0){  // Se o a duração do dash for nula, isso volta a direção do dash para 0
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            } else{
                dashTime -= Time.deltaTime; // Caso a duração não for nula, apenas diminuirá lentamente 
                camAnim.SetTrigger("Shake");

                if(direction == 1){
                    rb.velocity = Vector2.left * dashSpeed; // Faz com que a direção do dash vá para esquerda
                } else if(direction == 2){
                    rb.velocity = Vector2.right * dashSpeed;
                } else if(direction == 3){
                    rb.velocity = Vector2.up * dashSpeed;
                } else if(direction == 4){
                    rb.velocity = Vector2.down = dashSpeed;
                }    
            }
        }
    }
}