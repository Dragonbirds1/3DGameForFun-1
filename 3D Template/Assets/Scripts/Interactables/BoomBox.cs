using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class BoomBox : Interactable
{
    [Header("BoomBox Settings")]
    public bool isActive = false;
    public GameObject inField;
    public GameObject buttonThing;

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
        isActive = !isActive;

        if (isActive)
        {
            inField.SetActive(true);
            buttonThing.SetActive(true);
        }
        else if (!isActive)
        {
            inField.SetActive(false);
            buttonThing.SetActive(false);
        }
    }
}

