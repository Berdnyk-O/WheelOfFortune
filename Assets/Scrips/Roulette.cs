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
        if (genSpeed <= 0)
        {
            genSpeed = 0;
            isSpinning = false;
        }
    }

    public void Spin()
    {
        genSpeed = Random.Range(2.000f, 5.000f);
        subSpeed = Random.Range(0.003f, 0.009f);
        isSpinning = true;
    }
}
