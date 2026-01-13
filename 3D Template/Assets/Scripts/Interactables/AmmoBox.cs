using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class AmmoBox : Interactable
{
    [Header("Ammo Box Settings")]
    [Tooltip("Pistol script")]
    public Pistol pistol;
    [Tooltip("Amount of ammo to give")]
    public int ammoAmount = 10;
    bool canLoad = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pistol.totalAmmo > 90)
        {
            Debug.Log("Can't Load Ammo");
            canLoad = false;
        }
        else if (pistol.totalAmmo <= 90)
        {
            canLoad = true;
        }
    }

    protected override void Interact()
    {
        if (canLoad)
        {
            // Ensure that totalAmmo does not go over 100
            if (pistol.totalAmmo >= 100)
            {
                pistol.totalAmmo = 90;
            }

            pistol.totalAmmo += ammoAmount;
            pistol.canReload = true;
        }
        else if (!canLoad)
        {
            return;
        }
    }
}
