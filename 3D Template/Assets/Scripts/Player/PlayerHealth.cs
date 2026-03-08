using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public PlayerMotor playerMotor;
    public PlayerLook playerLook;
    public float health;
    private float lerpTimer;
    public float maxHealth = 100f;
    public float chipSpeed = 2f;
    public bool isDead = false;
    public bool isDeadStart = false;
    public GameObject[] deathPopups;
    public Image frontHealthBar;
    public Image backHealthBar;
    public TextMeshProUGUI healthText;
    public KeyCode dieKey;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            isDead = true;
        }
        if (Input.GetKeyDown(dieKey))
        {
            TakeDamage(100);
        }
        if (isDead == true)
        {
            if (isDeadStart == false)
            {
                PlayerDead();
                isDeadStart = true;
            }
        }
        health = Mathf.Clamp(health, 0, maxHealth); 
        UpdateHealthUI();
    }

    public void UpdateHealthUI()
    {
        //Debug.Log(health);
        float fillF = frontHealthBar.fillAmount;
        float fillB = backHealthBar.fillAmount;
        float hFraction = health / maxHealth;
        if (fillB > hFraction)
        {
            frontHealthBar.fillAmount = hFraction;
            backHealthBar.color = Color.red;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer / chipSpeed;
            percentComplete = percentComplete * percentComplete;
            backHealthBar.fillAmount = Mathf.Lerp(fillB, hFraction, percentComplete);
        }
        if (fillF < hFraction)
        {
            backHealthBar.color = Color.green;
            backHealthBar.fillAmount = hFraction;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer / chipSpeed;
            percentComplete = percentComplete * percentComplete;
            frontHealthBar.fillAmount = Mathf.Lerp(fillF, backHealthBar.fillAmount, percentComplete);
        }
        healthText.text = Mathf.Round(health) + "/" + Mathf.Round(maxHealth);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        lerpTimer = 0f;
    }

    public void RestoreHealth(float healAmount)
    {
        health += healAmount;
        lerpTimer = 0f;
    }

    public void PlayerDead()
    {
        playerMotor.canMove = false;
        playerMotor.canJump = false;
        playerLook.canLook = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        foreach (GameObject gameObject in deathPopups)
        {
            if (gameObject != null)
            {
                gameObject.SetActive(true);
            }
            else if (gameObject == null)
            {
                Debug.Log("No GameObject!");
            }
        }
    }

}
