using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : BaseState
{
    private float moveTimer;
    private float losePlayerTimer;
    private float shotTimer;
    public override void Enter()
    {
    
    }

    public override void Exit()
    {
    
    }

    public override void Perform()
    {
        if (enemy != null)
        {
            if (enemy.CanSeePlayer())
            {
                losePlayerTimer = 0;
                moveTimer += Time.deltaTime;
                shotTimer += Time.deltaTime;
                enemy.transform.LookAt(enemy.Player.transform);
                // If shot timer > fireRate
                if (shotTimer > enemy.fireRate)
                {
                    Shoot();
                }
                if (moveTimer > Random.Range(3, 7))
                {
                    enemy.Agent.SetDestination(enemy.transform.position + (Random.insideUnitSphere * 5));
                    moveTimer = 0;
                }
                enemy.LastKnowPos = enemy.Player.transform.position;
            }
            else // Lost sight of the player.
            {
                losePlayerTimer += Time.deltaTime;
                if (losePlayerTimer > 8)
                {
                    // Change to the search state.
                    stateMachine.ChangeState(new SearchState());
                }
            }
        }
        else if (enemy == null)
        {
            Debug.Log("Enemy Is Dead");
        }
    }

    public void Shoot()
    {
        // Store reference to the gun barrel.
        Transform gunbarrel = enemy.gunBarrel;
        // Instantiate a new bullet.
        GameObject bullet = GameObject.Instantiate(Resources.Load("Prefabs/BulletEnemy") as GameObject, gunbarrel.position, enemy.transform.rotation);
        // Calculate the direction to the player.
        Vector3 shootDirection = (enemy.Player.transform.position - gunbarrel.transform.position).normalized;
        // Add force rigidbody of the bullet.
        bullet.GetComponent<Rigidbody>().linearVelocity = Quaternion.AngleAxis(Random.Range(-3f, 3f), Vector3.up) * shootDirection * 40;
        Debug.Log("Shoot");
        shotTimer = 0;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
