using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public KeyCode flashKey;
    public GameObject flashlight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(flashKey))
        {
            flashlight.SetActive(!flashlight.activeSelf);
        }
    }
}
