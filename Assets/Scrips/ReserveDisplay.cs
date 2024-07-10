using TMPro;
using UnityEngine;

public class ReserveDisplay : MonoBehaviour
{
    public BettingManager BettingManager;
    
    public TMP_Text MoneyText;

    void Update()
    {
        MoneyText.text = BettingManager.Money.ToString();
    }
}
