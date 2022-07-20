using ClassesPractice2;

//SOLID Principles 
// S - Single Responsibility Principle
//O - Open/Closed Principle - Classes should be open to extension and closed to modification

List<Person> people = new List<Person>();

while (true)
{
    //ask for name
    Console.Write("Please enter your name: (type 'quit' to quit): ");

    string nameInput = Console.ReadLine();
    if (nameInput.ToLower() == "quit")
    {
        break;
    }

    //ask for favorite color
    Console.WriteLine(); //blank writeline for some spacing on the console screen
    Console.Write("What is your favorite color? ");

    string colorInput = Console.ReadLine();

    //favorite food
    Console.WriteLine();
    Console.Write("What is your favorite food? ");

    string foodInput = Console.ReadLine();

    //capture entries into object
    Person person = new Person(nameInput, colorInput, foodInput);
    people.Add(person);

}
foreach (Person person in people)
{
    //summarize all info entered so far
    person.GetDisplayInfo();

}
Console.ReadLine();
