using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Commands
{
    public class AttackCommand : ICommand
    {
        private readonly IEntity _attacker;
        private readonly IEntity _target;

        public AttackCommand(IEntity attacker, IEntity target)
        {
            _attacker = attacker;
            _target = target;
        }

        public void Execute()
        {
            _attacker.Attack(_target);
        }
    }
}

