using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Light4Button : Interactable
{
    [SerializeField]
    public GameObject spotLight;
    public GameObject NeonThing;
    private bool toggleLight;
    public Material lightOnMat;
    public Material lightOffMat;

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
            NeonThing.GetComponent<MeshRenderer>().material = lightOffMat;

        }
        else if (toggleLight)
        {
            spotLight.SetActive(true);
            NeonThing.GetComponent<MeshRenderer>().material = lightOnMat;
        }
    }

    // This function is where we will design our interaction using code.
    protected override void Interact()
    {
        toggleLight = !toggleLight;
    }
}