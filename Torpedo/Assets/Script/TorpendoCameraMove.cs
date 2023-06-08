using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpendoCameraMove : MonoBehaviour
{
    public Transform camTarget;
    public float pLerp = 0f;
    public float rLerp = 0.1f;

    float offset;
    Quaternion offsetPosition;
    Quaternion offsetRotation;
    float time;


    // Start is called before the first frame update
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.Lerp(transform.position , camTarget.position , pLerp);
       transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation, rLerp);
        time += Time.deltaTime;

        if (time < 1) pLerp = 0.1f;
        else if (time < 3) pLerp = 0.5f;
        else pLerp = 1f;
    }
}
