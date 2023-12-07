using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_and_Inheritance_Task_3
{
    public class Hero
    {

        public Hero(string username, int level) //констуктор
        {
            this.Username = username;
            this.Level = level;

        }
        public string Username { get; set; }

        public int Level { get; set; }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
