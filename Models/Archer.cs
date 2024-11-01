using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
   {
       public class Archer : IEntity, IShootable
       {
           public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with a chilling touch.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moves fast and silently.");
        }

        public void Shoot()
        {
            Console.WriteLine($"{Name} shoots an arrow at the target.");
        }
    }
   }
   