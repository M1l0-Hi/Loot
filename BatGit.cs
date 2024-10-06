using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatGit : MonoBehaviour
{
    public float health = 3.0f;

    public int enemyMoney;

    public int expGiven;


    private void Update()
    {
        if (health <= 0.0)
        {
            ChangeMoney.money.AddMoney(enemyMoney);
            ProgressBar.expBar.AddExp(expGiven);
            Destroy(gameObject);
        }
    }
}
