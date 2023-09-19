using clinic.Entities;

internal class Program
{
    List<Doctor> _doctors = new List<Doctor>();
    string? _selectDoctor;
    string? _selectDay;
    string? _selectPerson;
    bool _checkSchedule;
    int? _time;

    private static void Main(string[] args)
    {

    }

    private void SelectedDoctor()
    {
        Console.WriteLine("К какому специалисту вы хотите записаться ?");
        foreach (Doctor doctor in _doctors)
        {
            Console.WriteLine(doctor.Qualification.ToString());
        }

        _selectDoctor = Console.ReadLine(); 
    }

    private void SelectedDay()
    {
        Console.WriteLine("На какой день недели вы хотите записаться ?");
        _selectDay = Console.ReadLine();
    }

    private void SelectedPerson()
    {
        Console.WriteLine("К какому доткору вы хотите записаться ?");
        _selectPerson = Console.ReadLine();
    }

    private bool ShowEntry()
    {
        Console.WriteLine("Вы хотите посмотреть свободное время ? Если да, то нажмите 1, если нет, то нажмите 2");
        string? str = Console.ReadLine();
        while (str != "1" || str != "2")
        {
            Console.WriteLine("Вы ввели не ту команду, введите 1 или 2.");
            str = Console.ReadLine();
        }
        if (str == "1") return true;
        else return false;
    }

    private void SelectedTime() 
    {
        Console.WriteLine("На какое время вы хотите записаться");
        _time = int.Parse(Console.ReadLine());
    }
}