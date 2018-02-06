using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;


namespace AssemblyCSharp
{
	
	public class Player: MonoBehaviour
	{
		public Player ()
		{
			
		}

		public void Move(string input)
		{
			switch (input) 
			{
			case "up":
				transform.position = new Vector2 (transform.position.x, (float)(transform.position.y+0.643));
				break;
			case "left":
				transform.position = new Vector2 ((float)(transform.position.x-0.643), transform.position.y);
				break;
			case "right":
				transform.position = new Vector2 ((float)(transform.position.x+0.643), transform.position.y);
				break;
			case "down":
				transform.position = new Vector2 (transform.position.x,(float)( transform.position.y-0.643));
				break;
			}

		}
		void Update()
		{
			if (Input.GetKeyDown (KeyCode.A)) 
			{
				this.Move("left");
			}
			else if(Input.GetKeyDown(KeyCode.S))
			{
				this.Move("down");
			}
			else if(Input.GetKeyDown(KeyCode.D))
			{
				this.Move("right");
			}
			else if(Input.GetKeyDown(KeyCode.W))
			{
				this.Move("up");
			}
		}



	}
}

