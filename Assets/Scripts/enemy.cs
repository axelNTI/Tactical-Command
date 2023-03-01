using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class enemy : MonoBehaviour
{
    public Transform target;
    Vector3 destination;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
    }
    // Update is called once per frame
    int damage = 0;
    void Update()
    {
        int allies = 0;
        agent.destination = GameObject.FindGameObjectWithTag("team1").transform.position;
        GameObject[] team1 = GameObject.FindGameObjectsWithTag("team1");
        GameObject[] alliesList = GameObject.FindGameObjectsWithTag("team2");
        foreach(GameObject target in alliesList)
        {
            float distance3 = Vector3.Distance(target.transform.position, agent.destination);
            if(distance3 < 16.0f)
            {
                allies = allies + 1;
            }
        }
        foreach(GameObject target in team1)
        {
            float distance2 = Vector3.Distance(target.transform.position, transform.position);
            if(distance2 < 16.0f)
            {
                damage = damage + (1/allies);
                if (damage > 500)
                {
                    Object.Destroy(this.gameObject);
                }
            }
        }
    }
}
