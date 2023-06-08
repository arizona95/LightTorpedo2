using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpendoMove : MonoBehaviour
{
    Rigidbody rigid;
    public float firstSpeed = 200;
    public float secondSpeed = 200;
    public float roundSpeed = 10;
    float timer;
    public GameObject newParent;
    public GameObject objectToMove;
    // Start is called before the first frame update


    void Awake()
    {
        timer = 0;
        rigid = GetComponent<Rigidbody>();
        objectToMove.transform.SetParent(newParent.transform);
    }




    // Update is called once per frame
    void Update()
    {
        if (timer >=0 && timer < 0.1)
        {

            rigid.AddForce(transform.up * firstSpeed * Time.deltaTime);
        }
        else if(timer >= 0.1 && timer < 10)
        {
            rigid.AddForce(transform.up * secondSpeed * Time.deltaTime);
        }
        else if (timer >= 10 && timer <300)
        {
            rigid.AddForce(transform.up * secondSpeed * Time.deltaTime);
            //rigid.AddForce(transform.right*2000);
           
            transform.Rotate(Vector3.forward * roundSpeed * Time.deltaTime);
        }
        else if (timer > 300)
        {
            gameObject.SetActive(false);
            GameObject.Find("SceneManager").GetComponent<CameraChooser>().SelectCamera("q");
        }

        
        
        timer += Time.deltaTime;
    }
}
