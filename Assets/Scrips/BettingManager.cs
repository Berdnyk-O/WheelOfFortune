using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;

public class BettingManager : MonoBehaviour
{
    public int money;
    private int _selectedChip;
    Dictionary<int, int> MultipliersBetting;

    void Start()
    {
        money = 200;
        _selectedChip = 0;
        MultipliersBetting = new Dictionary<int, int>()
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
        var bet = money - _selectedChip;
        if(bet >= 0)
        {

            MultipliersBetting[multiplier] += _selectedChip;  
            money = bet;

            Debug.Log(MultipliersBetting[multiplier]);
        }
    }

    void Update()
    {
        
    }
}
