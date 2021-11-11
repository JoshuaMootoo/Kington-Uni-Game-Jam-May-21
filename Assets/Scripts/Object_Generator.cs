using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Generator : MonoBehaviour
{
    public Game_Controller gameController;

    public GameObject boost;
    public GameObject[] fruits = new GameObject[7];
    public GameObject[] Obstacles = new GameObject[3];

    public GameObject[] level1Sprites = new GameObject[3];
    public GameObject[] level2Sprites = new GameObject[3];
    public GameObject[] level3Sprites = new GameObject[3];

    public Vector2 bounds;

    private void Start()
    {
        StartCoroutine(_SpawnBoost());
        StartCoroutine(_SpawnFruit());
        StartCoroutine(_SpawnObstacle());
    }

    private void Update()
    {
        if (gameController.level == 1)
        {
            for (int i = 0; i < 3; i++)
            {
                Obstacles[i] = level1Sprites[i];
            }
        }
        if (gameController.level == 2)
        {
            for (int i = 0; i < 3; i++)
            {
                Obstacles[i] = level2Sprites[i];
            }
        }
        if (gameController.level == 3)
        {
            for (int i = 0; i < 3; i++)
            {
                Obstacles[i] = level3Sprites[i];
            }
        }
    }

    void SpawnBoost()
    {
        GameObject a = Instantiate(boost);
        a.transform.position = new Vector2(Random.Range(-bounds.x, bounds.x), bounds.y);
        a.transform.SetParent(this.transform);
    }

    void SpawnFruit()
    {
        GameObject a = Instantiate(fruits[Random.Range(0, 7)]);
        a.transform.position = new Vector2(Random.Range(-bounds.x, bounds.x), bounds.y);
        a.transform.SetParent(this.transform);
    }

    void SpawnObstacle()
    {
        GameObject a = Instantiate(Obstacles[Random.Range(0, 3)]);
        a.transform.position = new Vector2(Random.Range(-bounds.x, bounds.x), bounds.y);
        a.transform.SetParent(this.transform);
    }

    IEnumerator _SpawnBoost()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            SpawnBoost();
        }
    }

    IEnumerator _SpawnFruit()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            SpawnFruit();
        }
    }

    IEnumerator _SpawnObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            SpawnObstacle();
        }
    }
}
