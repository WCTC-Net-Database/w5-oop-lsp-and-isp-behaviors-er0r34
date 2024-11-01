using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Commands
{
    public class FlyCommand : ICommand
    {
        private readonly IFlyable _flyableEntity;

        public FlyCommand(IFlyable flyableEntity)
        {
            _flyableEntity = flyableEntity;
        }

        public void Execute()
        {
            _flyableEntity.Fly();
        }
    }
}

