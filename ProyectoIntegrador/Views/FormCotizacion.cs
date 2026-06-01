using ProyectoIntegrador.Controllers;
using ProyectoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoIntegrador.Views
{
    public partial class FormCotizacion : Form
    {
        CotizacionController cotizacionController = new CotizacionController();
        ClienteController clienteController = new ClienteController();
        MaterialController materialController = new MaterialController();
        TerrenoController terrenoController = new TerrenoController();

        string idSeleccionado = "";

        public FormCotizacion()
        {
            InitializeComponent();
            CargarCombos();
            CargarTabla();
        }

        private void CargarCombos()
        {
            List<Cliente> clientes = clienteController.Leer();
            cbListaClientes.DataSource = clientes;
            cbListaClientes.DisplayMember = "Nombre";
            cbListaClientes.ValueMember = "Id";

            List<Material> materiales = materialController.Leer();
            cbListaMateriales.DataSource = materiales;
            cbListaMateriales.DisplayMember = "Nombre";
            cbListaMateriales.ValueMember = "Id";

            List<Terreno> terrenos = terrenoController.Leer();
            cbListaTerrenos.DataSource = terrenos;
            cbListaTerrenos.DisplayMember = "Nombre";
            cbListaTerrenos.ValueMember = "Id";
        }

        // Cuando selecciona terreno → carga el volumen en numCantidad
        private void CbListaTerrenos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbListaTerrenos.SelectedItem == null) return;

            Terreno terreno = (Terreno)cbListaTerrenos.SelectedItem;
            numCantidad.Value = (decimal)terreno.VolumenCalculado;
        }

        private void CargarTabla()
        {
            dgvCotizacion.Rows.Clear();

            List<Cotizacion> lista = cotizacionController.Leer();

            foreach (Cotizacion c in lista)
            {
                int fila = dgvCotizacion.Rows.Add();
                dgvCotizacion.Rows[fila].Cells["colId"].Value = c.Id;
                dgvCotizacion.Rows[fila].Cells["colCliente"].Value = c.ClienteNombre;
                dgvCotizacion.Rows[fila].Cells["colMaterial"].Value = c.NombreMaterial;
                dgvCotizacion.Rows[fila].Cells["colCantidad"].Value = c.Cantidad;
                dgvCotizacion.Rows[fila].Cells["colPrecio"].Value = c.PrecioUnitario;
                dgvCotizacion.Rows[fila].Cells["colSubtotal"].Value = c.Subtotal;
                dgvCotizacion.Rows[fila].Cells["colIVA"].Value = c.IVA;
                dgvCotizacion.Rows[fila].Cells["colTotal"].Value = c.Total;
                dgvCotizacion.Rows[fila].Cells["colFecha"].Value = c.Fecha.ToString("dd/MM/yyyy");
                dgvCotizacion.Rows[fila].Cells["colEstado"].Value = c.Activa;
            }
        }

        private void dgvCotizacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvCotizacion.CurrentRow == null) return;

            idSeleccionado = dgvCotizacion.CurrentRow.Cells["colId"].Value.ToString();

            Cotizacion? cotizacion = cotizacionController.Leer()
                .FirstOrDefault(x => x.Id == idSeleccionado);

            if (cotizacion == null) return;

            cbListaClientes.SelectedValue = cotizacion.ClienteId;
            cbListaMateriales.SelectedValue = cotizacion.MaterialId;

            numCantidad.Value = (decimal)cotizacion.Cantidad;
            dateFecha.Value = cotizacion.Fecha;
            checkBoxEstado.Checked = cotizacion.Activa;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbListaClientes.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona un cliente.", "Campo requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbListaTerrenos.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona un terreno.", "Campo requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbListaMateriales.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona un material.", "Campo requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (numCantidad.Value <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a 0.", "Dato inválido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cliente cliente = (Cliente)cbListaClientes.SelectedItem;
                Material material = (Material)cbListaMateriales.SelectedItem;
                double cantidad = (double)numCantidad.Value;
                double subtotal = cantidad * material.CostoPorMetroCubico;
                double iva = subtotal * 0.19;
                double total = subtotal + iva;

                Cotizacion cotizacion = new Cotizacion
                {
                    Id = idSeleccionado == "" ? Guid.NewGuid().ToString() : idSeleccionado,
                    ClienteId = cliente.Id,
                    ClienteNombre = cliente.Nombre,
                    MaterialId = material.Id,
                    NombreMaterial = material.Nombre,
                    Cantidad = cantidad,
                    PrecioUnitario = material.CostoPorMetroCubico,
                    Subtotal = subtotal,
                    IVA = iva,
                    Total = total,
                    Fecha = dateFecha.Value,
                    Activa = checkBoxEstado.Checked
                };

                if (idSeleccionado == "")
                {
                    cotizacionController.Guardar(cotizacion);
                    MessageBox.Show("Cotización guardada correctamente.",
                        "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cotizacionController.Actualizar(cotizacion);
                    MessageBox.Show("Cotización actualizada correctamente.",
                        "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Limpiar();
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSeleccionado == "")
                {
                    MessageBox.Show("Selecciona una cotización de la tabla.", "Sin selección",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Desea eliminar esta cotización?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cotizacionController.Eliminar(idSeleccionado);
                    MessageBox.Show("Cotización eliminada.", "Eliminado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            idSeleccionado = "";
            numCantidad.Value = 0;
            checkBoxEstado.Checked = false;
            dateFecha.Value = DateTime.Now;
        }
    }
    
}
