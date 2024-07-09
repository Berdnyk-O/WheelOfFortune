using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    public float genSpeed;
    public float subSpeed;
    public bool isSpinning = false;

    void Update()
    {
        if (isSpinning)
        {
            transform.Rotate(0, 0, genSpeed, Space.World);
            genSpeed -= subSpeed;
        }
        if (genSpeed <= 0 && isSpinning)
        {
            genSpeed = 0;
            isSpinning = false;
            GetMultiplier();
        }
    }

    public void Spin()
    {
        genSpeed = Random.Range(2.000f, 5.000f);
        subSpeed = Random.Range(0.003f, 0.009f);
        isSpinning = true;
    }

    public void GetMultiplier()
    {
        float rot = transform.eulerAngles.z;

        if ((rot>=332.76 && rot< 334.47)  || 
            (rot>= 57.40 && rot < 77.33) ||
            (rot >= 119.71 && rot < 139.97) ||
            (rot >= 225.68 && rot < 246.99))
        {
            Debug.Log(1);
        }
        else if((rot >= 334.47 || rot < 16.26) ||
            (rot >= 99.69 && rot < 121.03) ||
            (rot >= 205.65 && rot < 226.86))
        {
            Debug.Log(2);
        }
        else if ((rot >= 16.26 && rot < 35.47) ||
            (rot >= 78.09 && rot < 99.69) ||
            (rot >= 183.51 && rot < 204.71) ||
            (rot >= 289.79 && rot < 311.14))
        {
            Debug.Log(3);
        }
        else if ((rot >= 35.47 && rot < 56.13) ||
            (rot >= 139.97 && rot < 161.48) ||
            (rot >= 268.24 && rot < 289.56))
        {
            Debug.Log(4);
        }
        else if ((rot >= 161.48 && rot < 183.51) ||
            (rot >= 246.99 && rot < 268.24) ||
            (rot >= 311.14 && rot < 332.76))
        {
            Debug.Log(5);
        }

    }
}
