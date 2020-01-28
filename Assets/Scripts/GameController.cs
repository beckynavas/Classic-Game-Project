using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] hazards;
    public GameObject[] instantiatedObstacles;
    public Vector2 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    // Update is called once per frame
    void Update()
    {
        instantiatedObstacles = GameObject.FindGameObjectsWithTag("Obstacle");
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (instantiatedObstacles.Length != hazardCount)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector2 spawnPosition = new Vector2(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y));
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                //yield return new WaitForSeconds(spawnWait); //Get rid of to spawn all at once
            }
            yield return new WaitForSeconds(waveWait);
            //yield return ;
        }
    }
    void Spawn()
    {
        if ( instantiatedObstacles.Length == 0 )
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                //Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                //Instantiate(hazard, spawnPosition, spawnRotation);
                //yield return new WaitForSeconds(spawnWait); //Get rid of to spawn all at once
            }
        }
        
    }
}
