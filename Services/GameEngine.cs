using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;
using W5_assignment_template.Commands;
using System.Collections.Generic;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _archer;
        private readonly IEntity _mage;

        private readonly List<ICommand> _commands = new List<ICommand>();

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity archer, IEntity mage)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _archer = archer;
            _mage = mage;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _archer.Name = "Archer";
            _mage.Name = "Mage";

            _commands.Add(new MoveCommand(_character));
            _commands.Add(new AttackCommand(_character, _goblin));

            _commands.Add(new MoveCommand(_goblin));
            _commands.Add(new AttackCommand(_goblin, _character));

            _commands.Add(new MoveCommand(_ghost));
            _commands.Add(new AttackCommand(_ghost, _character));
            _commands.Add(new FlyCommand((IFlyable)_ghost));

            _commands.Add(new MoveCommand(_archer));
            _commands.Add(new AttackCommand(_archer, _goblin));

            _commands.Add(new MoveCommand(_mage));
            _commands.Add(new AttackCommand(_mage, _goblin));

            ExecuteCommands();
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
            _commands.Clear();
        }
    }
}
