
namespace Encapsulation_and_Inheritance
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        private const int NAME_MIN_LENGHT = 3; //магическо число, пише се така защото е константа и да не го сменяме после на 100 места.


        public Person(string firstName, string lastName, int age)  //констуктор
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName 
        
        { 
            get { return this._firstName; }
            private set
            {
                if (value.Length < NAME_MIN_LENGHT)
                {
                    throw new ArgumentException($"First name cannot contain fewer than {NAME_MIN_LENGHT} symbols!");
                }
                this._firstName = value; 
            } 
        }

        public string LastName
        {
            get { return this._lastName; }
            private set 
            {
                if (value.Length < NAME_MIN_LENGHT)
                {
                    throw new ArgumentException($"Last name cannot contain fewer than {NAME_MIN_LENGHT} symbols!");
                }
                this._lastName = value;
            }

        }
        public int Age 
        {
            get { return this._age; } 
            private set 
            {

                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                this._age = value; 
            }
        }

        public override string ToString()  //override вам ToString защото всеки клас го има по default и така няма да вади просто името на класа,
                                           //а ще печати каквото е сложено.
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }

    }
}
