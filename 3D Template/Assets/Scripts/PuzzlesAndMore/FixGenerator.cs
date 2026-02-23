using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;
using UnityEngine.UI;

public class FixGenerator : MonoBehaviour
{
    /// <summary>
    /// This script will be used to fix the generator after it has been destroyed. It will be used to reset the generator's health and turn off the smoke and lights.
    /// </summary>
    
    public GeneratorHealth generatorHealth;
    public float fixTime;
    public float maxFixTime = 10f;
    private bool isFixing = false;
    public float fixRange;
    public GameObject player;
    public KeyCode fixKey;
    public Slider fixSlider;
    public GameObject slider;
    public bool song1Playing;
    public bool song2Playing;
    public bool song3Playing;
    public bool song4Playing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        float distance = Vector3.Distance(transform.position, playerPos);
        fixSlider.value = fixTime;
        
        if (isFixing == true)
        {
            fixTime += Time.deltaTime;
            if (fixTime >= maxFixTime)
            {
                slider.SetActive(false);
                fixTime = maxFixTime;
                generatorHealth.health = generatorHealth.maxHealth;
                generatorHealth.isDestroyed = false;
                generatorHealth.roundLight.GetComponent<MeshRenderer>().material = generatorHealth.notDamaged;
                generatorHealth.Light1.enabled = true;
                generatorHealth.Light2.enabled = true;
                generatorHealth.Light3.enabled = true;
                generatorHealth.Light4.enabled = true;
                generatorHealth.Light5.enabled = true;
                generatorHealth.Light6.enabled = true;
                generatorHealth.Light7.enabled = true;
                generatorHealth.Light8.enabled = true;
                generatorHealth.Light9.enabled = true;
                generatorHealth.mainLight1.GetComponent<MeshRenderer>().material = generatorHealth.lightOnMat;
                generatorHealth.mainLight2.GetComponent<MeshRenderer>().material = generatorHealth.lightOnMat;
                generatorHealth.mainLight3.GetComponent<MeshRenderer>().material = generatorHealth.lightOnMat;
                generatorHealth.mainLight4.GetComponent<MeshRenderer>().material = generatorHealth.lightOnMat;
                generatorHealth.mainLight5.GetComponent<MeshRenderer>().material = generatorHealth.lightOnMat;
                generatorHealth.mainLight6.GetComponent<MeshRenderer>().material = generatorHealth.lightOnMat;
                generatorHealth.mainLight7.GetComponent<MeshRenderer>().material = generatorHealth.lightOnMat;
                generatorHealth.mainLight8.GetComponent<MeshRenderer>().material = generatorHealth.lightOnMat;
                generatorHealth.mainLight9.GetComponent<MeshRenderer>().material = generatorHealth.lightOnMat;
                generatorHealth.keypad1.canInteract = true;
                generatorHealth.keypad2.canInteract = true;
                generatorHealth.keypad1.door.GetComponent<Animator>().SetBool("IsOpen", generatorHealth.keypad1.doorOpen);
                generatorHealth.keypad1.fnafDoor.Play();
                generatorHealth.powerRestored.Play();
                generatorHealth.boomBox.canInteract = true;
                generatorHealth.light1Button.canInteract = true;
                generatorHealth.light2Button.canInteract = true;
                generatorHealth.light3Button.canInteract = true;
                generatorHealth.light4Button.canInteract = true;
                generatorHealth.selectPopUp.canInteract = true;
                foreach (Light light in generatorHealth.hereIsAListForTheLightsBecuaseThereAreSoManyLights)
                {
                    light.enabled = true;
                }
                foreach (GameObject gameObject in generatorHealth.hereIsAListForTheGameObjectsBecuaseThereAreSoManyGameObjects)
                {
                    gameObject.GetComponent<MeshRenderer>().material = generatorHealth.lightOnMat;
                }
                if (song1Playing == true)
                {
                    generatorHealth.Song1.Play();
                    generatorHealth.Song2.Stop();
                    generatorHealth.Song3.Stop();
                    generatorHealth.Song4.Stop();
                }
                else if (song2Playing == true)
                {
                    generatorHealth.Song2.Play();
                    generatorHealth.Song3.Stop();
                    generatorHealth.Song4.Stop();
                    generatorHealth.Song1.Stop();
                }
                else if (song3Playing == true)
                {
                    generatorHealth.Song3.Play();
                    generatorHealth.Song4.Stop();
                    generatorHealth.Song1.Stop();
                    generatorHealth.Song2.Stop();
                }
                else if (song4Playing == true)
                {
                    generatorHealth.Song4.Play();
                    generatorHealth.Song1.Stop();
                    generatorHealth.Song2.Stop();
                    generatorHealth.Song3.Stop();
                }
                isFixing = false;
            }
        }
        else if (isFixing == false)
        {
            fixTime -= Time.deltaTime;
            if (fixTime <= 0)
            {
                fixTime = 0;
            }
        }
        if (generatorHealth.isDestroyed == true)
        {
            if (distance <= fixRange)
            {
                slider.SetActive(true);
                if (Input.GetKey(fixKey))
                {
                    isFixing = true;
                }
                else
                {
                    isFixing = false;
                }
            }
            else
            {
                slider.SetActive(false);
            }
        }
    }

    public void Song1IsPlaying()
    {
        song1Playing = true;
        song2Playing = false;
        song3Playing = false;
        song4Playing = false;
    }

    public void Song2IsPlaying()
    {
        song1Playing = false;
        song2Playing = true;
        song3Playing = false;
        song4Playing = false;
    }

    public void Song3IsPlaying()
    {
        song1Playing = false;
        song2Playing = false;
        song3Playing = true;
        song4Playing = false;
    }

    public void Song4IsPlaying()
    {
        song1Playing = false;
        song2Playing = false;
        song3Playing = false;
        song4Playing = true;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, fixRange);
    }
}
