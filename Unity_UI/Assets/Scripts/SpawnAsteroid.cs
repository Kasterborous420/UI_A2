using UnityEngine;
using System.Collections;

public class SpawnAsteroid : MonoBehaviour
{

    public GameObject asteroid;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("addenemy", 1, 1);
    }

    void addenemy()
    {
        Vector2 Spawnpoint = new Vector2(Random.Range(-2, 3), transform.position.y);

        Instantiate(asteroid, Spawnpoint, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
