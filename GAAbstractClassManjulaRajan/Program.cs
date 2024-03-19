namespace GAAbstractClassManjulaRajan
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> schoolDatabase = new List<Person>();

            //Instance

            schoolDatabase.Add(new Student("Manjula Rajan", 12345, 3.8));
            schoolDatabase.Add(new Student("Breshna", 67890, 3.5));
            schoolDatabase.Add(new Professor("Dr. Will Cram", 101, "Computer Science"));
            schoolDatabase.Add(new Professor("Dr. Joshua Emery", 102, "Mathematics"));
            schoolDatabase.Add(new Faculty("Lisa", 201, "Librarian"));
            schoolDatabase.Add(new Faculty("Boo", 202, "Admissions"));

            foreach (var person in schoolDatabase)
            {

                Console.WriteLine(person.GetDetails());
                Console.WriteLine();


            }
            Console.ReadLine();

        }
    }
}