
public class StudentGrade
{

    private int grade;

    public int Grade
    {
        get
        {
            return grade;
        }
        set
        {
            grade = value;
        }
    }

    public StudentGrade(int grade)
    {  
        this.grade = grade;     
    }
    

    public static void GradeConverter()
    { 
        try
        {
            int grade;
            Console.WriteLine("Enter student grade");
            grade = int.Parse(Console.ReadLine());
            switch(grade)
            {
                case 10:
                Console.WriteLine("Student grade converted to A+");
                break;
                case 9:
                Console.WriteLine("Student grade converted to A");
                break;
                case 8: 
                case 7:
                Console.WriteLine("Student grade converted to B");
                break;
                case 6:
                Console.WriteLine("Student grade converted to C");
                break;
                case 5:
                Console.WriteLine("Student grade converted to E");
                break;
                case int when grade < 4:
                Console.WriteLine("Student grade converted to F");
                break;
                default:
                Console.WriteLine("Please enter student grade between 0 and 10, only");
                break;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }

}
