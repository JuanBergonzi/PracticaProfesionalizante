using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class EspecialidadMedica
{
    public string Nombre { get; set; }
    public EspecialidadMedica(string nombre)
    {
        Nombre = nombre;
    }
}

public class HorarioAtencion
{
    public string Horario { get; set; }

    public HorarioAtencion(string horario)
    {
        Horario = horario;
    }
}

public class Doctor
{
    public int IdDoctor { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Matricula { get; set; }
    public EspecialidadMedica Especialidad { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public HorarioAtencion HorarioAtencion { get; set; }
    public string Consultorio { get; set; }

}

public class Paciente
{
    public int IdPaciente { get; set; }
    public string Dni { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; } 
    public DateTime FechaNacimiento { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string ObraSocial { get; set; }
    public string HistorialMedico { get; set; }
}

public class Recepcionista
{
    public int IdRecepcionista { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Usuario { get; set; }
    public string Constrasenia { get; set;}
    public string Telefono { get; set;}
}

public class TurnoMedico
{
    public Paciente Paciente { get; set; }
    public Doctor Doctor { get; set; }
    public DateTime FechaHora { get; set; }
    public string Estado { get; set; }
    public int Duracion { get; set; }
    public string Motivo { get; set; }
    public Recepcionista Recepcionista { get; set; }
}


class Program
{
    static void Main(string[] args)
    {
        // Cargar datos para la especialidad y el horario del doctor
        Console.WriteLine("Ingrese la especialidad del doctor (ej: Cardiología, Dermatología):");
        string especialidadInput = Console.ReadLine();
        EspecialidadMedica especialidad = new EspecialidadMedica(especialidadInput);

        Console.WriteLine("Ingrese el horario de atención del doctor (ej: 08:00 - 12:00):");
        string horarioInput = Console.ReadLine();
        HorarioAtencion horario = new HorarioAtencion(horarioInput);

        // Cargar datos para el doctor
        Doctor doctor = new Doctor();
        doctor.IdDoctor = 1; // Se asigna un ID fijo o puede incrementarse
        Console.WriteLine("Ingrese el nombre del doctor:");
        doctor.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el apellido del doctor:");
        doctor.Apellido = Console.ReadLine();
        Console.WriteLine("Ingrese la matrícula del doctor:");
        doctor.Matricula = Console.ReadLine();
        doctor.Especialidad = especialidad;
        Console.WriteLine("Ingrese el teléfono del doctor:");
        doctor.Telefono = Console.ReadLine();
        Console.WriteLine("Ingrese el email del doctor:");
        doctor.Email = Console.ReadLine();
        doctor.HorarioAtencion = horario;
        Console.WriteLine("Ingrese el consultorio del doctor:");
        doctor.Consultorio = Console.ReadLine();

        // Cargar datos para el paciente
        Paciente paciente = new Paciente();
        paciente.IdPaciente = 1; // ID asignado manualmente
        Console.WriteLine("Ingrese el DNI del paciente:");
        paciente.Dni = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre del paciente:");
        paciente.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el apellido del paciente:");
        paciente.Apellido = Console.ReadLine();
        Console.WriteLine("Ingrese la fecha de nacimiento del paciente (yyyy-MM-dd):");
        string fechaNacimientoInput = Console.ReadLine();
        DateTime fechaNacimiento;
        while (!DateTime.TryParseExact(fechaNacimientoInput, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaNacimiento))
        {
            Console.WriteLine("Fecha inválida. Ingrese nuevamente la fecha de nacimiento (yyyy-MM-dd):");
            fechaNacimientoInput = Console.ReadLine();
        }
        paciente.FechaNacimiento = fechaNacimiento;
        Console.WriteLine("Ingrese el teléfono del paciente:");
        paciente.Telefono = Console.ReadLine();
        Console.WriteLine("Ingrese el email del paciente:");
        paciente.Email = Console.ReadLine();
        Console.WriteLine("Ingrese la obra social del paciente:");
        paciente.ObraSocial = Console.ReadLine();
        Console.WriteLine("Ingrese el historial médico del paciente:");
        paciente.HistorialMedico = Console.ReadLine();

        // Cargar datos para la recepcionista
        Recepcionista recepcionista = new Recepcionista();
        recepcionista.IdRecepcionista = 1;
        Console.WriteLine("Ingrese el nombre de la recepcionista:");
        recepcionista.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el apellido de la recepcionista:");
        recepcionista.Apellido = Console.ReadLine();
        Console.WriteLine("Ingrese el usuario de la recepcionista:");
        recepcionista.Usuario = Console.ReadLine();
        Console.WriteLine("Ingrese la contraseña de la recepcionista:");
        recepcionista.Constrasenia = Console.ReadLine();
        Console.WriteLine("Ingrese el teléfono de la recepcionista:");
        recepcionista.Telefono = Console.ReadLine();

        // Cargar datos para el turno médico
        TurnoMedico turno = new TurnoMedico();
        turno.Paciente = paciente;
        turno.Doctor = doctor;
        Console.WriteLine("Ingrese la fecha y hora del turno médico (yyyy-MM-dd HH:mm):");
        string fechaHoraInput = Console.ReadLine();
        DateTime fechaHora;
        while (!DateTime.TryParseExact(fechaHoraInput, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaHora))
        {
            Console.WriteLine("Formato inválido. Ingrese nuevamente la fecha y hora del turno (yyyy-MM-dd HH:mm):");
            fechaHoraInput = Console.ReadLine();
        }
        turno.FechaHora = fechaHora;
        Console.WriteLine("Ingrese el estado del turno (ej: Pendiente, Confirmado, Cancelado):");
        turno.Estado = Console.ReadLine();
        Console.WriteLine("Ingrese la duración del turno en minutos:");
        int duracion;
        while (!int.TryParse(Console.ReadLine(), out duracion))
        {
            Console.WriteLine("Ingrese un número válido para la duración:");
        }
        turno.Duracion = duracion;
        Console.WriteLine("Ingrese el motivo del turno:");
        turno.Motivo = Console.ReadLine();
        turno.Recepcionista = recepcionista;

        // Mostrar la información cargada del turno médico
        Console.WriteLine("\n--- Información del Turno Médico ---");
        Console.WriteLine($"Paciente: {turno.Paciente.Nombre} {turno.Paciente.Apellido}");
        Console.WriteLine($"Doctor: {turno.Doctor.Nombre} {turno.Doctor.Apellido} ({turno.Doctor.Especialidad.Nombre})");
        Console.WriteLine($"Fecha y Hora: {turno.FechaHora}");
        Console.WriteLine($"Estado: {turno.Estado}");
        Console.WriteLine($"Duración: {turno.Duracion} minutos");
        Console.WriteLine($"Motivo: {turno.Motivo}");
        Console.WriteLine($"Recepcionista: {turno.Recepcionista.Nombre} {turno.Recepcionista.Apellido}");

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}