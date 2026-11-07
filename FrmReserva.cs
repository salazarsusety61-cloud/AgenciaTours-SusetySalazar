using System;
using System.Windows.Forms;
using AgenciaTours.Logica;

namespace AgenciaTours.Interfaz
{
    public partial class FrmReserva : Form
    {
        public Reserva ReservaCreada { get; private set; }

        public FrmReserva()
        {
            InitializeComponent();

            this.AcceptButton = btnAceptar;
            this.CancelButton = btnCancelar;

            CargarTours();
          
            lstIdioma.Enabled = false;

            txtPersonas.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            };

            lstTours.SelectedIndexChanged += lstTours_SelectedIndexChanged;
            btnAceptar.Click += btnAceptar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private void CargarTours()
        {
            lstTours.Items.Clear();
            for (int i = 0; i < CatalogoTours.Cantidad; i++)
                lstTours.Items.Add(CatalogoTours.ObtenerNombre(i));
        }

        private void lstTours_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTours.SelectedIndex == -1) return;
            int idx = lstTours.SelectedIndex;
            lblTipo.Text = $"Tipo: {CatalogoTours.ObtenerTipo(idx)}";
            lblPrecio.Text = $"Precio: ₡{CatalogoTours.ObtenerPrecio(idx):N2}";
            lblDificultad.Text = $"Dificultad: {CatalogoTours.ObtenerDificultad(idx)}";
            lstIdioma.Enabled = CatalogoTours.ObtenerTipo(idx) == "Cultural";
            if (!lstIdioma.Enabled) lstIdioma.ClearSelected();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            int indice = lstTours.SelectedIndex;
            string nombreTour = CatalogoTours.ObtenerNombre(indice);
            decimal precio = CatalogoTours.ObtenerPrecio(indice);
            int personas = int.Parse(txtPersonas.Text);
            DateTime fecha = dtpFechaTour.Value.Date;

            if (CatalogoTours.ObtenerTipo(indice) == "Aventura")
            {
                ReservaCreada = new ReservaAventura(
                    txtCliente.Text.Trim(), nombreTour, precio, personas, fecha,
                    CatalogoTours.ObtenerDificultad(indice));
            }
            else
            {
                ReservaCreada = new ReservaCultural(
                    txtCliente.Text.Trim(), nombreTour, precio, personas, fecha,
                    lstIdioma.SelectedItem.ToString());
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidarCampos()
        {
            errorProvider1.Clear();
            bool ok = true;

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                errorProvider1.SetError(txtCliente, "Escriba el nombre del cliente.");
                ok = false;
            }
            else if (txtCliente.Text.Trim().Length < 3 || txtCliente.Text.Trim().Length > 40)
            {
                errorProvider1.SetError(txtCliente, "El nombre debe tener entre 3 y 40 caracteres.");
                ok = false;
            }

            if (lstTours.SelectedIndex == -1)
            {
                errorProvider1.SetError(lstTours, "Seleccione un tour.");
                ok = false;
            }

            if (!int.TryParse(txtPersonas.Text, out int p) || p < 1 || p > 20)
            {
                errorProvider1.SetError(txtPersonas, "La cantidad debe estar entre 1 y 20.");
                ok = false;
            }

            if (dtpFechaTour.Value.Date < DateTime.Today)
            {
                errorProvider1.SetError(dtpFechaTour, "La fecha no puede estar en el pasado.");
                ok = false;
            }
            if (dtpFechaTour.Value.Date > DateTime.Today.AddYears(1))
            {
                errorProvider1.SetError(dtpFechaTour, "Máximo un año de anticipación.");
                ok = false;
            }

            if (lstIdioma.Enabled && lstIdioma.SelectedIndex == -1)
            {
                errorProvider1.SetError(lstIdioma, "Seleccione el idioma del guía.");
                ok = false;
            }

            return ok;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
