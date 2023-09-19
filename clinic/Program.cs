using clinic.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> id = new List<int>()
        {1, 2, 3, 4, 5, 6, 7 };

        List<string> firstname = new List<string>()
        { "Иван", "Максим", "Алексей", "Кирилл", "Мефодий", "Мария", "Анастасия"};

        List<string> secondname = new List<string>()
        { "Иванов", "Смирнов", "Кузнецов", "Попов", "Васильев", "Петрова", "Соколова"};

        List<string> surname = new List<string>()
        {"Альбертович", "Богданович", "Вадимович", "Викториевич", "Демьянович", "Евдокимовна", "Исаевна"};

        List<int> experience = new List<int>();
        Random random = new Random();
        for (int i =1; i<=firstname.Count; i++)
            experience[i] = random.Next(0, 10);

        List<string> qualification = new List<string>()
        { "Терапевт", "Хирург", "Невролог", "Окулист/офтальмолог", "Травматолог", "Эндокринолог", "Стоматолог"};

        for (int i = 0; i <= firstname.Count; i++)
        {
            Doctor doctor = new Doctor(id[i], firstname[i], secondname[i],
                surname[i], experience[i], qualification[i]);
        }        
    }
}