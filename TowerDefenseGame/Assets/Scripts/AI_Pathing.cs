using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Pathing : MonoBehaviour 
{
	float unitSpeed = 10f;
	GameObject pointA;
	GameObject pointB;
	GameObject pointC;

	void Start ()
	{
		//tell it to move to point A using the unit's speed
	}

	void Update ()
	{
		//check to see if it reached point A (you can do this using collion or by checking to see if the object is still moving, because
		//if it has reached it destination, it will be standing still.

		//then tell it to move to pointB, and again check to see if it reached point b, then tell it to move to point C.
	}


}
