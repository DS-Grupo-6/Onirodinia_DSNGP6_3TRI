using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Sprite[] bar;
    public Image healthBarUI;
    private Helena player;

    void Start()
    {
        player = GameObject.Find("Helena").GetComponent<Helena> ();
    }

//Altera o hud de acordo com a vida
    void Update()
    {
        healthBarUI.sprite = bar [player.health];
    }
}
