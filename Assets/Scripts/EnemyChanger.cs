using UnityEngine;

public class EnemyChanger : MonoBehaviour
{
    public Enemy[] enemies;
    void Start()
    {
        enemies = FindObjectsByType<Enemy>();

        Debug.Log("Найдено юнитов: " + enemies.Length);

    }
}
