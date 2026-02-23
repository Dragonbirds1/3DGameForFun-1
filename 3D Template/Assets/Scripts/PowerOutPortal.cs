using UnityEngine;

public class PowerOutPortal : MonoBehaviour
{
    public GeneratorHealth generatorHealth;
    public GameObject powerOutPortal;
    public int healthRemoveAmount;
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
            generatorHealth.health -= healthRemoveAmount;
            Destroy(powerOutPortal);
        }
    }
}
