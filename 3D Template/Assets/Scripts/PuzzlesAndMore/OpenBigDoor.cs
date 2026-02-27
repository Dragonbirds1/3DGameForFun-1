using UnityEngine;

public class OpenBigDoor : MonoBehaviour
{
    public Pistol pistol;
    public GameObject bigDoor, powerCutter1, powerCutter2, powerCutter3, powerCutter4;
    public Animator bigDoorAnim;
    public float health;
    public float maxHealth = 10;
    public bool isPowerCut = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (powerCutter1.activeSelf == true && powerCutter2.activeSelf == true && powerCutter3.activeSelf == true && powerCutter4.activeSelf == true)
        {
            isPowerCut = true;
        }
        else if (powerCutter1.activeSelf == false || powerCutter2.activeSelf == false || powerCutter3.activeSelf == false || powerCutter4.activeSelf == false)
        {
            isPowerCut = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (isPowerCut)
        {
            if (collision.gameObject.CompareTag("Bullet"))
            {
                if (health > 0)
                {
                    health -= pistol.damage;
                }
                if (health == 0)
                {
                    health = 0;
                    bigDoorAnim.SetBool("Broken", true);
                }
            }
        }
    }
}
