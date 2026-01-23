using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class GetOnSwing : Interactable
{
    public IsOnSwing isOnSwingScript;

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
        isOnSwingScript.isOnSwing = true;
    }
}

