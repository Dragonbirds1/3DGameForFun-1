using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class BoomBox : Interactable
{
    [Header("BoomBox Settings")]
    public bool isActive = false;
    public bool canInteract = true;
    public GameObject buttonThing1, buttonThing2, buttonThing3, buttonThing4;
    public AudioSource powerOutAudio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonThing1.SetActive(false);
        buttonThing2.SetActive(false);
        buttonThing3.SetActive(false);
        buttonThing4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        if (canInteract == true)
        {
            isActive = !isActive;

            if (isActive)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                buttonThing1.SetActive(true);
                buttonThing2.SetActive(true);
                buttonThing3.SetActive(true);
                buttonThing4.SetActive(true);
            }
            else if (!isActive)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                buttonThing1.SetActive(false);
                buttonThing2.SetActive(false);
                buttonThing3.SetActive(false);
                buttonThing4.SetActive(false);
            }
        }
        else if (canInteract == false)
        {
            powerOutAudio.Play();
        }
    }
}

