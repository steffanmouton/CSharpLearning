﻿using UnityEngine;

namespace CubeMove
{
	public class MoveHorizontal : MonoBehaviour {

		public float speed;
		// Use this for initialization
		void Start () {
			
		
		}
	
		// Update is called once per frame
		void Update () {
			transform.position = new Vector3(
				Mathf.Cos(Time.time * speed), 
				transform.position.y, 
				transform.position.z);
		}
	}
}
