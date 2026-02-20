using UnityEngine;

public class VendChoice : MonoBehaviour
{
    public Money money;
    public GameObject vendMenu;
    public GameObject cheezy, sprite, drp, starbu, mcd, cat, let, bucketofchicken, donut, gun, blade;
    public Pistol pistol;
    public Knife knife;
    public PlayerHealth playerHealth;
    public bool haveItem;
    public bool item1, item2, item3, item4, item5, item6, item7, item8, item9;
    public KeyCode eatKey;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (haveItem == true)
        {
            knife.knifeAnimator.SetBool("Swing", false);
            pistol.pistolAnimator.SetBool("Reload", false);
            knife.onKnife = false;
            knife.onGun = false;
            gun.SetActive(false);
            blade.SetActive(false);
            pistol.canShoot = false;
            if (Input.GetKeyDown(eatKey))
            {
                if (item1 == true)
                {
                    playerHealth.health += 5;
                    haveItem = false;
                    cheezy.SetActive(false);
                    item1 = false;
                }
                else if (item2 == true)
                {
                    playerHealth.health += 5;
                    haveItem = false;
                    sprite.SetActive(false);
                    item2 = false;
                }
                else if (item3 == true)
                {
                    playerHealth.health += 10;
                    haveItem = false;
                    drp.SetActive(false);
                    item3 = false;
                }
                else if (item4 == true)
                {
                    playerHealth.health += 20;
                    haveItem = false;
                    starbu.SetActive(false);
                    item4 = false;
                }
                else if (item5 == true)
                {
                    playerHealth.health += 45;
                    haveItem = false;
                    mcd.SetActive(false);
                    item5 = false;
                }
                else if (item6 == true)
                {
                    playerHealth.health += 100;
                    haveItem = false;
                    cat.SetActive(false);
                    item6 = false;
                }
                else if (item7 == true)
                {
                    playerHealth.health += 25;
                    haveItem = false;
                    let.SetActive(false);
                    item7 = false;
                }
                else if (item8 == true)
                {
                    playerHealth.health += 20;
                    haveItem = false;
                    bucketofchicken.SetActive(false);
                    item8 = false;
                }
                else if (item9 == true)
                {
                    playerHealth.health += 30;
                    haveItem = false;
                    donut.SetActive(false);
                    item9 = false;
                }
            }
        }
        else if (haveItem == false)
        {
            knife.onGun = true;
            knife.onKnife = true;
        }
    }

    public void A1()
    {
        if (money.currentMoney >= 1)
        {
            money.currentMoney -= 1;
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You have bought item A1.");
            haveItem = true;
            cheezy.SetActive(true);
            item1 = true;
        }
        else
        {
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You do not have enough money to buy item A1.");
        }
    }

    public void A2()
    {
        if (money.currentMoney >= 1)
        {
            money.currentMoney -= 1;
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You have bought item A2.");
            haveItem = true;
            sprite.SetActive(true);
            item2 = true;
        }
        else
        {
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You do not have enough money to buy item A2.");
        }
    }

    public void A3()
    {
        if (money.currentMoney >= 2)
        {
            money.currentMoney -= 2;
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You have bought item A3.");
            haveItem = true;
            drp.SetActive(true);
            item3 = true;
        }
        else
        {
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You do not have enough money to buy item A3.");
        }
    }

    public void B1()
    {
        if (money.currentMoney >= 3)
        {
            money.currentMoney -= 3;
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You have bought item B1.");
            haveItem = true;
            starbu.SetActive(true);
            item4 = true;
        }
        else
        {
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You do not have enough money to buy item B1.");
        }
    }

    public void B2()
    {
        if (money.currentMoney >= 7)
        {
            money.currentMoney -= 7;
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You have bought item B2.");
            haveItem = true;
            mcd.SetActive(true);
            item5 = true;
        }
        else
        {
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You do not have enough money to buy item B2.");
        }
    }

    public void B3()
    {
        if (money.currentMoney >= 10)
        {
            money.currentMoney -= 10;
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You have bought item B3.");
            haveItem = true;
            cat.SetActive(true);
            item6 = true;
        }
        else
        {
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You do not have enough money to buy item B3.");
        }
    }

    public void C1()
    {
        if (money.currentMoney >= 5)
        {
            money.currentMoney -= 5;
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You have bought item C1.");
            haveItem = true;
            let.SetActive(true);
            item7 = true;
        }
        else
        {
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You do not have enough money to buy item C1.");
        }
    }

    public void C2()
    {
        if (money.currentMoney >= 3)
        {
            money.currentMoney -= 3;
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You have bought item C2.");
            haveItem = true;
            bucketofchicken.SetActive(true);
            item8 = true;
        }
        else
        {
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You do not have enough money to buy item C2.");
        }
    }

    public void C3()
    {
        if (money.currentMoney >= 6)
        {
            money.currentMoney -= 6;
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You have bought item C3.");
            haveItem = true;
            donut.SetActive(true);
            item9 = true;
        }
        else
        {
            vendMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("You do not have enough money to buy item C3.");
        }
    }
}
