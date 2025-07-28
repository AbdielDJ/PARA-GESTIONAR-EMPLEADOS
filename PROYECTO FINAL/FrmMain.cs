using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROYECTO_FINAL
{

    public partial class FrmMain : Form
    {

        private BindingList<Empleado> empleados;
        private string archivoCSV = "empleados.csv";
        public FrmMain()
        {
            InitializeComponent();
            empleados = new BindingList<Empleado>();
            dgvEmpleados.DataSource = empleados;
            CargarEmpleadosDesdeCSV();
        }

        private void mostrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Limpiar cualquier dato anterior en el DataGridView
            dgvEmpleados.Rows.Clear();

            // Agregar los empleados al DataGridView
            foreach (var empleado in empleados)
            {
                dgvEmpleados.Rows.Add(
                    empleado.ID,
                    empleado.Nombre,
                    empleado.Departamento,
                    empleado.Cargo,
                    empleado.FechaInicio.ToShortDateString(),
                    empleado.Salario.ToString("C"),
                    empleado.Estado,
                    empleado.TiempoEnEmpresa
                );
            }
           
        }
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtEmpleadoNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEmpleadoDepartamento.Text) ||
                string.IsNullOrWhiteSpace(txtEmpleadoCargo.Text) ||
                !decimal.TryParse(txtEmpleadoSalario.Text, out decimal salario) ||
                !DateTime.TryParse(Dtpempleados.Text, out DateTime fechaInicio))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
                return;
            }

            if (!int.TryParse(txtEmpleadoID.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número válido.");
                return;
            }

            // Crear y agregar empleado
            Empleado nuevoEmpleado = new Empleado
            {
                ID = int.Parse(txtEmpleadoID.Text),
                Nombre = txtEmpleadoNombre.Text,
                Departamento = txtEmpleadoDepartamento.Text,
                Cargo = txtEmpleadoCargo.Text,
                FechaInicio = fechaInicio,
                Salario = salario,
                Estado = CboxEmpleadosEstado.SelectedText
            };
            empleados.Add(nuevoEmpleado);
            MessageBox.Show("Empleado agregado con éxito.");
            GuardarEmpleadosEnCSV();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtEmpleadoNombre.Clear();
            txtEmpleadoDepartamento.Clear();
            txtEmpleadoCargo.Clear();
            txtEmpleadoSalario.Clear();
        }


        private void ActualizarEmpleado(int id)
        {
           
        }
        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            // Verificar que el ID sea válido
            if (!int.TryParse(txtEmpleadoID.Text, out int id))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            // Buscar el empleado con el ID ingresado
            Empleado empleado = empleados.FirstOrDefault(emp => emp.ID == id);

            if (empleado != null)
            {
                // Actualizar los datos del empleado con los valores del formulario
                empleado.Nombre = txtEmpleadoNombre.Text;
                empleado.Departamento = txtEmpleadoDepartamento.Text;
                empleado.Cargo = txtEmpleadoCargo.Text;
                empleado.Estado = CboxEmpleadosEstado.SelectedItem?.ToString() ?? "Vigente"; // Asignar "Vigente" si no se selecciona nada

                // Validar y actualizar salario
                if (decimal.TryParse(txtEmpleadoSalario.Text, out decimal salario))
                {
                    empleado.Salario = salario;
                }
                else
                {
                    MessageBox.Show("El salario debe ser un valor numérico.");
                    return;
                }

                // Validar y actualizar fecha de inicio
                if (DateTime.TryParse(Dtpempleados.Text, out DateTime fechaInicio))
                {
                    empleado.FechaInicio = fechaInicio;
                }
                else
                {
                    MessageBox.Show("La fecha de inicio no es válida.");
                    return;
                }

                // Actualizar el DataGridView para reflejar los cambios
                dgvEmpleados.Refresh();
                MessageBox.Show("Empleado actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("Empleado no encontrado.");
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEmpleadoID.Text, out int id))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            Empleado empleado = empleados.FirstOrDefault(emp => emp.ID == id);
            if (empleado != null)
            {
                empleados.Remove(empleado);
                MessageBox.Show("Empleado eliminado.");
                GuardarEmpleadosEnCSV();
            }
            else
            {
                MessageBox.Show("Empleado no encontrado.");
            }
        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("ID, Nombre, Departamento, Cargo, FechaInicio, Salario, Estado, TiempoEnEmpresa");

            foreach (var empleado in empleados)
            {
                csvContent.AppendLine($"{empleado.ID}, {empleado.Nombre}, {empleado.Departamento}, {empleado.Cargo}, {empleado.FechaInicio.ToShortDateString()}, {empleado.Salario}, {empleado.Estado}, {empleado.TiempoEnEmpresa}");
            }

            // Guardar el archivo CSV en el sistema
            System.IO.File.WriteAllText("empleados.csv", csvContent.ToString());
            MessageBox.Show("Archivo CSV exportado con éxito.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            GuardarEmpleadosEnCSV();
            Application.Exit();
        }
        private void GuardarEmpleadosEnCSV()
        {
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("ID,Nombre,Departamento,Cargo,FechaInicio,Salario,Estado");

            foreach (var empleado in empleados)
            {
                csvContent.AppendLine($"{empleado.ID},{empleado.Nombre},{empleado.Departamento},{empleado.Cargo},{empleado.FechaInicio:yyyy-MM-dd},{empleado.Salario},{empleado.Estado}");
            }
            File.WriteAllText(archivoCSV, csvContent.ToString());
        }
        private void CargarEmpleadosDesdeCSV()
        {
            if (File.Exists(archivoCSV))
            {
                var lineas = File.ReadAllLines(archivoCSV);
                empleados.Clear();

                for (int i = 1; i < lineas.Length; i++)
                {
                    var datos = lineas[i].Split(',');
                    if (datos.Length == 7)
                    {
                        empleados.Add(new Empleado
                        {
                            ID = int.Parse(datos[0]),
                            Nombre = datos[1],
                            Departamento = datos[2],
                            Cargo = datos[3],
                            FechaInicio = DateTime.Parse(datos[4]),
                            Salario = decimal.Parse(datos[5]),
                            Estado = datos[6]
                        });
                    }
                }
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void txtEmpleadoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            // Limpiar cualquier dato anterior en el DataGridView
            dgvEmpleados.Rows.Clear();

            // Agregar los empleados actualizados al DataGridView
            foreach (var empleado in empleados)
            {
                dgvEmpleados.Rows.Add(
                    empleado.ID,
                    empleado.Nombre,
                    empleado.Departamento,
                    empleado.Cargo,
                    empleado.FechaInicio.ToShortDateString(),
                    empleado.Salario.ToString("C"),
                    empleado.Estado,
                    empleado.TiempoEnEmpresa
                );
            }
        }
        private void ConfigurarDataGridView()
        {
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.Columns.Clear();

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ID" });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Departamento", DataPropertyName = "Departamento" });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cargo", DataPropertyName = "Cargo" });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha Inicio", DataPropertyName = "FechaInicio" });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Salario", DataPropertyName = "Salario" });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado", DataPropertyName = "Estado" });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "AFP", DataPropertyName = "AFP" });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ARS", DataPropertyName = "ARS" });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ISR", DataPropertyName = "ISR" });

            dgvEmpleados.DataSource = empleados;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpleadoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboxEmpleadosEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
