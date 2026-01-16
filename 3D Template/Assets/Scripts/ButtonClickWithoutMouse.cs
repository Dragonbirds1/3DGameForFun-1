using UnityEngine;
using UnityEngine.UI;

public class ButtonClickWithoutMouse : MonoBehaviour
{
    /// <summary>
    /// This script is intended to handle button clicks without using the mouse.
    /// </summary>
    
    public KeyCode activationKey;
    public Button button;
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

            if (Input.GetKeyDown(activationKey))
            {
                button.onClick.Invoke();
            }
        }
        else if (boomBox.isActive == false)
        {
            return;
        }
    }
}
