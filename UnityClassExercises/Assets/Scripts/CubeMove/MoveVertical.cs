using UnityEngine;

namespace CubeMove
{
	public class MoveVertical : MonoBehaviour
	{

		public float speed;

		// Use this for initialization
		void Start () {
		
		}
	
		// Update is called once per frame
		void Update () {
			transform.position = new Vector3(
				transform.position.x, 
				Mathf.Cos(Time.time * speed), 
				transform.position.z);
		}
	}
}
