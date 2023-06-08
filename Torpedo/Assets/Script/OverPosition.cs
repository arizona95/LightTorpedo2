using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverPosition : MonoBehaviour
{
    public Transform target;  // This is the object that the camera will follow
    public float height = 600.0f;  // This is the height above the object

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 newPosition = target.position;
            newPosition.y += height;
            transform.position = newPosition;
        }
    }
}
