using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour 
{
	int currentWaveCount;
	int maxWaveCount;

	int numberToSpawn;

	int spawnedEnemiesLeft = 0; // The update method will track this number to determine if a new wave needs to be spawned

	void Start () 
	{
		//implement waveOne
	}
		
	void Update ()
	{
		if (spawnedEnemiesLeft <= 0) //check if all mobs are dead, if so call NextWave(); which will spawn the next wave
		{
			
		}
	}

	void NextWave()
	{
		numberToSpawn = currentWaveCount * 10; //random formula to figure out how many mobs you want to spawn per wave (wave number * 10)
		spawnedEnemiesLeft = numberToSpawn; //set to the number of enemies we are spawning
		SpawnMobs ();//loop mob spawns
	}

	void SpawnMobs ()
	{
		for(int i = 1; i < numberToSpawn; i++)
		{
			//instantiate a monster on the spawn point, this monster will have a health script and a pathfinding script attached
		}
	}
}
