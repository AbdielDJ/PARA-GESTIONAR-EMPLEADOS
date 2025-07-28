using System;

public class Empleado
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Departamento { get; set; }
    public string Cargo { get; set; }
    public DateTime FechaInicio { get; set; }
    public decimal Salario { get; set; }
    public string Estado { get; set; } // "Vigente" o "No Vigente"
    public string TiempoEnEmpresa => CalcularTiempoEnEmpresa();
    public decimal AFP => Salario * 0.0287m; // 2.87%
    public decimal ARS => Salario * 0.0304m; // 3.04%
    public decimal ISR => CalcularISR();

    private string CalcularTiempoEnEmpresa()
    {
        DateTime hoy = DateTime.Today;
        int años = hoy.Year - FechaInicio.Year;
        int meses = hoy.Month - FechaInicio.Month;

        if (hoy.Day < FechaInicio.Day)
            meses--;
        if (meses < 0)
        {
            años--;
            meses += 12;
        }

        return $"{años} años, {meses} meses";
    }

    private decimal CalcularISR()
    {
        if (Salario <= 34685) return 0;
        if (Salario <= 52027) return (Salario - 34685) * 0.15m;
        if (Salario <= 72260) return ((Salario - 52027) * 0.20m) + (52027 - 34685) * 0.15m;
        return ((Salario - 72260) * 0.25m) + (72260 - 52027) * 0.20m + (52027 - 34685) * 0.15m;
    }
}
