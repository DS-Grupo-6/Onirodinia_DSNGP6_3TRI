using System.Collection;
using System.Collection.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviuor
{
    public float Speed;
    public float StoppingDistance;
    private transform Target;

    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<transform>();
    }

    void Update()
    {
        if(Vector2, Distance(transform.position, Target.position) > StoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
        }  
    }
}