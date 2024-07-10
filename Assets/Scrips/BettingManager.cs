using UnityEngine;
using UnityEngine.UI;

public class BettingManager : MonoBehaviour
{
    public int money;
    private int _selectedChip;

    void Start()
    {
        money = 200;
        _selectedChip = 0;
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
       
        Debug.Log(_selectedChip);
    }

    public void PlaceBet(int multiplier)
    {

    }

    void Update()
    {
        
    }
}
