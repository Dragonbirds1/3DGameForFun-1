using UnityEngine;
using UnityEngine.UI;

public class MoveIfLookingAt : MonoBehaviour
{
    public GameObject player;
    private Camera playerCam;
    public LayerMask weepingBeanLayerMask;
    public float distance;
    public WeepingBean weepingBean;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCam = GetComponent<PlayerLook>().cam;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(playerCam.transform.position, playerCam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance, Color.red);

        RaycastHit hit;

        // Cast without layer mask so it hits walls too
        if (Physics.Raycast(ray, out hit, distance))
        {
            // If the FIRST thing we hit is the weeping bean
            if (((1 << hit.collider.gameObject.layer) & weepingBeanLayerMask) != 0)
            {
                Debug.Log("Hit Weeping Bean (not blocked)");
                weepingBean.canMove = false;
            }
            else
            {
                // Something else (like a wall) is in front
                weepingBean.canMove = true;
            }
        }
        else
        {
            weepingBean.canMove = true;
        }
    }
}
