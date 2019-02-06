using UnityEngine;

namespace StefTools.FiniteStateMachine
{
    public abstract class State
    {
        public Transform transformRef;
        public abstract void OnEnter(Context cur);
        public abstract void Update(Context cur);
        public abstract void OnExit(Context cur);
    }
}