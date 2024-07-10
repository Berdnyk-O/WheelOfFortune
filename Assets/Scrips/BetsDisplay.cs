using TMPro;
using UnityEngine;

public class BetsDisplay : MonoBehaviour
{
    public BettingManager BettingManager;

    public TMP_Text[] XText = new TMP_Text[5];

    void Update()
    {
        for (int i = 0; i < BettingManager.MultipliersBetting.Count; i++)
        {
            XText[i].text = BettingManager.MultipliersBetting[i + 1].ToString();
        }
    }
}
