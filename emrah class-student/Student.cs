
internal class Student
{
    public string Name;
    public string Surname;
    public string Group;
    public double Point;
    public string isGraduated;

    public Student(string name, string surname, string group, double point, string isGraduated)
    {
        this.Name = name;
        this.Surname = surname;
        this.Group = group;
        this.Point = point;
        this.isGraduated = isGraduated;
    }

    public void GetFullName()
    {
        Console.WriteLine(Name + " " + Surname);

    }

    public void GetFullInfo()
    {
        Console.WriteLine($"{"Name:" + this.Name},{"Surname:" + this.Surname},{"Group:" + this.Group},{"Point:" + this.Point},{this.isGraduated}");
        if (isGraduated == "mezun")
        {
            Console.WriteLine("Congratulations, you graduated");
        }
        else if (isGraduated == "mezun deyil")
        {
            Console.WriteLine("I'm sorry you didn't graduate");
        }
        if (Point >= 80&&Point<=100)
        {
            Console.WriteLine("you can enter the second exam");
        }
        else if (Point <= 80 && Point >= 0)
        {
            Console.WriteLine("you cannot enter the second exam");
        }

         if (Point < 0 || Point > 100)
        {
            Console.WriteLine("point is not correct");
            
        }
    }
}

