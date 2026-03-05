using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMainMenu : MonoBehaviour
{
    public KeyCode menuKey = KeyCode.Tab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(menuKey))
        {
            SceneManager.LoadScene("Title");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
