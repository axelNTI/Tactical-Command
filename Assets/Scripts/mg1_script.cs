using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class mg1_script : MonoBehaviour
{
    public Transform target;
    Vector3 destination;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
    }

    public Vector3 screenPosition;
    public Vector3 worldPosition;
    Plane plane = new Plane(Vector3.up, 0);

    void Update()
    {
        screenPosition = Input.mousePosition;
        
        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        if(plane.Raycast(ray, out float distance))
        {
            worldPosition = ray.GetPoint(distance);
        }

        if (Vector3.Distance(destination, target.position) > 1.0f && Input.GetMouseButtonDown(1))
        {
            agent.destination = worldPosition;
        }
    }
}