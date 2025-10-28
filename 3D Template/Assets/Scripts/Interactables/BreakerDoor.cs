using UnityEngine;

public class BreakerDoor : Interactable
{
    [SerializeField]
    public GameObject breakerDoor;
    public GameObject lightButton1;
    public GameObject lightButton2;
    public GameObject lightButton3;
    public GameObject lightButton4;
    public GameObject fake1;
    public GameObject fake2;
    public GameObject fake3;
    public GameObject fake4;
    private bool breakerDoorOpen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (breakerDoorOpen)
        {
            lightButton1.SetActive(true);
            lightButton2.SetActive(true);
            lightButton3.SetActive(true);
            lightButton4.SetActive(true);
            fake1.SetActive(false);
            fake2.SetActive(false);
            fake3.SetActive(false);
            fake4.SetActive(false);

        }
        else if (!breakerDoorOpen)
        {
            WaitForSeconds.Equals(2, 2);
            lightButton1.SetActive(false);
            lightButton2.SetActive(false);
            lightButton3.SetActive(false);
            lightButton4.SetActive(false);
            fake1.SetActive(true);
            fake2.SetActive(true);
            fake3.SetActive(true);
            fake4.SetActive(true);
        }
    }

    // This function is where we will design our interaction using code.
    protected override void Interact()
    {
        breakerDoorOpen = !breakerDoorOpen;
        breakerDoor.GetComponent<Animator>().SetBool("IsPowerOpen", breakerDoorOpen);
    }
}

