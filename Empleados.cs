namespace Empleados;


public class Empleado{

    public string? Nombre {get; set;}
    public string? Apellido {get; set;}
    public DateTime FechaNacimiento {get; set;}
    public char EstadoCivil {get; set;}
    public char Genero {get; set;}
    public DateTime FechaIngreso {get; set;}
    public double SueldoBasico {get; set;}
    public Cargos Cargo {get; set;}

    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public int CalcularAntiguedad()
    {
        TimeSpan antiguedad = DateTime.Now - FechaIngreso;
        return (int)Math.Floor(antiguedad.TotalDays/365.25);
    }
    public int CalcularEdad()
    {
        TimeSpan edad = DateTime.Now - FechaNacimiento;
        return (int)Math.Floor(edad.TotalDays/365.25);
    }
    public int CalcularAniosParaJubilarse()
    {
        int edadJubilacion = (Genero=='M')?65:60;
        int edadActual = CalcularEdad();
        return Math.Max(0,edadJubilacion-edadActual);
    }

}