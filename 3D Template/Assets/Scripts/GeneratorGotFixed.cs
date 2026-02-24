using UnityEngine;

public class GeneratorGotFixed : MonoBehaviour
{
    public FixGenerator fixGenerator;
    public GameObject GameObjectToEnable;
    public bool isEnabled;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObjectToEnable.SetActive(false);
        isEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (fixGenerator.fixTime >= fixGenerator.maxFixTime && isEnabled == false)
        {
            GameObjectToEnable.SetActive(true);
            isEnabled = true;
        }
    }
}
