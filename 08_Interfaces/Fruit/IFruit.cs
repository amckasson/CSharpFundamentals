using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{

    // Nameing convention for interfaces: I______
    public interface IFruit
    {
        string Name { get; }

        bool IsPeeled { get; }
        // Methods in interfaces 
        // Can only set the return type, name, and parameters
        string Peel();
    }
}
