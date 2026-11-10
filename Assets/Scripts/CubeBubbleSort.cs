using UnityEngine;

public class CubeBubbleSort : MonoBehaviour
{
    public GameObject[] cubes;
    
    void Start()
    {
        for (int i = 0; i < cubes.Length; i++)
        {

            for (int j = i + 1; j < cubes.Length; j++)
            {
                if (cubes[i].transform.localScale.y < cubes[j].transform.localScale.y)
                {
                    GameObject temp = cubes[i];
                    cubes[i] = cubes[j];
                    cubes[j] = temp; 


                }
            }
        }

        for (int i = 0;i < cubes.Length; i++)
        {
            cubes[i].transform.position = new Vector3(i * 4, 1, 0);
        }
    }   
}
