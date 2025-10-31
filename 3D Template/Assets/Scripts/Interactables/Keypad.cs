using UnityEngine;

public class Keypad : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    public AudioSource applePay;
    public AudioSource reverseApplePay;
    public AudioSource fnafDoor;
    public float waitTime;

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
        doorOpen = !doorOpen;
        if (doorOpen)
        {
            applePay.Play();
        }
        else if (!doorOpen)
        {
            reverseApplePay.Play();
        }
        waitTime += Time.deltaTime;
        if (waitTime > 3)
        {
            door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
        }
    }
}
