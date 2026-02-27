using UnityEngine;

public class RedLightGreenLight : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private BoxCollider boxCollider;

    public PlayerMotor playerMotor;

    public PlayerHealth playerHealth;

    public bool startGame = false;

    public bool isRedLight = false;

    public bool isGreenLight = false;

    public bool isGameStarted = false;

    public bool winGame = false;

    public float delayBeforeCheckingPlayerMovement = 0.35f; // Delay in seconds before checking player movement after switching to red light

    public float timeTillRedLight;

    public float timeTillGreenLight;

    public float looseHealthAmount;

    public Light light1, light2, light3, light4;

    public GameObject light1Mat, light2Mat, light3Mat, light4Mat;

    public Material redMat, greenMat, normalMat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        boxCollider = GetComponent<BoxCollider>();
        timeTillRedLight = Random.Range(1f, 5f);
        timeTillGreenLight = Random.Range(1f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (startGame)
        {
            if (isGameStarted == false)
            {
                light1.color = Color.green;
                light2.color = Color.green;
                light3.color = Color.green;
                light4.color = Color.green;
                light1Mat.GetComponent<MeshRenderer>().material = greenMat;
                light2Mat.GetComponent<MeshRenderer>().material = greenMat;
                light3Mat.GetComponent<MeshRenderer>().material = greenMat;
                light4Mat.GetComponent<MeshRenderer>().material = greenMat;
                isGreenLight = true; // Set the initial state to green light
                isGameStarted = true;
                playerMotor.canSprint = false; // Disable sprinting at the start of the game
            }
            // Game logic for Red Light Green Light can be implemented here
            if (isGreenLight == true)
            {
                timeTillRedLight -= Time.deltaTime;
                if (timeTillRedLight <= 0)
                {
                    // Switch between red light and green light
                    light1.color = Color.red;
                    light2.color = Color.red;
                    light3.color = Color.red;
                    light4.color = Color.red;
                    light1Mat.GetComponent<MeshRenderer>().material = redMat;
                    light2Mat.GetComponent<MeshRenderer>().material = redMat;
                    light3Mat.GetComponent<MeshRenderer>().material = redMat;
                    light4Mat.GetComponent<MeshRenderer>().material = redMat;
                    // For example, you can toggle a boolean to indicate the current state
                    
                    // and reset the timer for the next switch
                    timeTillRedLight = Random.Range(1, 5); // Reset timer for next switch
                    isRedLight = true;
                    isGreenLight = false;
                }
            }

            if (isRedLight == true) 
            {
                delayBeforeCheckingPlayerMovement -= Time.deltaTime;
                if (delayBeforeCheckingPlayerMovement <= 0)
                {
                    delayBeforeCheckingPlayerMovement = 0; // Ensure the delay does not go below zero
                    if (playerMotor.currentSpeed > 0f)
                    {
                        // Player is moving during red light, you can implement logic to handle this case (e.g., reset player position, end game, etc.)
                        playerHealth.health -= looseHealthAmount;
                        Debug.Log("Player moved during red light!");
                    }
                    timeTillGreenLight -= Time.deltaTime;
                    if (timeTillGreenLight <= 0)
                    {
                        light1.color = Color.green;
                        light2.color = Color.green;
                        light3.color = Color.green;
                        light4.color = Color.green;
                        light1Mat.GetComponent<MeshRenderer>().material = greenMat;
                        light2Mat.GetComponent<MeshRenderer>().material = greenMat;
                        light3Mat.GetComponent<MeshRenderer>().material = greenMat;
                        light4Mat.GetComponent<MeshRenderer>().material = greenMat;
                        timeTillGreenLight = Random.Range(1, 5); // Reset timer for next switch
                        isRedLight = false;
                        isGreenLight = true;
                        delayBeforeCheckingPlayerMovement = 0.35f; // Reset the delay for checking player movement after switching to green light
                    }
                }
            }
        }
        if (winGame)
        {
            startGame = false;
            playerMotor.canSprint = true;
            light1.color = Color.white;
            light2.color = Color.white;
            light3.color = Color.white;
            light4.color = Color.white;
            light1Mat.GetComponent<MeshRenderer>().material = normalMat;
            light2Mat.GetComponent<MeshRenderer>().material = normalMat;
            light3Mat.GetComponent<MeshRenderer>().material = normalMat;
            light4Mat.GetComponent<MeshRenderer>().material = normalMat;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            meshRenderer.enabled = false;
            boxCollider.enabled = false;
            startGame = true;
        }
    }
}

