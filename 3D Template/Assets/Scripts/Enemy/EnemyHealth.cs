using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    [Header("Health Settings")]
    public int maxHealth = 20;
    public int currentHealth;
    public int health;

    [Header("Pistol Script")]
    public Pistol pistol;

    [Header("Enemy GameObject")]
    public GameObject enemy;

    [Header("Materials")]
    public Material enemyMaterial;

    [Header("Times")]
    public float redFlashDuration = 0.2f;
    public float dieTime = 1.250f;

    [Header("Bools")]
    public bool startRedFlash = false;
    public bool isDead = false;

    [Header("Colors")]
    public Color originalColor;

    [Header("Animators")]
    public Animator enemyAnimator;

    [Header("Navmesh's")]
    public NavMeshAgent navMeshAgent;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == true) 
        {
            dieTime -= Time.deltaTime;
            if (dieTime <= 0)
            {
                Destroy(enemy);
            }
        }
        if (startRedFlash)
        {
            enemyMaterial.color = Color.red;
            redFlashDuration -= Time.deltaTime;
            if (redFlashDuration <= 0)
            {
                enemyMaterial.color = originalColor;
                startRedFlash = false;
                redFlashDuration = 0.2f;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            
            Destroy(collision.gameObject);
            startRedFlash = true;
            health -= pistol.damage;
            Debug.Log("Enemy Health: " + health);
            if (health <= 0)
            {
                navMeshAgent.enabled = false;
                isDead = true;
                enemyAnimator.SetBool("Die", true);
            }
        }
    }
}

