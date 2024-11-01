using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;
using W5_assignment_template.Services;

namespace W5_assignment_template
{
    class Program
    {
        static void Main(string[] args)
        {
            IEntity character = new Character();
            IEntity goblin = new Goblin();
            IEntity ghost = new Ghost();
            IEntity archer = new Archer();
            IEntity mage = new Mage();

            GameEngine gameEngine = new GameEngine(character, goblin, ghost, archer, mage);
            gameEngine.Run();
        }
    }
}
