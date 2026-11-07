using System;

namespace AgenciaTours.Logica
{
    public class ReservaCultural : Reserva
    {
        public string IdiomaGuia { get; set; }

        public ReservaCultural(string cliente, string tour, decimal precio, int personas, DateTime fechaTour, string idiomaGuia)
            : base(cliente, tour, precio, personas, fechaTour)
        {
            IdiomaGuia = idiomaGuia;
        }

        public override string Tipo => "Cultural";

        public override decimal Cargo
        {
            get
            {
                if (IdiomaGuia == "Inglés") return 2500m * Personas;
                return 0;
            }
        }
    }
}
