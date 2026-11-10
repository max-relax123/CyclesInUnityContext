using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string enemyName;
    public int health;
    public int level;

    public TMP_Text nameText;

    public TMP_Text healthText;

    public TMP_Text levelText;


    void Start()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        nameText.text = enemyName;
        healthText.text = "HP: " + health;
        levelText.text = "Level: " + level;

    }

}
