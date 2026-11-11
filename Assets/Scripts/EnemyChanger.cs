using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyChanger : MonoBehaviour
{
    public Enemy[] enemies;
    public TMP_InputField inputField;
    void Start()
    {
        enemies = FindObjectsByType<Enemy>();

        Debug.Log("Найдено юнитов: " + enemies.Length);

    }

    public void FilterHealth()
    {
        int value = int.Parse(inputField.text);
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].gameObject.SetActive(enemies[i].health > value);
        }

    }


    public void FilterLevel()
    {
        int value = int.Parse(inputField.text);
        for (int i = 0;i < enemies.Length; i++)
        {
            enemies[i].gameObject.SetActive(enemies[i].level == value);
        }

    }


    public void ResetEnemies()
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].gameObject.SetActive(true);
        }

    }


    public void MakeBoss()
    {
        string value = inputField.text;

        for (int i = 0; i < enemies.Length; i++)
        {

            if (enemies[i].enemyName == value)
            {
                enemies[i].enemyName = "Boss";
                enemies[i].level++;
                enemies[i].health *= 3;
                enemies[i].UpdateText();
            }

        }
    }

}
