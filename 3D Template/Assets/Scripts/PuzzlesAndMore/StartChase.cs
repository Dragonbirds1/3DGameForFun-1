using UnityEngine;

public class StartChase : MonoBehaviour
{
    /// <summary>
    /// This script will start the weeping bean chase scene.
    /// </summary>

    public WeepingBeanChase weepingBeanChase;
    public GameObject weepingBean;
    public Animator cutscene1;
    public float timer;
    public bool startTimer = false;
    private MeshRenderer meshRenderer;
    private BoxCollider boxCollider;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        boxCollider = GetComponent<BoxCollider>();

        // Turn off the weeping bean at the start.
        weepingBeanChase.enabled = false;
        weepingBean.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer == true)
        {
            timer += Time.deltaTime;
            if (timer >= 4f)
            {
                timer = 0f;
                startTimer = false;
                cutscene1.SetBool("PlayCut", false);
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            startTimer = true;
            cutscene1.SetBool("PlayCut", true);
            weepingBeanChase.enabled = true;
            weepingBean.SetActive(true);
            meshRenderer.enabled = false;
            boxCollider.enabled = false;
        }
    }
}
