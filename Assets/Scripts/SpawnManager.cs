using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public int maxPlatforms = 20;
    public GameObject platform;
    public float horizontalMin = 6.5f;
    public float horizontalMax = 14f;
    public float verticalMin = -6f;
    public float verticalMax = 6f;

    private Vector2 originPositon;
    
    // Use this for initialization
    void Start ()
    {
        originPositon = transform.position;
        Spawn();
	}

    void Spawn()
    {
        for (int i = 0; i < maxPlatforms; i++)
        {
            Vector2 randomPosition = originPositon + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            Instantiate(platform, randomPosition, Quaternion.identity);
            originPositon = randomPosition;
        }
    }
}
