using UnityEngine;

public class WeepingBean : MonoBehaviour
{
    public GameObject weepingBean;
    public GameObject player;
    public bool canMove;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        weepingBean.transform.LookAt(player.transform.position);
        if (canMove == true)
        {
            weepingBean.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.1f);
        }
        else if (canMove == false)
        {
            weepingBean.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0f);
        }
    }
}
