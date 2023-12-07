using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_and_Inheritance_Task_3
{
    public class Elf : Hero //йерархия с главния клас Hero
    {
        public Elf(string username, int level) : base(username, level) //конструктор който взима от главния клас данните без да се налага да ги пишем пак и в
                                                                      //този констуктор слагаме само нови неща за този специфичен клас Elf
        {

        }
    }
}
