using UnityEngine;

public class Keypad2 : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen;
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
            doorOpen = !doorOpen;
            if (!doorOpen)
            {
                applePay.Play();
            }
            else if (doorOpen)
            {
                reverseApplePay.Play();
            }

            door.GetComponent<Animator>().SetBool("IsOpen", !doorOpen);
            fnafDoor.Play();
        }
        else if (canInteract == false) 
        {
            noPower.Play();
        }
    }
}
