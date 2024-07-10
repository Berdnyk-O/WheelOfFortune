using TMPro;
using UnityEngine;

public class ReserveDisplay : MonoBehaviour
{
    [SerializeField] 
    public BettingManager BettingManager;
    
    [SerializeField]
    public TMP_Text MoneyText;

    void Update()
    {
        MoneyText.text = BettingManager.money.ToString();
    }
}
