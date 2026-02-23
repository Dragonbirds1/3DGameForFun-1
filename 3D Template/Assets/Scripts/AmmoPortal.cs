using UnityEngine;

public class AmmoPortal : MonoBehaviour
{
    public Pistol pistol;
    public GameObject ammoPortal;
    public int ammoRemovedAmmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //pistol.ammoCount = 0;
            pistol.totalAmmo -= ammoRemovedAmmount;
            Destroy(ammoPortal);
        }
    }
}
