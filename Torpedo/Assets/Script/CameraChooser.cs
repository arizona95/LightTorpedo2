using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraChooser : MonoBehaviour
{
    public string nowCameraNum = "q";
    // Start is called before the first frame update
    GameObject ShipCamera;
    GameObject ShipOverCamera;
    GameObject SubmarineCamera;
    GameObject SubmarineOverCamera;
    GameObject RightUpTurretCamera;
    GameObject Torpendo1Camera1;
    GameObject Torpendo1OverCamera1;
    //GameObject  Torpendo1Camera2; //Input.GetKeyDown("2")

    void Awake()
    {
        ShipCamera = GameObject.Find("BoatScene").transform.Find("DemoCamera").gameObject;
        ShipOverCamera = GameObject.Find("Battleship").transform.Find("OverCamera").gameObject;
        SubmarineCamera = GameObject.Find("Submarine").transform.Find("Camtarget").transform.Find("Camera").gameObject;
        SubmarineOverCamera = GameObject.Find("Submarine").transform.Find("OverCamera").gameObject;
        RightUpTurretCamera = GameObject.Find("RightUpTurret").transform.Find("Camtarget").transform.Find("Camera").gameObject;
        Torpendo1Camera1 = GameObject.Find("Torpendo").transform.Find("Torpendo1").transform.Find("Camtarget").transform.Find("Camera").gameObject;
        Torpendo1OverCamera1 = GameObject.Find("Torpendo").transform.Find("Torpendo1").transform.Find("OverCamera").gameObject;

    }

    void DisableAllCamera()
    {
        ShipOverCamera.SetActive(false);
        ShipCamera.SetActive(false);
        SubmarineCamera.SetActive(false);
        SubmarineOverCamera.SetActive(false);
        RightUpTurretCamera.SetActive(false);
        Torpendo1Camera1.SetActive(false);
        Torpendo1OverCamera1.SetActive(false);
    }

    public void SelectCamera(string select)
    {
        switch(select)
        {
            case "q":
                DisableAllCamera();
                nowCameraNum = "q";
                ShipCamera.SetActive(true);
                break;

            case "qq":
                DisableAllCamera();
                nowCameraNum = "qq";
                ShipOverCamera.SetActive(true);
                break;

            case "w":
                DisableAllCamera();
                nowCameraNum = "w";
                SubmarineCamera.SetActive(true);
                break;

            case "ww":
                DisableAllCamera();
                nowCameraNum = "ww";
                SubmarineOverCamera.SetActive(true);
                break;

            case "r":
                DisableAllCamera();
                nowCameraNum = "r";
                RightUpTurretCamera.SetActive(true);
                break;

            case "1":
                DisableAllCamera();
                nowCameraNum = "1";
                Torpendo1Camera1.SetActive(true);
                break;

            case "11":
                DisableAllCamera();
                nowCameraNum = "11";
                Torpendo1OverCamera1.SetActive(true);
                break;

            default:
                Debug.Log("no camera");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {
            if (nowCameraNum != "q") {
                SelectCamera("q");
            }else{
                SelectCamera("qq");
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (nowCameraNum != "w")
            {
                SelectCamera("w");
            }
            else
            {
                SelectCamera("ww");
            }
        }


        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            if (nowCameraNum != "1")
            {
                SelectCamera("1");
            }
            else
            {
                SelectCamera("11");
            }
        }


        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
