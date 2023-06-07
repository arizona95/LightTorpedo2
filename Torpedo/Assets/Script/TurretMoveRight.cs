using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMoveRight : MonoBehaviour
{
    BoatAlignNormal BattleShip;
    CameraChooser CameraChooser;

    bool FocusMe = false;

    // Start is called before the first frame update
    void Awake()
    {
        BattleShip = GameObject.Find("BoatAlignNormalPlayer").GetComponent<BoatAlignNormal>();
        CameraChooser = GameObject.Find("SceneManager").GetComponent<CameraChooser>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (CameraChooser.nowCameraNum != "r")
            {
                CameraChooser.SelectCamera("r");
                FocusMe = true;
                BattleShip._playerControlled = false;
                return;
            }
            else
            {
                CameraChooser.SelectCamera("q");
                FocusMe = false;
                BattleShip._playerControlled = true;
            }

        }

        if (FocusMe == true)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {

                if (transform.eulerAngles.y < 270 ){
                    transform.Rotate(new Vector3(0, 1, 0));
                }

            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (transform.eulerAngles.y > 150)
                {
                    transform.Rotate(new Vector3(0, -1, 0));
                }
            }
        }
    }
}
