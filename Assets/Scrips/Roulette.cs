using UnityEngine;

public class Roulette : MonoBehaviour
{
    public BettingManager BettingManager;

    public float genSpeed;
    public float subSpeed;

    private bool _isSpinning = false;
    public bool IsSpinning => _isSpinning;

    void Update()
    {
        if (_isSpinning)
        {
            transform.Rotate(0, 0, genSpeed, Space.World);
            genSpeed -= subSpeed;
        }
        if (genSpeed <= 0 && _isSpinning)
        {
            genSpeed = 0;
            _isSpinning = false;
            BettingManager.CalculateWinnings(GetMultiplier());
        }
    }

    public void Spin()
    {
        if(!_isSpinning)
        {
            genSpeed = Random.Range(2.000f, 5.000f);
            subSpeed = Random.Range(0.003f, 0.009f);
            _isSpinning = true;
        }
    }

    public int GetMultiplier()
    {
        float rot = transform.eulerAngles.z;

        if ((rot>=332.76 && rot< 334.47)  || 
            (rot>= 57.40 && rot < 77.33) ||
            (rot >= 119.71 && rot < 139.97) ||
            (rot >= 225.68 && rot < 246.99))
        {
            return 1;
        }
        else if((rot >= 334.47 || rot < 16.26) ||
            (rot >= 99.69 && rot < 121.03) ||
            (rot >= 205.65 && rot < 226.86))
        {
            return 2;
        }
        else if ((rot >= 16.26 && rot < 35.47) ||
            (rot >= 78.09 && rot < 99.69) ||
            (rot >= 183.51 && rot < 204.71) ||
            (rot >= 289.79 && rot < 311.14))
        {
            return 3;
        }
        else if ((rot >= 35.47 && rot < 56.13) ||
            (rot >= 139.97 && rot < 161.48) ||
            (rot >= 268.24 && rot < 289.56))
        {
            return 4;
        }
        
        return 5;
    }
}
