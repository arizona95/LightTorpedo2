using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;


public class CollisionAction : MonoBehaviour
{
    AudioSource audio;
    public bool clear = false;
    float timer;
    // Start is called before the first frame update
    void Awake()
    {
        timer = 0;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(clear == true) timer += Time.deltaTime;

        if (timer >1) SceneManager.LoadScene(1);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Torpendo")
        {
            audio = GetComponent<AudioSource>();
            audio.Play();
            clear = true;
        }
    }
}
