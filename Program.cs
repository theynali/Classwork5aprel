namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ismayil", "Zeynalli", 21, 98);
            student.ShowFullData();
            Teacher teacher = new Teacher("Resul", "Rustamli",27, 3);
            teacher.ShowFullData();
        }
    }
}