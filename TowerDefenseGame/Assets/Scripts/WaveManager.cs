using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour 
{
	int currentWaveCount = 0;
	public int maxWaveCount = 3;

	int numberToSpawn;

	public GameObject spawnPoint;
	public GameObject npcPrefab;

	public float timeBetweenSpawn = 0.07f;
	bool canSpawn = true;

	public int spawnedEnemiesLeft = 0; // The update method will track this number to determine if a new wave needs to be spawned

	void Start () 
	{

	}
		
	void Update ()
	{
		if (spawnedEnemiesLeft <= 0) //check if all mobs are dead, if so call NextWave(); which will spawn the next wave
		{
			currentWaveCount += 1;//Increment waves
			NextWave ();
		}
	}

	void NextWave()
	{
		numberToSpawn = currentWaveCount * 10; //Formula to figure out how many mobs you want to spawn per wave (wave number * 10)
		spawnedEnemiesLeft = numberToSpawn; //set to the number of enemies we are spawning
		StartCoroutine(SpawnMobs ());//loop mob spawns
	}
		
	IEnumerator SpawnMobs ()
	{
		for(int i = 0; i < numberToSpawn ; i++)
		{
			yield return new WaitForSeconds (timeBetweenSpawn);//wait 1 second between each spawn
			Instantiate (npcPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);

		}
	}
}
