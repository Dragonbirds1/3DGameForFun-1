using Unity.VisualScripting;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [Header("Knife Settings")]
    [Tooltip("Pistol Script.")]
    public Pistol pistol;
    [Tooltip("Key to press to attack with the knife.")]
    public KeyCode attackKey;
    [Tooltip("Key to press to swap.")]
    public KeyCode swapKey;
    [Tooltip("Knife part.")]
    public GameObject knifePart;
    [Tooltip("Pistol part.")]
    public GameObject pistolPart;
    [Tooltip("Damage dealt by the knife attack.")]
    public int damage;
    [Tooltip("Range of the knife attack.")]
    public float range;
    [Tooltip("Animator for the knife.")]
    public Animator knifeAnimator;
    [Tooltip("Time interval between consecutive knife attacks.")]
    public float attackInterval;
    [Tooltip("Time it takes to be able to attack after the swap.")]
    public float swapDelay;
    [Tooltip("Timer to track time between attacks.")]
    public float attackTimer;
    public bool onKnife, onGun;
    bool startTimer = false;
    
    // More code will be added here in the future

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        knifePart.SetActive(false);
        onKnife = true;
        onGun = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(swapKey))
        {
            pistol.swapToKnife = !pistol.swapToKnife;
        }
        if (pistol.swapToKnife == true)
        {
            if (onKnife == true && onGun == true)
            {
                knifePart.SetActive(true);
                pistolPart.SetActive(false);
                if (startTimer == true)
                {
                    attackTimer -= Time.deltaTime;
                    if (attackTimer <= 0)
                    {
                        knifeAnimator.SetBool("Swing", false);
                        attackTimer = 0.350f;
                        startTimer = false;
                    }
                }
                swapDelay -= Time.deltaTime;
                if (swapDelay <= 0)
                {
                    swapDelay = 0;
                    if (Input.GetKeyDown(attackKey))
                    {
                        knifeAnimator.SetBool("Swing", true);
                        startTimer = true;
                        // Attack logic will be added here in the future
                        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, range))
                        {
                            EnemyHealth enemyHealth = hitInfo.collider.GetComponent<EnemyHealth>();
                            if (enemyHealth != null)
                            {
                                if (attackTimer == 0.350f)
                                {
                                    enemyHealth.health -= damage;
                                    Debug.Log("Enemy Health: " + enemyHealth.health);
                                    enemyHealth.startRedFlash = true;
                                }
                                if (enemyHealth.health <= 0)
                                {
                                    enemyHealth.isDead = true;
                                    enemyHealth.enemyAnimator.SetBool("Die", true);
                                    enemyHealth.navMeshAgent.enabled = false;
                                }
                            }
                        }
                    }
                }
            }
        }
        else if (pistol.swapToKnife == false)
        {
            if (onKnife == true && onGun == true)
            {
                knifeAnimator.SetBool("Swing", false);
                knifePart.SetActive(false);
                pistolPart.SetActive(true);
                return;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position + transform.forward * (range / 2), new Vector3(1, 1, range)); // Draw attack range
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * range); // Draw attack ray
    }
}
