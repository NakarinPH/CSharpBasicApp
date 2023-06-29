namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = GetPeopleString();

            foreach (string person in people) 
            {
                Console.WriteLine($"Hello {person}");
            }

            Console.ReadLine();

            List<PersonModel> peopleModels = GetPeopleModel();

            foreach (PersonModel person in peopleModels)
            {
                Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
            }
            
            Console.ReadLine();
        }
        private static List<PersonModel> GetPeopleModel()
        {
            List<PersonModel> output = new List<PersonModel>();

            output.Add(new PersonModel { FirstName = "Nakarin", LastName = "Philangam"});
            output.Add(new PersonModel { FirstName = "Tim", LastName = "Correy" });

            return output;
        }

        private static List<string> GetPeopleString() 
        {
            List<string> output = new List<string>();

            output.Add("John");
            output.Add("Mary");
            output.Add("Sue");
            output.Add("David");
            output.Add("Michell");
            output.Add("Mike");
            output.Add("Rose");

            return output;
        }
    }
}

