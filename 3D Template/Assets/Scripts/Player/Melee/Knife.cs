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
    public float damage;
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
    bool startTimer = false;
    
    // More code will be added here in the future

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        knifePart.SetActive(false);
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

                }
            }
        }
        else if (pistol.swapToKnife == false)
        {
            knifeAnimator.SetBool("Swing", false);
            knifePart.SetActive(false);
            pistolPart.SetActive(true);
            return;
        }
    }
}
