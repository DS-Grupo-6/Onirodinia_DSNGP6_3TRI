using System.Collection;
using System.Collection.Generic;
using UnityEngine;

public class DashMove : MonoBehaviuor{

    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    void Update()
    {
        if(direction == 0)
        {
            if(Input.GetKeyDown(KeyCode.A))
        }
    }
}