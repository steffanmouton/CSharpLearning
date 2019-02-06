using UnityEngine;

namespace StefTools.FiniteStateMachine
{
    public abstract class Context
    {
        public abstract void Update();
        
        public State Current;
        public abstract void ChangeState(State s);
        public abstract void OnExit();
        public abstract void OnEnter();
    }
}