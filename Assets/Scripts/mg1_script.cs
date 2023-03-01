using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mg1_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Plane plane = new Plane(Vector3.up, 0);
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
        transform.position = worldPosition;
        //float distance;
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //if (plane.Raycast(ray, out distance))
        //{
        //    worldPosition = ray.GetPoint(distance);
        //}
    }
}