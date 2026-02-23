
using System.Threading;
using System.Collections;
using UnityEngine;

public class Keypad : Interactable
{

    [SerializeField]
    public GameObject door;
    public bool doorOpen;
    public AudioSource applePay;
    public AudioSource reverseApplePay;
    public AudioSource fnafDoor;
    public AudioSource noPower;
    public float waitTime;
    public bool canInteract = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This function is where we will design our interaction using code.
    protected override void Interact()
    {
        if (canInteract == true)
        {
            if (!doorOpen)
            {
                applePay.Play();
            }
            else if (doorOpen)
            {
                reverseApplePay.Play();
            }
            doorOpen = !doorOpen;

            door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
            fnafDoor.Play();
        }
        else if (canInteract == false) 
        {
            noPower.Play();
        }
    }
}
