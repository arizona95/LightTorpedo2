using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpendoCameraMove : MonoBehaviour
{
    public Transform camTarget;
    public float pLerp = .02f;
    public float rLerp = .01f;

    float offset;
    Quaternion offsetPosition;
    Quaternion offsetRotation;



    // Start is called before the first frame update
    void Awake()
    {
        //offset = (camTarget.position - transform.position).magnitude;
        //offsetPosition = camTarget.rotation * Quaternion.Inverse(Quaternion.Euler((camTarget.position - transform.position).normalized)); 
        //offsetRotation = camTarget.rotation * Quaternion.Inverse(transform.rotation);
        //Debug.Log(offset);
        //Debug.Log(offsetPosition);
        //Debug.Log(offsetRotation);
    }

    // Update is called once per frame
    void Update()
    {

        //transform.position = camTarget.position - offsetPosition * Quaternion.Inverse(camTarget.rotation)* (Vector3.one *  offset);
        //transform.rotation = camTarget.rotation * Quaternion.Inverse(offsetRotation);


       transform.position = Vector3.Lerp(transform.position , camTarget.position , pLerp);
       transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation, rLerp);
    }
}
