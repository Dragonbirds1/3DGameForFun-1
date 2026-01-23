using UnityEngine;

public class IsOnSwing : MonoBehaviour
{
    /// <summary>
    /// This script is used to detect if the player is on a swing.
    /// If the player is on a swing, the player can swing.
    /// This script will cover: detecting if the player is on a swing, and allowing the player to swing, and the swinging mechanics.
    /// </summary>

    public bool isOnSwing = false;
    public GameObject swingObject;
    public Transform swingPoint;
    //public Transform swingDirection;
    public float MaxSwingSpeed = 10f;
    public float SwingAcceleration = 5f;
    public float SwingDeceleration = 5f;
    public float swingSpeed = 0f;
    public float SwingAccelerationSpeed = 0f;
    public float SwingDecelerationSpeed = 0f;
    public float CurrentSwingSpeed = 0f;
    public float swingAngle = 0f;
    public float maxSwingAngle = 45f;
    public float minSwingAngle = -45f;
    public GameObject player;
    public PlayerMotor playerMotor;
    public KeyCode swingForwardKey;
    public KeyCode swingBackwardKey;
    public KeyCode getOffSwing;
    // Add a max and min swing length so the player and swing can't go too far
    public float maxSwingLength = 1f;
    public float minSwingLength = -5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnSwing)
        {
            // Swinging mechanics
            if (Input.GetKey(swingForwardKey))
            {
                SwingAccelerationSpeed += SwingAcceleration * Time.deltaTime;
                swingSpeed = Mathf.Clamp(MaxSwingSpeed, 0f, SwingAccelerationSpeed);
            }
            else if (Input.GetKey(swingBackwardKey))
            {
                SwingDecelerationSpeed += SwingDeceleration * Time.deltaTime;
                swingSpeed = Mathf.Clamp(-MaxSwingSpeed, -SwingDecelerationSpeed, 0f);
            }
            else
            {
                SwingAccelerationSpeed = 0f;
                SwingDecelerationSpeed = 0f;
                swingSpeed = 0f;
            }
            swingAngle += swingSpeed * Time.deltaTime;
            swingAngle = Mathf.Clamp(swingAngle, minSwingAngle, maxSwingAngle);
            // Update player position based on swing angle
            Vector3 offset = new Vector3(Mathf.Sin(swingAngle * Mathf.Deg2Rad), -Mathf.Cos(swingAngle * Mathf.Deg2Rad), 0) * Vector3.Distance(player.transform.position, swingPoint.position);
            player.transform.position = swingPoint.position + offset;
            // Get off the swing
            if (Input.GetKeyDown(getOffSwing))
            {
                isOnSwing = false;
                playerMotor.enabled = true; // Re-enable player motor
            }
            // check swing length
            float currentSwingLength = Vector3.Distance(player.transform.position, swingPoint.position);
            if (currentSwingLength > maxSwingLength)
            {
                Vector3 direction = (player.transform.position - swingPoint.position).normalized;
                player.transform.position = swingPoint.position + direction * maxSwingLength;
            }
            else if (currentSwingLength < minSwingLength)
            {
                Vector3 direction = (player.transform.position - swingPoint.position).normalized;
                player.transform.position = swingPoint.position + direction * minSwingLength;
            }
        }
    }
}
