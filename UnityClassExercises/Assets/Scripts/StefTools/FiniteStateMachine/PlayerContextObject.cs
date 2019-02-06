using UnityEngine;

namespace StefTools.FiniteStateMachine
{
    [CreateAssetMenu(menuName = "Objects/Context")]
    public class PlayerContextObject : ScriptableObject
    {
        public PlayerContext _context;
    }
}