using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class player : MonoBehaviour
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
    int damage = 0;

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
        GameObject[] team2 = GameObject.FindGameObjectsWithTag("team2");
        foreach(GameObject target in team2)
        {
            float distance2 = Vector3.Distance(target.transform.position, transform.position);
            if(distance2 < 2.0f)
            {
                damage = damage + 1;
                Debug.Log(damage);
                if (damage > 1000)
                 {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }
    }
}