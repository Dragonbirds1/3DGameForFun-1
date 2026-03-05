using UnityEngine;

public class GeneratorHealth : MonoBehaviour
{
    [Header("Pistol Script")]
    public Pistol pistol;

    [Header("Keypad1, Keypad2 Scripts")]
    public Keypad keypad1;
    public Keypad2 keypad2;

    [Header("Boombox Script")]
    public BoomBox boomBox;

    [Header("Breaker Switch 1, 2, 3, 4 Scripts")]
    public Light1Button light1Button;
    public Light2Button light2Button;
    public Light3Button light3Button;
    public Light4Button light4Button;

    [Header("SelectPopUp Script")]
    public SelectPopup selectPopUp;

    [Header("Health Settings")]
    public int maxHealth = 20;
    public int currentHealth;
    public int health;

    [Header("GameObjects")]
    public GameObject generator, mainLight1, mainLight2, mainLight3, mainLight4, mainLight5, mainLight6, mainLight7, mainLight8, mainLight9, smoke10Hp, smoke5Hp1, smoke5Hp2, smoke5Hp3, smoke5Hp4, smoke5Hp5, roundLight;
    public GameObject[] hereIsAListForTheGameObjectsBecuaseThereAreSoManyGameObjects;

    [Header("Lights")]
    public Light Light1, Light2, Light3, Light4, Light5, Light6, Light7, Light8, Light9;
    public Light[] hereIsAListForTheLightsBecuaseThereAreSoManyLights;

    [Header("Mats")]
    public Material lightOnMat, lightOffMat, notDamaged, damaged;

    [Header("Bools")]
    public bool isDestroyed = false;

    [Header("Audio")]
    public AudioSource powerOutage;
    public AudioSource powerRestored;
    public AudioSource Song1, Song2, Song3, Song4;
    public AudioSource weepingBeanAudio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        smoke10Hp.SetActive(false);
        smoke5Hp1.SetActive(false);
        smoke5Hp2.SetActive(false);
        smoke5Hp3.SetActive(false);
        smoke5Hp4.SetActive(false);
        smoke5Hp5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 10)
        {
            if (isDestroyed == false)
            {
                smoke10Hp.SetActive(true);
            }
        }
        if (health <= 5)
        {
            if (isDestroyed == false)
            {
                smoke5Hp1.SetActive(true);
                smoke5Hp2.SetActive(true);
                smoke5Hp3.SetActive(true);
                smoke5Hp4.SetActive(true);
                smoke5Hp5.SetActive(true);
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            if (health > 0)
            {
                health -= pistol.damage;
            }
            Debug.Log("Generator Health: " + health);
            if (health == 0 && isDestroyed == false)
            {
                health = 0;
                Light1.enabled = false;
                Light2.enabled = false;
                Light3.enabled = false;
                Light4.enabled = false;
                Light5.enabled = false;
                Light6.enabled = false;
                Light7.enabled = false;
                Light8.enabled = false;
                Light9.enabled = false;
                foreach (Light light in hereIsAListForTheLightsBecuaseThereAreSoManyLights)
                {
                    light.enabled = false;
                }
                foreach (GameObject gameObject in hereIsAListForTheGameObjectsBecuaseThereAreSoManyGameObjects)
                {
                    gameObject.GetComponent<MeshRenderer>().material = lightOffMat;
                }
                mainLight1.GetComponent<MeshRenderer>().material = lightOffMat;
                mainLight2.GetComponent<MeshRenderer>().material = lightOffMat;
                mainLight3.GetComponent<MeshRenderer>().material = lightOffMat;
                mainLight4.GetComponent<MeshRenderer>().material = lightOffMat;
                mainLight5.GetComponent<MeshRenderer>().material = lightOffMat;
                mainLight6.GetComponent<MeshRenderer>().material = lightOffMat;
                mainLight7.GetComponent<MeshRenderer>().material = lightOffMat;
                mainLight8.GetComponent<MeshRenderer>().material = lightOffMat;
                mainLight9.GetComponent<MeshRenderer>().material = lightOffMat;
                roundLight.GetComponent<MeshRenderer>().material = damaged;
                keypad1.canInteract = false;
                keypad2.canInteract = false;
                keypad1.door.GetComponent<Animator>().SetBool("IsOpen", true);
                keypad1.fnafDoor.Play();
                powerOutage.Play();
                isDestroyed = true;
                smoke10Hp.SetActive(false);
                smoke5Hp1.SetActive(false);
                smoke5Hp2.SetActive(false);
                smoke5Hp3.SetActive(false);
                smoke5Hp4.SetActive(false);
                smoke5Hp5.SetActive(false);
                Song1.Stop();
                Song2.Stop();
                Song3.Stop();
                Song4.Stop();
                if (weepingBeanAudio != null)
                {
                    weepingBeanAudio.Play();
                }
                else if (weepingBeanAudio == null)
                {
                    Debug.Log("No Audio For This One!");
                }
                boomBox.canInteract = false;
                light1Button.canInteract = false;
                light2Button.canInteract = false;
                light3Button.canInteract = false;
                light4Button.canInteract = false;
                selectPopUp.canInteract = false;
            }
        }

    }
}
