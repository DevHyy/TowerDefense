using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] private int damage;

    private void Update()
    {
        CheckDistanceWithEnemy();
    }

    private void CheckDistanceWithEnemy()
    {
        float dist = Vector3.Distance(RefernceHolder.Ins.enemyTarget.transform.position, transform.position);
        if(dist <= 0.5f)
        {
            RefernceHolder.Ins.enemyTarget.GetComponent<Enemy>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
