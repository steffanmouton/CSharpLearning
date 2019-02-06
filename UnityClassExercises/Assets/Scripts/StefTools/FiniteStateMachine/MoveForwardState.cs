using UnityEngine;

namespace StefTools.FiniteStateMachine
{
    public class MoveForwardState : State
    {
        public float mSpeed;
        public MoveForwardState(Transform t, float s)
        {
            transformRef = t;
            mSpeed = s;
        }
        public override void OnEnter(Context cur)
        {
            
        }

        public override void Update(Context cur)
        {
            transformRef.position = new Vector3(
                Mathf.Sin(Time.time * mSpeed), 
                transformRef.position.y, 
                transformRef.position.z);
        }

        public override void OnExit(Context cur)
        {
            throw new System.NotImplementedException();
        }
    }
}