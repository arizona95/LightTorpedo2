using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineAI : MonoBehaviour
{
    BoatAlignNormal Submarine;

    // 0 : �������
    // 1 : ���̴� ��������
    // 2 : ����Ž������ - Mk 6 ������ ��Ŀ �߻�
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
                // ��� ����
                resetMove();
                Submarine._bottomH = 5;
                Submarine._throttleBias = 0.8f;
                Submarine._steerBias = 0.2f;
                break;
            
            case 1:
                //ȸ�Ǳ⵿1 : �ӵ� 5�� �þ
                resetMove();
                Submarine._bottomH = 5;
                Submarine._throttleBias = 4f;
                Submarine._steerBias = 1f;
                break;
        }
    }
}
