using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorvete : MonoBehaviour
{

	private SpriteRenderer spriteRenderer;
	private CircleCollider2D circleCollider2D;

	public GameObject efeitoColeta;

    // Start is called before the first frame update
    void Start()
    {
    	spriteRenderer = GetComponent<SpriteRenderer>();
    	circleCollider2D = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collider){

    	//Se o jogador encostar no item
    	if(collider.gameObject.layer == 15){

    		//desabilita o render e a colisão do objeto
    		spriteRenderer.enabled = false;
    		circleCollider2D.enabled = false;

    		//ativa o efeito de coleta
    		efeitoColeta.SetActive(true);

    		//destroi o item após 300ms
    		Destroy(gameObject, 0.3f);
    	}
    }
}
