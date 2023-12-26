using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefernceHolder : Singleton<RefernceHolder>
{
    public Brick brick;
    public Enemy enemy;
    public Transform startPoint;
    public Transform endPoint;
    public Transform enemyTarget;
    private void OnValidate()
    {
        if (brick == null)
        {
            brick = FindObjectOfType<Brick>();
        }

        if (startPoint == null) 
        {
            startPoint = GameObject.FindGameObjectWithTag("StartPoint").transform;
        } 

        if (endPoint == null)
        {
            endPoint = GameObject.FindGameObjectWithTag("EndPoint").transform;
        }

        if (enemy == null)
        {
            enemy = FindObjectOfType<Enemy>();
        }
    }
}
