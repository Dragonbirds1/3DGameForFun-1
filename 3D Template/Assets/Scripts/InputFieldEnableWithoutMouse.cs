using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldEnableWithoutMouse : MonoBehaviour
{
    /// <summary>
    /// This script enables an input field to be focused and edited without using the mouse.
    /// 
    /// </summary>
    
    public PlayerMotor playerMotor;
    public Pistol pistol;
    public InputField inputField;
    public KeyCode activationKey;
    public KeyCode deactivationKey;
    public bool isInputFieldActive = false;
    public BoomBox boomBox;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boomBox.isActive == true)
        {
            if (Input.GetKey(activationKey))
            {
                inputField.ActivateInputField();
                playerMotor.speed = 0f; // Stop player movement when input field is active
                playerMotor.jumpHeight = 0f; // Disable jumping when input field is active
                pistol.isFocusing = false;
                pistol.canShoot = false;
                pistol.canReload = false;
                pistol.canFocus = false;
            }

            if (!inputField.isFocused)
            {
                inputField.DeactivateInputField();
                playerMotor.speed = 5f; // Restore player movement speed
                playerMotor.jumpHeight = 1f; // Restore jumping ability
                pistol.canShoot = true;
                pistol.canReload = true;
                pistol.canFocus = true;
            }
        }
        else if (boomBox.isActive == false)
        {
            return;
        }
    }
}
