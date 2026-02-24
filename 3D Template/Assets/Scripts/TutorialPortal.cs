using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class TutorialPortal : MonoBehaviour
{
    public GameObject tutorialPortal;
    public GameObject block;
    public AudioSource tutorialSound;
    public AudioClip tutorialSoundClip;
    public bool tutorialEnabled;
    private BoxCollider boxCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tutorialSound.PlayOneShot(tutorialSoundClip, 1.5f);
            if (tutorialEnabled == false)
            {
                Destroy(tutorialPortal);
                StartCoroutine(WaitForAudioToFinish());
            }
            else if (tutorialEnabled == true)
            {
                boxCollider.enabled = false;
                StartCoroutine(WaitForAudioToFinish());
            }
        }
    }

    IEnumerator WaitForAudioToFinish()
    {
        yield return new WaitForSeconds(tutorialSoundClip.length);
        if (block != null)
        {
            Destroy(block);
        }
        else if (block == null)
        {
            Debug.Log("No block to destroy.");
        }
    }
}
