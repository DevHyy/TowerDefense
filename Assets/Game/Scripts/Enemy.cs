using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyState enemyState;
    [SerializeField] private float speedmove;
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;
    private enum EnemyState
    {
        Idle,
        Move,
        Shoot,
        Skill,
        Die
    }

    private void Update()
    {
        switch  (enemyState)
        {
            case EnemyState.Idle:
                Idle();
                break;
            case EnemyState.Move:
                Move();//change into start
                break;
            case EnemyState.Shoot:
                Shoot();
                break;
            case EnemyState.Skill:
                Skill();
                break;
            case EnemyState.Die:
                Die();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void Idle()
    {
        
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, RefernceHolder.Ins.endPoint.position, speedmove * Time.deltaTime);
    }

    private void Shoot()
    {
        
    }

    private void Skill()
    {
        
    }

    private void Die()
    {
        
    }
    
    public void TakeDamage(int damage)
    {
      currentHealth -= damage;
      if (currentHealth <= 0)
      {
          Destroy(gameObject);
      }
      else
      {
          return;
      }
    }
}
