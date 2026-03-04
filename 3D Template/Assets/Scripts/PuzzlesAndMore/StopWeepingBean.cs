using UnityEngine;

public class StopWeepingBean : MonoBehaviour
{
    public WeepingBeanChase weepingBeanChase;
    public GameObject weepingBean;
    public Animator doorAnim;
    public bool startTimer = false;
    public float timer;

    private MeshRenderer meshRenderer;
    private BoxCollider boxCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        boxCollider = GetComponent<BoxCollider>();

        meshRenderer.enabled = false;
        boxCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        startTimer = doorAnim.GetBool("CloseGate");
        if (startTimer == true)
        {
            timer += Time.deltaTime;
            if (timer >= 2)
            {
                meshRenderer.enabled = true;
                boxCollider.enabled = true;
                startTimer = false;
                timer = 0;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            weepingBean.SetActive(false);
            weepingBeanChase.enabled = false;
            
            meshRenderer.enabled = false;
            boxCollider.enabled = false;
        }
    }
}
