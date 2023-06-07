using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpendoShot : MonoBehaviour
{
    bool[] TorpendoLoad = new bool[] { false, true, true, true, true, true, true };

    // Start is called before the first frame update
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad1) && TorpendoLoad[1] == true)
        {
            GameObject.Find("Torpendo").transform.Find("Torpendo1").gameObject.SetActive(true);
            GameObject.Find("SceneManager").GetComponent<CameraChooser>().SelectCamera("1");
            TorpendoLoad[1] = false;
        }

    }
}
