using UnityEngine;
using UnityEngine.AI;

namespace Command
{
    public class MovePlayerCommand : CommandClass
    {
        private readonly Vector3 _destination;
        private readonly NavMeshAgent _agent;
        public override bool isFinished => _agent.remainingDistance <= 0.1f;

        public MovePlayerCommand(Vector3 destination, NavMeshAgent agent)
        {
            _destination = destination;
            _agent = agent;
        }
        
        
        public override void Execute()
        {
            _agent.SetDestination(_destination); 
        }
    }
}