using System;
using System.Linq;
using System.Windows.Forms;
using AgenciaTours.Logica;
using AgenciaTours.Interfaz;

namespace AgenciaTours
{
    public partial class Form1 : Form
    {
        private GestorReservas gestor = new GestorReservas();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Naturaleza y Aventura CR";
            lblTitulo.Text = "🌿 Naturaleza y Aventura CR";
            lblFecha.Text = DateTime.Now.ToString("dddd dd 'de' MMMM 'de' yyyy");
            RefrescarTabla();
            ActualizarResumen();
            dgvReservas.ReadOnly = true;
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            using (FrmReserva frm = new FrmReserva())
            {
                if (frm.ShowDialog() == DialogResult.OK && frm.ReservaCreada != null)
                {
                    if (gestor.Agregar(frm.ReservaCreada))
                    {
                        RefrescarTabla();
                        ActualizarResumen();
                    }
                    else
                    {
                        int libres = gestor.CuposDisponibles(frm.ReservaCreada.Tour, frm.ReservaCreada.FechaTour);
                        MessageBox.Show($"No hay cupo: quedan {libres} espacios.", "Sin cupo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idx = dgvReservas.SelectedRows[0].Index;
            var todas = gestor.ObtenerTodas();
            if (idx >= todas.Count) return;
            Reserva r = todas[idx];

            string extra = "";
            if (r is ReservaAventura av) extra = $"Dificultad: {av.Dificultad}";
            if (r is ReservaCultural cu) extra = $"Idioma: {cu.IdiomaGuia}";

            MessageBox.Show(
                $"Cliente: {r.Cliente}\n" +
                $"Tour: {r.Tour}\n" +
                $"Tipo: {r.Tipo}\n" +
                $"{extra}\n" +
                $"Personas: {r.Personas}\n" +
                $"Fecha: {r.FechaTour:dd/MM/yyyy}\n" +
                $"Subtotal: ₡{r.Subtotal:N2}\n" +
                $"Descuento: ₡{r.Descuento:N2}\n" +
                $"Cargo: ₡{r.Cargo:N2}\n" +
                $"IVA: ₡{r.Iva:N2}\n" +
                $"TOTAL: ₡{r.Total:N2}\n" +
                $"Estado: {r.Estado}",
                "Detalle de la reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idx = dgvReservas.SelectedRows[0].Index;
            var lista = gestor.ObtenerTodas();
            if (idx >= lista.Count) return;

            if (MessageBox.Show($"¿Eliminar la reserva de {lista[idx].Cliente}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gestor.Eliminar(idx);
                RefrescarTabla();
                ActualizarResumen();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void RefrescarTabla()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = gestor.ObtenerTodas();
            dgvReservas.Columns["FechaRegistro"].Visible = false;
            dgvReservas.Columns["PrecioPorPersona"].Visible = false;
            dgvReservas.Columns["Subtotal"].Visible = false;
            dgvReservas.Columns["Descuento"].Visible = false;
            dgvReservas.Columns["Cargo"].Visible = false;
            dgvReservas.Columns["Iva"].Visible = false;
            dgvReservas.Columns["DiasAnticipacion"].Visible = false;
            dgvReservas.Columns["DiasParaTour"].Visible = false;
            dgvReservas.Columns["Total"].DefaultCellStyle.Format = "N2";
            dgvReservas.Columns["FechaTour"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void ActualizarResumen()
        {
            lblIngresos.Text = $"Ingresos totales: ₡{gestor.CalcularIngresos():N2}";
            lblResumen.Text =
                $"Aventura: {gestor.ContarAventura()}  |  " +
                $"Culturales: {gestor.ContarCultural()}  |  " +
                $"Personas: {gestor.ContarPersonas()}  |  " +
                $"Próximas: {gestor.ContarProximas()}";
        }
    }
}
