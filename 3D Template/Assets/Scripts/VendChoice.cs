using UnityEngine;

public class VendChoice : MonoBehaviour
{
    public Money money;
    public GameObject vendMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
