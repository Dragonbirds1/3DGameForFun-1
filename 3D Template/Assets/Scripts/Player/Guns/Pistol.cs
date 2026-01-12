using UnityEngine;

public class Pistol : MonoBehaviour
{
    [Header("Pistol Settings")]
    [Tooltip("Part that represents the muzzle of the pistol where bullets are fired from.")]
    public Transform muzzlePart;
    [Tooltip("Key to press to shoot the pistol.")]
    public KeyCode shootKey;
    [Tooltip("Key to focus the pistol for aiming.")]
    public KeyCode focusKey;
    [Tooltip("Part that represents the bullet that is fired from the pistol.")]
    public Transform bulletPart;
    [Tooltip("Damage dealt by each bullet fired from the pistol.")]
    public float damage;
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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Implementation for shooting logic would go here
        // Check for focus input
        if (Input.GetKeyDown(focusKey))
        {
            // Logic to focus the pistol for aiming
            // This could involve changing camera zoom, crosshair visibility, etc.
            gunFocusPart.localPosition = new Vector3(0f, -1f, 0.5f); // Example focus adjustment
        }
        if (Input.GetKeyDown(shootKey))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        // Instantiate bullet at the muzzle position
        Transform bullet = Instantiate(bulletPart, muzzlePart.position, muzzlePart.rotation);
        // Add force to the bullet to propel it forward
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            
            // Shoot the bullet to the crosshair position
            Vector3 shootDirection = (crosshairPart.position - muzzlePart.position).normalized;
            // Make it so the bullet will hit where the crosshair is aiming at
            rb.AddForce(shootDirection * shootForce, ForceMode.Impulse);
            rb.AddForce(shootDirection * bulletSpeed, ForceMode.VelocityChange);
            // Make the bullet straiten out after lined up with the crosshair

        }
        // Additional shooting logic such as damage application and range handling would go here
        // After shooting, you might want to destroy the bullet after a certain time to avoid clutter
        Destroy(bullet.gameObject, range / bulletSpeed);
    }
}
