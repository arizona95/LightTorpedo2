using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineAI : MonoBehaviour
{
    BoatAlignNormal Submarine;

    // 0 : 정상상태
    // 1 : 레이더 인지상태
    // 2 : 음향탐지방해 - Mk 6 노이즈 마커 발사
    int actionState = 0;

    // Start is called before the first frame update
    void Awake()
    {
        Submarine = GetComponent<BoatAlignNormal>();
    }

    void resetMove()
    {
        Submarine._bottomH = 5;
        Submarine._throttleBias = 0f;
        Submarine._steerBias = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        switch (actionState) {
            case 0:
                // 평소 상태
                resetMove();
                Submarine._bottomH = 5;
                Submarine._throttleBias = 0.8f;
                Submarine._steerBias = 0.2f;
                break;
            
            case 1:
                //회피기동1 : 속도 5배 늘어남
                resetMove();
                Submarine._bottomH = 5;
                Submarine._throttleBias = 4f;
                Submarine._steerBias = 1f;
                break;
        }
    }
}
