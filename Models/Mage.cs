using W5_assignment_template.Interfaces;
using System;

namespace W5_assignment_template.Models
{
    public class Mage : IEntity, ICastable
    {
        public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with a magic blast.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moves swiftly.");
        }

        public void CastSpell(string spellName)
        {
            Console.WriteLine($"{Name} casts {spellName}.");
        }
    }
}
