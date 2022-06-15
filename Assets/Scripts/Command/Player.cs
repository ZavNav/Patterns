using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

namespace Command
{
    public class Player : MonoBehaviour
    {
        private NavMeshAgent _agent;
        private Camera _cam;

        private readonly Queue<CommandClass> _commands = new();
        private readonly Stack<CommandClass> _undoCommands = new();
        private CommandClass _currentCommand;
        private void Awake()
        {
            _agent = GetComponent<NavMeshAgent>();
            _cam = Camera.main;
        }

        private void Update()
        {
            GetCommandsFromInput();
            ExecuteCommands();
        }

        private void ExecuteCommands()
        {
            if(_currentCommand is {isFinished: false} || !_commands.Any()) return;

            _undoCommands.Push(new MovePlayerCommand(transform.position, _agent));
            
            _currentCommand = _commands.Dequeue();
            _currentCommand.Execute();
        }
        private void GetCommandsFromInput()
        {
            if(!Input.GetMouseButtonDown(0)) return;
            
            var ray = _cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit))
            {
                _commands.Enqueue(new MovePlayerCommand(hit.point, _agent));
            }
        }

        public void UndoCommand()
        {
            if(_currentCommand is {isFinished: false} || !_undoCommands.Any()) return;

            _currentCommand = _undoCommands.Pop();
            _currentCommand.Execute();
        }
    }
}
