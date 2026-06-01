using ProyectoIntegrador.Controllers;
using ProyectoIntegrador.Models;

namespace ProyectoIntegrador.Views
{
    public partial class FormTerreno : Form
    {

        TerrenoController controller = new TerrenoController();
        List<Coordenada> coordenadas = new List<Coordenada>();
        double volumenCalculado = 0;

        public FormTerreno()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCoordenadaX.Text.Trim(), out double x) ||
                !double.TryParse(txtCoordenadaY.Text.Trim(), out double y) ||
                !double.TryParse(txtCoordenadaZ.Text.Trim(), out double z))
            {
                MessageBox.Show("Ingresa valores numéricos válidos para X, Y y Z.",
                    "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Coordenada nuevaCoordenada = new Coordenada(x, y, z);
            coordenadas.Add(nuevaCoordenada);
            lstCoordenadas.Items.Add(nuevaCoordenada.ToString());

            txtCoordenadaX.Clear();
            txtCoordenadaY.Clear();
            txtCoordenadaZ.Clear();
            txtCoordenadaX.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCoordenadas.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona una coordenada de la lista.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = lstCoordenadas.SelectedIndex;
            coordenadas.RemoveAt(index);
            lstCoordenadas.Items.RemoveAt(index);
            lbVolumen.Text = "Volumen calculado:";
            volumenCalculado = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (coordenadas.Count < 3)
            {
                MessageBox.Show("Agrega al menos 3 coordenadas para calcular el volumen.",
                    "Coordenadas insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            volumenCalculado = controller.CalcularVolumen(coordenadas);

            // Calcular detalles para mostrar
            double sumaZ = 0;
            double xMin = double.MaxValue, xMax = double.MinValue;
            double yMin = double.MaxValue, yMax = double.MinValue;

            foreach (Coordenada c in coordenadas)
            {
                sumaZ += c.Z;
                if (c.X < xMin) xMin = c.X;
                if (c.X > xMax) xMax = c.X;
                if (c.Y < yMin) yMin = c.Y;
                if (c.Y > yMax) yMax = c.Y;
            }

            double alturaPromedio = sumaZ / coordenadas.Count;
            double area = (xMax - xMin) * (yMax - yMin);

            lbVolumen.Text = $"Volumen calculado: {volumenCalculado:N2} m³";

            MessageBox.Show(
                $"Malla generada: 2.500 celdas (50×50)\n" +
                $"Área del terreno: {area:N2} m²\n" +
                $"Altura promedio: {alturaPromedio:N2} m\n\n" +
                $"Volumen calculado: {volumenCalculado:N2} m³",
                "Resultado del cálculo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /* MostrarGrafica();*/
        }

        /* private void MostrarGrafica()
         {
             var modelo = new PlotModel { Title = "Terreno - Vista de coordenadas" };

             var serie = new ScatterSeries
             {
                 MarkerType = MarkerType.Circle,
                 MarkerSize = 6,
                 Title = "Puntos del terreno"
             };

             foreach (Coordenada c in coordenadas)
             {
                 serie.Points.Add(new ScatterPoint(c.X, c.Y, 6, c.Z));
             }

             modelo.Series.Add(serie);
             plotView1.Model = modelo;
         }*/

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresa un nombre para el terreno.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (coordenadas.Count < 3)
            {
                MessageBox.Show("Agrega al menos 3 coordenadas.",
                    "Coordenadas insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (volumenCalculado == 0)
            {
                MessageBox.Show("Primero calcula el volumen antes de guardar.",
                    "Sin cálculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Terreno terreno = new Terreno
            {
                Nombre = txtNombre.Text.Trim(),
                Coordenadas = new List<Coordenada>(coordenadas),
                VolumenCalculado = volumenCalculado
            };

            controller.Guardar(terreno);

            MessageBox.Show("Terreno guardado correctamente.",
                "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar();
        }

        private void Limpiar()
        {
            coordenadas.Clear();
            lstCoordenadas.Items.Clear();
            txtCoordenadaX.Clear();
            txtCoordenadaY.Clear();
            txtCoordenadaZ.Clear();
            txtNombre.Clear();
            lbVolumen.Text = "Volumen calculado:";
            volumenCalculado = 0;
            // plotView1.Model = null;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}