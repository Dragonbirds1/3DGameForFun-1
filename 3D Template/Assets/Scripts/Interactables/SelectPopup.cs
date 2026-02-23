using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.ProBuilder.Shapes;

public class SelectPopup : Interactable
{
    public GameObject popup;
    public bool canInteract = true;
    public AudioSource noPowerAudio;

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
        if (canInteract == true)
        {
            if (popup.activeInHierarchy == false)
            {
                popup.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
        else if (canInteract == false)
        {
            noPowerAudio.Play();
        }
    }
}

