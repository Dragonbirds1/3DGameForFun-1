using UnityEngine;

public class GeneratorPowerOutTurorial : MonoBehaviour
{
    public GeneratorHealth generatorHealth;
    public GameObject powerOutTutorial;
    public bool tutorialActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        powerOutTutorial.SetActive(false);
        tutorialActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (generatorHealth.health == 0 && tutorialActive == false)
        {
            powerOutTutorial.SetActive(true);
            tutorialActive = true;
        }
    }
}
