using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private enum TowerState
    {
        Create,
        Idle,
        Shoot,
        Skill,
        Destroy,
        Update
    }

    private enum TowerSkill
    {
        Skill_1,
        Skill_2,
        Skill_3
    }
    
    [SerializeField] private TowerState towerState;
    [SerializeField] private TowerSkill towerSkill;
    [SerializeField] private int level;
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;
    [SerializeField] private float range;
    [SerializeField] private float speedattack;
    [SerializeField] private GameObject bullets;
    private void Start()
    {
        towerState = TowerState.Create;
    }

    private void Update()
    {
        Move();
        switch (towerState)
        {
            case TowerState.Create:
                Create();
                break;
            case TowerState.Idle:
                Idle();
                break;
            case TowerState.Shoot:
                Shoot();
                break;
            case TowerState.Skill:
                Skill();
                break;
            case TowerState.Destroy:
                DestroyTower();
                break;
            case TowerState.Update:
                UpdateTower();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
    
    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speedattack * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speedattack * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speedattack * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speedattack * Time.deltaTime;
        }
    }

    private void Create()
    {
        level = 1;
        range = 10f;
        speedattack = 1f;
    }

    private void Idle()
    {
    }

    private void Shoot()
    {
        float dist = Vector3.Distance(RefernceHolder.Ins.enemyTarget.transform.position, transform.position);
        if(dist <= range)
        {
            ObjectPool.Ins.SpawnFromPool(Constans.Tag_Bullet, transform.position, Quaternion.identity);
        }
        else
        {
            return;
        }
    }

    private void Skill()
    {
        switch (towerSkill)
        {
            case TowerSkill.Skill_1:
                Skill_1();
                break;
            case TowerSkill.Skill_2:
                Skill_2();
                break;
            case TowerSkill.Skill_3:
                Skill_3();
                break;
        }
    }

    private void DestroyTower()
    {
    }

    private void UpdateTower()
    {
    }

    private void SKill_1()
    {
        
    }

    private void Skill_2()
    {
        
    }
    
    private void SKill_3()
    {
        
    }
}