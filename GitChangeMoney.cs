using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GitChangeMoney : MonoBehaviour
{
    public static GitChangeMoney money;

    private int totalMoney;
    private TextMeshProUGUI moneyText;



    private void Awake()
    {
        if (money == null)
        {
            money = this;
        }

    }

    private void Start()
    {
        moneyText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    public void AddMoney(int moneyAdded)
    {
        moneyText.text = "";
        totalMoney += moneyAdded;
        moneyText.text += totalMoney.ToString();
    }
}
