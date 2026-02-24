using UnityEngine;

public class CloseTutorialDoorPortal : MonoBehaviour
{
    public Animator doorAnimator;
    public GameObject closeTutorialDoorPortal;
    public AudioSource doorClosedSound;

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
            doorAnimator.SetBool("IsClosed", true);
            doorClosedSound.Play();
            Destroy(closeTutorialDoorPortal);
        }
    }
}
