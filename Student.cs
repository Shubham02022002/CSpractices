namespace Collections
{

    internal class Student
    {
        private static int _nextId = 0;
        private int _id;
        private string? _name;
        private int _age;
        private decimal _marks;
        public string Name {
            get => _name;

            set {
                if (string.IsNullOrEmpty(value)|| value.Length>20)
                {
                    Console.WriteLine("Invalid value, try entering new name");
                }
                else
                {
                    _name = value;
                }
            }
               
             }
        public int Age { get => _age;
            set
            {
                if(value >=5 && value<=25)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Invalid age");
                }
            }
        }
        public decimal Marks { get => _marks;        
            set
            {
                if(value>=0 && value <= 100)
                {
                    _marks = value;
                }
                else
                {
                    Console.WriteLine("Invalid marks");
                }

            }
        }
        public int Id { get => _id; private set => _id = value; }

        public Student(string name, int age, decimal marks)      
        {
            Id = _nextId++;
            Name = name;
            Age = age;
            Marks = marks;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Marks: {Marks}";
        }
    }
}
