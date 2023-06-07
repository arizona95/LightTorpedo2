using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpendoMove : MonoBehaviour
{
    Rigidbody rigid;
    public int torpendoSpeed = 200;
    float timer;
    // Start is called before the first frame update


    void Awake()
    {
        timer = 0;
        rigid = GetComponent<Rigidbody>();
        rigid.AddForce(transform.forward * 100000);
    }



    // Update is called once per frame
    void Update()
    {

        if (timer > 30)
        {
            gameObject.SetActive(false);
            GameObject.Find("SceneManager").GetComponent<CameraChooser>().SelectCamera("q");
        }

        if (timer < 10)
        {
            rigid.AddForce(transform.forward * torpendoSpeed);
        }
        else
        {
            rigid.AddForce(transform.forward * torpendoSpeed);
            //rigid.AddForce(transform.right*200);
            transform.Rotate(Vector3.up * 20 * Time.deltaTime);
        }
        
        timer += Time.deltaTime;
    }
}
