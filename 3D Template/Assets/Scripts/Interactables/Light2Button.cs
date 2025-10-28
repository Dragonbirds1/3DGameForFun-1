using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Light2Button : Interactable
{
    [SerializeField]
    public GameObject spotLight;
    private bool toggleLight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        toggleLight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!toggleLight)
        {
            spotLight.SetActive(false);
        }
        else if (toggleLight)
        {
            spotLight.SetActive(true);
        }
    }

    // This function is where we will design our interaction using code.
    protected override void Interact()
    {
        toggleLight = !toggleLight;
    }
}