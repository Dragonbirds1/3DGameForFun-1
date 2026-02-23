using UnityEngine;
using TMPro;

public class Pistol : MonoBehaviour
{
    [Header("Pistol Settings")]
    [Tooltip("Part that represents the muzzle of the pistol where bullets are fired from.")]
    public Transform muzzlePart;
    [Tooltip("Key to press to shoot the pistol.")]
    public KeyCode shootKey;
    [Tooltip("Key to press to focus the pistol for aiming.")]
    public KeyCode focusKey;
    [Tooltip("Key to press to reload the pistol.")]
    public KeyCode reloadKey;
    [Tooltip("Part that represents the bullet that is fired from the pistol.")]
    public Transform bulletPart;
    [Tooltip("Damage dealt by each bullet fired from the pistol.")]
    public int damage;
    [Tooltip("Speed at which the bullet travels when fired.")]
    public float bulletSpeed;
    [Tooltip("Time interval between consecutive shots.")]
    public float shootInterval;
    [Tooltip("Force applied to the bullet when fired.")]
    public float shootForce;
    [Tooltip("Rate of fire for the pistol.")]
    public float fireRate;
    [Tooltip("Maximum range of the pistol.")]
    public float range;
    [Tooltip("Crosshair UI element for aiming.")]
    public Transform crosshairPart;
    [Tooltip("Gun part to focus on when aiming.")]
    public Transform gunFocusPart;
    [Tooltip("Bullets available before needing to reload.")]
    public int ammoCount;
    [Tooltip("Text element to display ammo count.")]
    public TextMeshProUGUI ammoText;
    [Tooltip("Text element to display how much ammo you have.")]
    public TextMeshProUGUI ammoDisplayText;
    [Tooltip("How much ammo you have in total.")]
    public int totalAmmo;
    [Tooltip("Time it takes to reload the pistol.")]
    public float reloadTime;
    [Tooltip("Animator for the pistol.")]
    public Animator pistolAnimator;
    public bool isFocusing = false;
    public bool canFocus = true;
    public bool canShoot = true;
    public bool canReload = true;
    public bool startReload = false;
    public bool gettingAmmo = false;
    public bool swapToKnife = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (swapToKnife == false)
        {
            // Update ammo text display
            ammoText.text = ammoCount.ToString();
            // Update total ammo display
            ammoDisplayText.text = totalAmmo.ToString();
            // Implementation for shooting logic would go here
            // Check for focus input
            if (Input.GetKeyDown(focusKey) && canFocus == true)
            {
                // Logic to focus the pistol for aiming
                // This could involve changing camera zoom, crosshair visibility, etc.
                gunFocusPart.localPosition = new Vector3(0f, -.3f, 0.5f); // Example focus adjustment
                                                                          // If isFocusing is true and shootKey is pressed, shoot the pistol at the crosshair position
                isFocusing = true;
            }
            else if (Input.GetKeyUp(focusKey) || canFocus == false)
            {
                // Logic to unfocus the pistol
                gunFocusPart.localPosition = new Vector3(0.374f, -0.412f, 0.611f); // Reset focus adjustment
                isFocusing = false;
            }

            if (isFocusing == false && Input.GetKeyDown(shootKey))
            {
                Shoot();
            }
            else if (isFocusing == true && Input.GetKeyDown(shootKey))
            {
                FocusShoot();
            }
            if (Input.GetKeyDown(reloadKey) && canReload == true)
            {
                // Logic to reload the pistol
                if (ammoCount == 10)
                {
                    Debug.Log("Ammo Full!");
                    return;
                }
                pistolAnimator.SetBool("Reload", true);
                startReload = true;
            }

            if (totalAmmo <= 0)
            {
                canReload = false;
            }

            if (startReload)
            {
                isFocusing = false;
                canFocus = false;
                reloadTime -= Time.deltaTime;
                if (reloadTime <= 0f)
                {
                    pistolAnimator.SetBool("Reload", false);
                    startReload = false;
                    canFocus = true;
                    if (ammoCount <= 0)
                    {
                        totalAmmo -= 10; // Decrease total ammo accordingly
                        ammoCount = 10; // Refill ammo count
                    }
                    else if (ammoCount == 1)
                    {
                        totalAmmo -= 9; // Decrease total ammo accordingly
                        ammoCount = 10; // Refill ammo count
                    }
                    else if (ammoCount == 2)
                    {
                        totalAmmo -= 8; // Decrease total ammo accordingly
                        ammoCount = 10; // Refill ammo count
                    }
                    else if (ammoCount == 3)
                    {
                        totalAmmo -= 7; // Decrease total ammo accordingly
                        ammoCount = 10; // Refill ammo count
                    }
                    else if (ammoCount == 4)
                    {
                        totalAmmo -= 6; // Decrease total ammo accordingly
                        ammoCount = 10; // Refill ammo count
                    }
                    else if (ammoCount == 5)
                    {
                        totalAmmo -= 5; // Decrease total ammo accordingly
                        ammoCount = 10; // Refill ammo count
                    }
                    else if (ammoCount == 6)
                    {
                        totalAmmo -= 4; // Decrease total ammo accordingly
                        ammoCount = 10; // Refill ammo count
                    }
                    else if (ammoCount == 7)
                    {
                        totalAmmo -= 3; // Decrease total ammo accordingly
                        ammoCount = 10; // Refill ammo count
                    }
                    else if (ammoCount == 8)
                    {
                        totalAmmo -= 2; // Decrease total ammo accordingly
                        ammoCount = 10; // Refill ammo count
                    }
                    else if (ammoCount == 9)
                    {
                        totalAmmo -= 1; // Decrease total ammo accordingly
                        ammoCount = 10; // Refill ammo count
                    }
                    else if (ammoCount == 10)
                    {
                        totalAmmo -= 0; // Decrease total ammo accordingly
                        ammoCount = 10; // Refill ammo count
                    }
                    if (totalAmmo <= 0)
                    {

                        ammoCount = ammoCount + totalAmmo; // Adjust ammo count if total ammo is less than needed
                        totalAmmo = 0;
                    }
                    canShoot = true;
                    Debug.Log("Pistol Reloaded!");
                    reloadTime = 2.500f;
                }
            }
        }
        else if (swapToKnife == true)
        {
            pistolAnimator.SetBool("Reload", false);
            return;
        }
    }

    void Shoot()
    {
        if (canShoot == true)
        {
            // Instantiate bullet at the muzzle position
            Transform bullet = Instantiate(bulletPart, muzzlePart.position, muzzlePart.rotation);
            // Add force to the bullet to propel it forward
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {

                // Shoot the bullet forward with specified speed
                rb.AddForce(muzzlePart.forward * shootForce, ForceMode.Impulse);

            }
            // Additional shooting logic such as damage application and range handling would go here
            // Lower ammo count
            ammoCount--;
            // Check if ammo is depleted
            if (ammoCount <= 0)
            {
                Ammo();
                canReload = true;
            }
            // After shooting, you might want to destroy the bullet after a certain time to avoid clutter
            Destroy(bullet.gameObject, range / bulletSpeed);
        }
    }

    void FocusShoot()
    {
        if (canShoot == true)
        {
            // Instantiate bullet at the muzzle position
            Transform bullet = Instantiate(bulletPart, muzzlePart.position, muzzlePart.rotation);
            // Add force to the bullet to propel it towards the crosshair position
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 targetDirection = (crosshairPart.position - muzzlePart.position).normalized;
                rb.AddForce(targetDirection * shootForce, ForceMode.Impulse);
            }
            // Additional shooting logic such as damage application and range handling would go here
            // Lower ammo count
            ammoCount--;
            // Check if ammo is depleted
            if (ammoCount <= 0)
            {
                Ammo();
                canReload = true;
            }
            // After shooting, you might want to destroy the bullet after a certain time to avoid clutter
            Destroy(bullet.gameObject, range / bulletSpeed);
        }
    }

    void Ammo()
    {
        canShoot = false;
        Debug.Log("Out of Ammo, please Reload!");
    }
}
