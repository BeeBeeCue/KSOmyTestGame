using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;


namespace AssemblyCSharp
{
	
	public class Player: MonoBehaviour
	{
		public LayerMask wall;
		RaycastHit2D wallCheck;
		public Transform upCheck, downCheck, leftCheck, rightCheck;
		public Player ()
		{
			
		}

		public void Move(string input)
		{
			switch (input) 
			{
			case "up":
				transform.position = new Vector2 (transform.position.x, (float)(transform.position.y+1.286));
				break;
			case "left":
				transform.position = new Vector2 ((float)(transform.position.x-1.286), transform.position.y);
				break;
			case "right":
				transform.position = new Vector2 ((float)(transform.position.x+1.286), transform.position.y);
				break;
			case "down":
				transform.position = new Vector2 (transform.position.x,(float)( transform.position.y-1.286));
				break;
			}

		}

		void Update()
		{
			if (Input.GetKeyDown (KeyCode.A)) 
			{
				wallCheck = Physics2D.Linecast (this.transform.position, leftCheck.transform.position, wall);
				if (wallCheck.collider == null) 
				{
					Debug.Log ("Nothing here");
					this.Move ("left");
				}
			}
			else if(Input.GetKeyDown(KeyCode.S))
			{
				wallCheck = Physics2D.Linecast (this.transform.position, downCheck.transform.position, wall);
				if (wallCheck.collider == null) 
				{
					Debug.Log ("Nothing here");
					this.Move("down");
				}

			}
			else if(Input.GetKeyDown(KeyCode.D))
			{
				wallCheck = Physics2D.Linecast (this.transform.position, rightCheck.transform.position, wall);
				if (wallCheck.collider == null) 
				{
					Debug.Log ("Nothing here");
					this.Move("right");
				}

			}
			else if(Input.GetKeyDown(KeyCode.W))
			{
				wallCheck = Physics2D.Linecast (this.transform.position, upCheck.transform.position, wall);
				if (wallCheck.collider == null) 
				{
					Debug.Log ("Nothing here");
					this.Move("up");
				}

			}

			Debug.DrawLine (this.transform.position, leftCheck.transform.position);
			Debug.DrawLine (this.transform.position, rightCheck.transform.position);
			Debug.DrawLine (this.transform.position, downCheck.transform.position);
			Debug.DrawLine (this.transform.position, upCheck.transform.position);
		}



	}
}

