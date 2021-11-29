using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarAtormen : MonoBehaviour
{
    public Sprite[] bar;
    public Image healthBarUI;
    private Atormentado boss;

    void Start()
    {
        boss = GameObject.Find("Atormentado").GetComponent<Atormentado> ();
    }

//Altera o hud de acordo com a vida
    void Update()
    {
        healthBarUI.sprite = bar [boss.Health];
    }
}