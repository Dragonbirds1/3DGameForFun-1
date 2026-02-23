using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Light2Button : Interactable
{
    [SerializeField]
    public GameObject spotLight;
    public GameObject NeonThing;
    private bool toggleLight;
    public Material lightOnMat;
    public Material lightOffMat;
    public bool canInteract = true;
    public AudioSource noPowerAudio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        toggleLight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!toggleLight && canInteract == true)
        {
            spotLight.SetActive(false);
            NeonThing.GetComponent<MeshRenderer>().material = lightOffMat;
        }
        else if (toggleLight && canInteract == true)
        {
            spotLight.SetActive(true);
            NeonThing.GetComponent<MeshRenderer>().material = lightOnMat;
        }
    }

    // This function is where we will design our interaction using code.
    protected override void Interact()
    {
        if (canInteract == true)
        {
            toggleLight = !toggleLight;
        }
        else if (canInteract == false)
        {
            noPowerAudio.Play();
        }
    }
}