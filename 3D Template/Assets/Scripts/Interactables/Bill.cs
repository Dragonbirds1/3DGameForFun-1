using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Bill : Interactable
{
    [Header("Money Script")]
    public Money money;

    [Header("Bill Settings")]
    public GameObject bill;

    public int billValue = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {
        if (money.currentMoney < money.maxMoney)
        {
            money.currentMoney += billValue;
            Destroy(bill);
        }
        else if (money.currentMoney >= money.maxMoney)
        {
            Debug.Log("You have reached the maximum amount of money you can have.");
            Destroy(bill);
        }    
    }
}

