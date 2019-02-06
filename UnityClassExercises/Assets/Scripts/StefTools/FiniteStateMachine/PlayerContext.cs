using UnityEngine;

namespace StefTools.FiniteStateMachine
{
    public class PlayerContext : Context
    {
        public PlayerContext(State start)
        {
            Current = start;
        }
        public override void Update()
        {
            Current.Update(this);
        }

        public override void ChangeState(State s)
        {
            Current.OnExit(this);
            Current = s;
            Current.OnEnter(this);
        }

        public override void OnExit()
        {
            throw new System.NotImplementedException();
        }

        public override void OnEnter()
        {
            throw new System.NotImplementedException();
        }
    }
}