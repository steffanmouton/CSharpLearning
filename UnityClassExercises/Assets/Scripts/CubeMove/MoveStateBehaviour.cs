using UnityEngine;
using StefTools.FiniteStateMachine;

namespace CubeMove
{
	public class MoveStateBehaviour : MonoBehaviour {

		public float mSpeed;
		public Context mMoveContext;
		protected Transform mObjCurrentTrans;
		

		// Use this for initialization
		void Start ()
		{
			mObjCurrentTrans = GetComponent<Transform>();
			mMoveContext = new PlayerContext(new MoveForwardState(mObjCurrentTrans, mSpeed));
		}
	
		// Update is called once per frame
		void Update () 
		{
			
		mMoveContext.Update();
		
		}
	}
}