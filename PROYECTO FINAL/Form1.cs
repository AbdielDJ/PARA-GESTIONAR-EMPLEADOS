using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class Form1 : Form
    {
        // Lista global de empleados
        List<Empleado> empleados = new List<Empleado>();

        public Form1()
        {
            InitializeComponent();
            // Agregar algunos empleados de ejemplo a la lista
            empleados.Add(new Empleado { ID = 1, Nombre = "Juan Pérez", Departamento = "Ventas", Cargo = "Vendedor", FechaInicio = DateTime.Now.AddYears(-2), Salario = 20000m, Estado = "Vigente" });
            empleados.Add(new Empleado { ID = 2, Nombre = "Ana López", Departamento = "Recursos Humanos", Cargo = "Gerente", FechaInicio = DateTime.Now.AddYears(-3), Salario = 35000m, Estado = "Vigente" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Empleado empleadoPrueba = new Empleado
            {
                ID = 1,
                Nombre = "Juan Pérez",
                Departamento = "IT",
                Cargo = "Desarrollador",
                FechaInicio = new DateTime(2020, 5, 15),
                Salario = 50000,
                Estado = "Vigente"
            };

            MessageBox.Show($"Empleado: {empleadoPrueba.Nombre}\n" +
                            $"Tiempo en Empresa: {empleadoPrueba.TiempoEnEmpresa}\n" +
                            $"AFP: {empleadoPrueba.AFP:C}\n" +
                            $"ARS: {empleadoPrueba.ARS:C}\n" +
                            $"ISR: {empleadoPrueba.ISR:C}",
                            "Prueba de Empleado");
        }
    }
}
