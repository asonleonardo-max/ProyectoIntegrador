using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using ProyectoIntegrador.Controllers;
using ProyectoIntegrador.Models;

namespace ProyectoIntegrador.Views
{
    public partial class FormFactura : Form
    {
        FacturaController facturaController = new FacturaController();
        CotizacionController cotizacionController = new CotizacionController();
        Factura facturaSeleccionada = null;
        public FormFactura()
        {
            InitializeComponent();
            cbFiltroEstado.SelectedIndex = 0;
            CargarCotizaciones();
            CargarDgv();
            LimpiarLabels();
        }

        private void CargarCotizaciones()
        {
            cbListaCotizaciones.DataSource = cotizacionController.Leer().Where(c => c.Activa).ToList();
            cbListaCotizaciones.DisplayMember = "ClienteNombre";
            cbListaCotizaciones.ValueMember = "Id";
            cbListaCotizaciones.SelectedIndex = -1;
        }

        private void CargarDgv()
        {
            dgvFactura.Rows.Clear();

            foreach (Factura f in facturaController.Leer())
            {
                dgvFactura.Rows.Add(
                    f.Id,
                    f.NumeroFactura,
                    f.Cotizacion.ClienteNombre,
                    string.Join(", ", f.Cotizacion.Detalles.Select(d => d.NombreMaterial)),
                    f.Cotizacion.Total.ToString("C"),
                    f.Fecha.ToString("dd/MM/yyyy"),
                    f.Activa
                );
            }

            dgvFactura.ClearSelection();
        }

        private void CbListaCotizaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbListaCotizaciones.SelectedIndex == -1) return;
            if (cbListaCotizaciones.SelectedItem is not Cotizacion c) return;

            lblCliente.Text = "Cliente: " + c.ClienteNombre;
            lblMaterial.Text = "Materiales: " + string.Join(", ", c.Detalles.Select(d => d.NombreMaterial));
            lblVolumen.Text = "Volumen total: " + c.Detalles.Sum(d => d.Cantidad).ToString("N2") + " m³";
            lblSubtotal.Text = "Subtotal: " + c.Subtotal.ToString("C");
            lblIVA.Text = "IVA: " + c.IVA.ToString("C");
            lblTotal.Text = "Total: " + c.Total.ToString("C");
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            if (cbListaCotizaciones.SelectedItem is not Cotizacion cotizacion)
            {
                MessageBox.Show("Selecciona una cotización.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                facturaController.CrearDesdeCotizacion(cotizacion);
                MessageBox.Show("Factura creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarLabels();
                CargarDgv();
                CargarCotizaciones();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvFactura.CurrentRow == null) return;

            string id = dgvFactura.CurrentRow.Cells["colId"].Value?.ToString();
            facturaSeleccionada = facturaController.Leer().FirstOrDefault(f => f.Id == id);
            if (facturaSeleccionada == null) return;

            lblCliente.Text = "Cliente: " + facturaSeleccionada.Cotizacion.ClienteNombre;
            lblMaterial.Text = "Materiales: " + string.Join(", ", facturaSeleccionada.Cotizacion.Detalles.Select(d => d.NombreMaterial));
            lblVolumen.Text = "Volumen total: " + facturaSeleccionada.Cotizacion.Detalles.Sum(d => d.Cantidad).ToString("N2") + " m³";
            lblSubtotal.Text = "Subtotal: " + facturaSeleccionada.Cotizacion.Subtotal.ToString("C");
            lblIVA.Text = "IVA: " + facturaSeleccionada.Cotizacion.IVA.ToString("C");
            lblTotal.Text = "Total: " + facturaSeleccionada.Cotizacion.Total.ToString("C");
        }

        private void BtnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (facturaSeleccionada == null)
            {
                MessageBox.Show("Selecciona una factura del historial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            facturaController.CambiarEstado(facturaSeleccionada.Id);
            facturaSeleccionada = null;
            CargarDgv();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string cliente = txtFiltroCliente.Text.Trim();
            DateTime? fecha = null;
            bool? activa = null;

            // Solo filtra por fecha si el usuario la cambió
            if (dtpFiltroFecha.Value.Date != DateTime.Today)
                fecha = dtpFiltroFecha.Value.Date;

            if (cbFiltroEstado.SelectedItem?.ToString() == "Activa")
                activa = true;
            else if (cbFiltroEstado.SelectedItem?.ToString() == "Inactiva")
                activa = false;

            List<Factura> lista = facturaController.Filtrar(cliente, fecha, activa);

            dgvFactura.Rows.Clear();

            foreach (Factura f in lista)
            {
                dgvFactura.Rows.Add(
                    f.Id,
                    f.NumeroFactura,
                    f.Cotizacion.ClienteNombre,
                    string.Join(", ", f.Cotizacion.Detalles.Select(d => d.NombreMaterial)),
                    f.Cotizacion.Total.ToString("C"),
                    f.Fecha.ToString("dd/MM/yyyy"),
                    f.Activa
                );
            }

            dgvFactura.ClearSelection();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (facturaSeleccionada == null)
            {
                MessageBox.Show("Selecciona una factura del historial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = $"Factura_{facturaSeleccionada.NumeroFactura}.pdf"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                GenerarPDF(facturaSeleccionada, dialog.FileName);
                MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(dialog.FileName) { UseShellExecute = true });
            }
        }

        private void GenerarPDF(Factura f, string ruta)
        {
            //fuentes 
            var bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            var normal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            using PdfWriter writer = new PdfWriter(ruta);       //crea el archivo PDF o ruta 
            using PdfDocument pdf = new PdfDocument(writer);    //crea el documento
            using Document doc = new Document(pdf);             //crea el documento visual

            doc.Add(new Paragraph("FACTURA").SetFont(bold).SetFontSize(20));
            doc.Add(new Paragraph($"N° Factura: {f.NumeroFactura}").SetFont(normal));
            doc.Add(new Paragraph($"Fecha: {f.Fecha:dd/MM/yyyy}").SetFont(normal));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("DATOS DEL CLIENTE").SetFont(bold));
            doc.Add(new Paragraph($"Cliente: {f.Cotizacion.ClienteNombre}").SetFont(normal));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("DETALLE").SetFont(bold));
            foreach (var detalle in f.Cotizacion.Detalles)
            {
                doc.Add(new Paragraph($"Material: {detalle.NombreMaterial}").SetFont(normal));
                doc.Add(new Paragraph($"Volumen: {detalle.Cantidad:N2} m³").SetFont(normal));
                doc.Add(new Paragraph($"Precio unitario: {detalle.Precio:C}").SetFont(normal));
                doc.Add(new Paragraph($"Subtotal: {detalle.Subtotal:C}").SetFont(normal));
                doc.Add(new Paragraph("─────────────────────").SetFont(normal));
            }
            doc.Add(new Paragraph($"Subtotal: {f.Cotizacion.Subtotal:C}").SetFont(normal));
            doc.Add(new Paragraph($"IVA (19%): {f.Cotizacion.IVA:C}").SetFont(normal));
            doc.Add(new Paragraph($"TOTAL: {f.Cotizacion.Total:C}").SetFont(bold).SetFontSize(14));
        }

        private void LimpiarLabels()
        {
            lblCliente.Text = "Cliente: ";
            lblMaterial.Text = "Material: ";
            lblVolumen.Text = "Volumen: ";
            lblSubtotal.Text = "Subtotal: ";
            lblIVA.Text = "IVA: ";
            lblTotal.Text = "Total: ";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
