using UnityEngine;

public class Puzzle1Door : MonoBehaviour
{
    public GameObject door, item1, item2, item3, item4;
    public Animator doorAnimator;
    public AudioSource doorOpenSound, keyPadSound;
    public bool isDoorOpen = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (item1.activeSelf == true && item2.activeSelf == true && item3.activeSelf == true && item4.activeSelf == true)
        {
            doorAnimator.SetBool("Open", true);
            if (!isDoorOpen)
            {
                doorOpenSound.Play();
                keyPadSound.Play();
                isDoorOpen = true;
            }
        }
        else if (item1.activeSelf == false || item2.activeSelf == false || item3.activeSelf == false || item4.activeSelf == false)
        {
            doorAnimator.SetBool("Open", false);
        }
    }
}
