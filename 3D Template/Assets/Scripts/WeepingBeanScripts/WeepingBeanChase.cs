using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class WeepingBeanChase : MonoBehaviour
{
    // Track which waypoint we are currently targeting.
    public List<Transform> waypoints;
    public int waypointIndex;
    public float waitTimer;
    public Animator gateAnimator;
    public NavMeshAgent agent;
    public GameObject weepingBean;
    public bool isGateClosed = false;
    [SerializeField]
    private bool alwaysDrawPath;
    [SerializeField]
    private bool drawAsLoop;
    [SerializeField]
    private bool drawNumbers;
    public Color debugColour = Color.white;


    public void Start()
    {
        
    }

    public void Update()
    {
        PatrolCycle();
        isGateClosed = gateAnimator.GetBool("CloseGate");
        if (isGateClosed == true)
        {
            agent.speed = 30;
        }
    }

    public void PatrolCycle()
    {
        // Implement our patrol logic.
        if (weepingBean != null)
        {
            if (agent.remainingDistance < 0.2f)
            {
                //waitTimer += Time.deltaTime;
                //if (waitTimer > 3)
                //{
                    if (waypointIndex < waypoints.Count - 1)
                        waypointIndex++;
                    else
                        return;
                    agent.SetDestination(waypoints[waypointIndex].position);
                    //waitTimer = 0;
                //}
            }
        }
        else if (weepingBean == null)
        {
            Debug.Log("Enemy Is Dead");
        }
    }

    public void OnDrawGizmos()
    {
        if (alwaysDrawPath)
        {
            DrawPath();
        }
    }

    public void DrawPath()
    {
        for (int i = 0; i < waypoints.Count; i++)
        {
            GUIStyle labelStyle = new GUIStyle();
            labelStyle.fontSize = 30;
            labelStyle.normal.textColor = debugColour;
            if (drawNumbers)
                Handles.Label(waypoints[i].position, i.ToString(), labelStyle);
            //Draw Lines Between Points.
            if (i >= 1)
            {
                Gizmos.color = debugColour;
                Gizmos.DrawLine(waypoints[i - 1].position, waypoints[i].position);

                if (drawAsLoop)
                    Gizmos.DrawLine(waypoints[waypoints.Count - 1].position, waypoints[0].position);

            }
        }
    }

    public void OnDrawGizmosSelected()
    {
        if (alwaysDrawPath)
            return;
        else
            DrawPath();
    }
}