using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Commands
{
    public class MoveCommand : ICommand
    {
        private readonly IEntity _entity;

        public MoveCommand(IEntity entity)
        {
            _entity = entity;
        }

        public void Execute()
        {
            _entity.Move();
        }
    }
}
