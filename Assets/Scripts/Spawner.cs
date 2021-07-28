using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] BallBall;
    public Transform YellowSpawn, RedSpawn, PurpleSpawn, GreenSpawn, BlueSpawn;
    private GameObject SpawnedBall;
    private int randomBall;
    private int randomSpawner;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BallGeneration());
    }

    IEnumerator BallGeneration()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.1f, 0.3f));
            randomBall = Random.Range(0, BallBall.Length);
            randomSpawner = Random.Range(0, 4);
            SpawnedBall = Instantiate(BallBall[randomBall]);

            if (randomSpawner == 0)
            {
                SpawnedBall.transform.position = YellowSpawn.position;
            }
            else if (randomSpawner == 1)
            {
                SpawnedBall.transform.position = RedSpawn.position;
            }
            else if (randomSpawner == 2)
            {
                SpawnedBall.transform.position = PurpleSpawn.position;
            }
            else if (randomSpawner == 3)
            {
                SpawnedBall.transform.position = GreenSpawn.position;
            }
            else if (randomSpawner == 4)
            {
                SpawnedBall.transform.position = BlueSpawn.position;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
