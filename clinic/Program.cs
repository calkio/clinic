using clinic.Entities;

internal class Program
{
    static List<Doctor> _doctors = new List<Doctor>();
    static string? _selectDoctor;
    static string? _selectDay;
    static string? _selectPerson;
    static bool _checkSchedule;
    static int _time;

    private static void Main(string[] args)
    {
        CreateDoctors();
        while (true)
        {
            SelectedDoctor();
            SelectedDay();
            SelectedPerson();
            ShowEntry();
            SelectedTime();
            Record _record = new Record(_doctors[0], _selectDay, _checkSchedule, _time); 
        }
    }

    private static void CreateDoctors()
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
        for (int i = 1; i <= firstname.Count; i++)
            experience.Add(random.Next(0, 10));

        List<string> qualification = new List<string>()
        { "Терапевт", "Хирург", "Невролог", "Окулист/офтальмолог", "Травматолог", "Эндокринолог", "Стоматолог"};

        for (int i = 0; i < firstname.Count; i++)
        {
            _doctors.Add(new Doctor(id[i], firstname[i], secondname[i],
                surname[i], experience[i], qualification[i]));
        }

        foreach (Doctor doctor in _doctors)
        {
            doctor.Schedule = new Schedule();
        }
    }

    private static void SelectedDoctor()
    {
        Console.WriteLine("К какому специалисту вы хотите записаться ?");
        foreach (Doctor doctor in _doctors)
        {
            Console.WriteLine(doctor.Qualification.ToString());
        }

        _selectDoctor = Console.ReadLine(); 
    }

    private static void SelectedDay()
    {
        Console.WriteLine("На какой день недели вы хотите записаться ?");
        _selectDay = Console.ReadLine();
    }

    private static void SelectedPerson()
    {
        Console.WriteLine("К какому доктору вы хотите записаться ?");
        _selectPerson = Console.ReadLine();
    }

    private static void ShowEntry()
    {
        Console.WriteLine("Вы хотите посмотреть свободное время ? Если да, то нажмите 1, если нет, то нажмите 2");
        string? str = Console.ReadLine();
        while (str != "1" && str != "2")
        {
            Console.WriteLine("Вы ввели не ту команду, введите 1 или 2.");
            str = Console.ReadLine();
        }
        if (str == "1") _checkSchedule = true;
        else _checkSchedule = false;
    }

    private static void SelectedTime() 
    {
        Console.WriteLine("На какое время вы хотите записаться");
        _time = int.Parse(Console.ReadLine());
    }
}