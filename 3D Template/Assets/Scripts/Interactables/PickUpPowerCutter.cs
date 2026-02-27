using UnityEngine;

public class PickUpPowerCutter : Interactable
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
    public MeshRenderer gunMesh1, gunMesh2, gunMesh3, gunMesh4, bladeMesh1, bladeMesh2, bladeMesh3, bladeMesh4, bladeMesh5;
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
            gunMesh1.enabled = false;
            gunMesh2.enabled = false;
            gunMesh3.enabled = false;
            gunMesh4.enabled = false;
            bladeMesh1.enabled = false;
            bladeMesh2.enabled = false;
            bladeMesh3.enabled = false;
            bladeMesh4.enabled = false;
            bladeMesh5.enabled = false;
            pistol.canShoot = false;
            pistol.canFocus = false;
            holdObject.SetActive(true);
            if (isItemPutBack == true)
            {
                onHold = false;
                holdObject.SetActive(false);
                isItemPutBack = false;
                itemPutBack.SetActive(true);
                gunMesh1.enabled = true;
                gunMesh2.enabled = true;
                gunMesh3.enabled = true;
                gunMesh4.enabled = true;
                bladeMesh1.enabled = true;
                bladeMesh2.enabled = true;
                bladeMesh3.enabled = true;
                bladeMesh4.enabled = true;
                bladeMesh5.enabled = true;
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

