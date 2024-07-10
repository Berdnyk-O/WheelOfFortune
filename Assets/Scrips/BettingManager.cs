using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;

public class BettingManager : MonoBehaviour
{
    public int Money;

    private int _selectedChip;

    private Dictionary<int, int> _multipliersBetting;
    public Dictionary<int, int> MultipliersBetting { get => _multipliersBetting; }

    void Start()
    {
        Money = 200;
        _selectedChip = 0;
        _multipliersBetting = new Dictionary<int, int>()
        {
            { 1,0 },
            { 2,0 },
            { 3,0 },
            { 4,0 },
            { 5,0 },
        };

    }

    public void SelectChip(Toggle chip)
    {
        if(chip.isOn)
        {
            _selectedChip = int.Parse(chip.name.Substring(4));
        }
        else 
        {
            _selectedChip = 0;
        }
    }

    public void PlaceBet(int multiplier)
    {
        var bet = Money - _selectedChip;
        if(bet >= 0)
        {
            MultipliersBetting[multiplier] += _selectedChip;
            Money = bet;
        }
    }

    public void CalculateWinnings(int resultingMultiplier)
    {
        Money += MultipliersBetting[resultingMultiplier] * resultingMultiplier;
        ResetBets();
    }

    public void ResetBets()
    {
        _multipliersBetting[1] = 0;
        _multipliersBetting[2] = 0;
        _multipliersBetting[3] = 0;
        _multipliersBetting[4] = 0;
        _multipliersBetting[5] = 0;
    }
}
