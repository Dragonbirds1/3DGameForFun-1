using UnityEngine;

public class BobbleHead : Interactable
{
    [SerializeField]
    private Animator animator;
    public string animationTriggerName = "StartBobble";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    // This function is where we will design our interaction using code.
    protected override void Interact()
    {
        if (animator != null)
        {
            animator.SetTrigger(animationTriggerName);
        }
    }
}
