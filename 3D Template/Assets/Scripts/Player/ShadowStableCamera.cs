using UnityEngine;

public class ShadowStableCamera : MonoBehaviour
{
    public float snapSize = 0.02f; // try 0.01 – 0.05

    void LateUpdate()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Round(pos.x / snapSize) * snapSize;
        pos.z = Mathf.Round(pos.z / snapSize) * snapSize;

        transform.position = pos;
    }
}