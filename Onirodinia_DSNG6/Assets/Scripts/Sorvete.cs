using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sorvete : MonoBehaviour
{

	private SpriteRenderer spriteRenderer;
	private CapsuleCollider2D capsuleCollider2D;
	public GameObject efeitoColeta;
	private Helena player;
	public int numHealth;

    // Start is called before the first frame update
    void Start()
    {
    	spriteRenderer = GetComponent<SpriteRenderer>();
    	capsuleCollider2D = GetComponent<CapsuleCollider2D>();
		player = GameObject.Find("Helena").GetComponent<Helena> ();
    }

    private void OnTriggerEnter2D(Collider2D collider){

    	//Se o jogador encostar no item
    	if(collider.gameObject.layer == 10){

    		//desabilita o render e a colisão do objeto
    		spriteRenderer.enabled = false;
    		capsuleCollider2D.enabled = false;

    		//ativa o efeito de coleta
    		efeitoColeta.SetActive(true);

    		//destroi o item após 300ms
    		Destroy(gameObject, 0.3f);

			//adiciona uma vida
			player.LifePlayer(numHealth);
    	}
    }
}
