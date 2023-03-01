using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class team2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    double wait = 0;
    double rate = 0;
    public GameObject objectToSpawn;
    // Update is called once per frame
    void Update()
    {
        rate = rate + 0.05;
        wait = wait + rate;
        if (wait > 100000) {
            Instantiate(objectToSpawn, transform.position, transform.rotation, transform);
            wait = 0;
        }
    }
}
