using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GitProgressBar : MonoBehaviour
{
    public static GitProgressBar expBar;
    public LevelOS level;


    public int maxium;
    public int current;
    public Image mask;

    public TextMeshProUGUI expText;
    private string start = "EXP: ";

    public TextMeshProUGUI levelText;
    private string levelStart = "LvL: ";

    public GameObject panel;


    private void Awake()
    {
        if (expBar == null)
        {
            expBar = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        levelText.text = "";
        levelText.text += levelStart + "0";
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();

        if (current == maxium)
        {
            current = 0;
            level.PlayerLevel += 1;
            levelText.text = "";
            levelText.text += levelStart + level.PlayerLevel.ToString();
            AddSkillPoints.skillPoints.AddSkills();
        }

        if (level.PlayerLevel - 5 >= 0)
        {
            if (maxium != maxium + (int)level.PlayerLevel / 5)
            {
                maxium += (int)level.PlayerLevel / 5;
            }

        }
        else
        {
            maxium = 10;
        }
    }

    public void GetCurrentFill()
    {
        float fillAmount = (float)current / (float)maxium;
        mask.fillAmount = fillAmount;
        expText.text = "";
        expText.text += start + current.ToString() + " / " + maxium.ToString();
    }

    public void AddExp(int givenExp)
    {
        current += givenExp;
    }

    public void GetSkillPanel()
    {
        panel.SetActive(true);
    }
}
