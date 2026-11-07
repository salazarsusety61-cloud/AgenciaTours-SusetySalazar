using System;

namespace AgenciaTours.Logica
{
    public class ReservaAventura : Reserva
    {
        public string Dificultad { get; set; }

        public ReservaAventura(string cliente, string tour, decimal precio, int personas, DateTime fechaTour, string dificultad)
            : base(cliente, tour, precio, personas, fechaTour)
        {
            Dificultad = dificultad;
        }

        public override string Tipo => "Aventura";

        public override decimal Cargo => 3000m * Personas;
    }
}
