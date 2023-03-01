using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mg1_script : MonoBehaviour
{
    Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float number_of_rays = 500;
        float totalAngle = 360;

        float delta = totalAngle / number_of_rays;
        Vector3 pos = transform.position;
        const float magnitude = 5;
    }
    
}