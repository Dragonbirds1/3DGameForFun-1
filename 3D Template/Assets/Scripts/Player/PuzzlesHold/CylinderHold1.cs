using UnityEngine;

public class CylinderHold1 : Interactable
{
    public Pistol pistol;
    public Knife knife;
    public GameObject gun;
    public GameObject blade;
    public GameObject holdObject;
    public GameObject interactObject;
    public GameObject itemPutBack;
    public bool onHold;
    public bool isItemPutBack;
    private MeshRenderer objectRenderer;
    private BoxCollider objectCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        itemPutBack.SetActive(false);
        objectRenderer = GetComponent<MeshRenderer>();
        objectCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onHold == true)
        {
            knife.knifeAnimator.SetBool("Swing", false);
            pistol.pistolAnimator.SetBool("Reload", false);
            knife.onKnife = false;
            knife.onGun = false;
            gun.SetActive(false);
            blade.SetActive(false);
            pistol.canShoot = false;
            pistol.canFocus = false;
            holdObject.SetActive(true);
            if (isItemPutBack == true)
            {
                onHold = false;
                holdObject.SetActive(false);
                isItemPutBack = false;
                itemPutBack.SetActive(true);
                pistol.canShoot = true;
                pistol.canFocus = true;
            }
        }
        else if (onHold == false)
        {
            knife.onGun = true;
            knife.onKnife = true;
        }
    }

    protected override void Interact()
    {
        onHold = true;
        knife.onGun = false;
        knife.onKnife = false;
        objectRenderer.enabled = false;
        objectCollider.enabled = false;
    }
}
