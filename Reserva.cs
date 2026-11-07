using System;

namespace AgenciaTours.Logica
{
    public class Reserva
    {
        private string _cliente;
        public string Cliente
        {
            get => _cliente;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Trim().Length >= 3 && value.Trim().Length <= 40)
                    _cliente = value.Trim();
            }
        }

        public string Tour { get; set; }

        private decimal _precioPorPersona;
        public decimal PrecioPorPersona
        {
            get => _precioPorPersona;
            set
            {
                if (value >= 0) _precioPorPersona = value;
            }
        }

        private int _personas;
        public int Personas
        {
            get => _personas;
            set
            {
                if (value >= 1 && value <= 20) _personas = value;
            }
        }

        public DateTime FechaTour { get; set; }
        public DateTime FechaRegistro { get; private set; }

        public Reserva(string cliente, string tour, decimal precioPorPersona, int personas, DateTime fechaTour)
        {
            Cliente = cliente;
            Tour = tour;
            PrecioPorPersona = precioPorPersona;
            Personas = personas;
            FechaTour = fechaTour;
            FechaRegistro = DateTime.Now;
        }

        public virtual string Tipo => "General";
        public decimal Subtotal => PrecioPorPersona * Personas;

        public int DiasAnticipacion => (FechaTour.Date - FechaRegistro.Date).Days;

        public virtual decimal Descuento
        {
            get
            {
                if (Personas >= 6) return Subtotal * 0.10m;
                if (DiasAnticipacion >= 30) return Subtotal * 0.05m;
                return 0;
            }
        }

        public virtual decimal Cargo => 0;

        public decimal Iva => (Subtotal - Descuento + Cargo) * 0.13m;

        public decimal Total => Subtotal - Descuento + Cargo + Iva;

        public int DiasParaTour => (FechaTour.Date - DateTime.Today).Days;

        public string Estado
        {
            get
            {
                int d = DiasParaTour;
                if (d < 0) return "Realizado";
                if (d == 0) return "Hoy";
                if (d <= 7) return "Próximo";
                return "Programado";
            }
        }
    }
}
