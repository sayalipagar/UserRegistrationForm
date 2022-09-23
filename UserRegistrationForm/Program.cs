namespace UserRegistrationForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidationForm form = new ValidationForm();
            Console.WriteLine("Enter The First Name: ");
            string firstName = Console.ReadLine();
            form.FirstName(firstName);
            Console.WriteLine("Enter The Last Name: ");
            string lastName = Console.ReadLine();
            form.FirstName(lastName);
        }
    }
}