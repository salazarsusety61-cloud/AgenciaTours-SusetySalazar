using System;
using System.Collections.Generic;
using System.Linq;

namespace AgenciaTours.Logica
{
    public class GestorReservas
    {
        private List<Reserva> reservas = new List<Reserva>();

        public bool Agregar(Reserva r)
        {
            if (CuposDisponibles(r.Tour, r.FechaTour) < r.Personas)
                return false;
            reservas.Add(r);
            return true;
        }

        public int CuposDisponibles(string tour, DateTime fecha)
        {
            int ocupadas = 0;
            foreach (var r in reservas)
            {
                if (r.Tour == tour && r.FechaTour.Date == fecha.Date)
                    ocupadas += r.Personas;
            }
            return 20 - ocupadas;
        }

        public void Eliminar(int indice)
        {
            if (indice >= 0 && indice < reservas.Count)
                reservas.RemoveAt(indice);
        }

        public List<Reserva> ObtenerTodas()
        {
            return new List<Reserva>(reservas);
        }

        public List<Reserva> FiltrarPorEstado(string estado)
        {
            return reservas.Where(r => r.Estado == estado).ToList();
        }

        public decimal CalcularIngresos()
        {
            decimal total = 0;
            foreach (var r in reservas) total += r.Total;
            return total;
        }

        public int ContarAventura()
        {
            int c = 0;
            foreach (var r in reservas) if (r is ReservaAventura) c++;
            return c;
        }

        public int ContarCultural()
        {
            int c = 0;
            foreach (var r in reservas) if (r is ReservaCultural) c++;
            return c;
        }

        public int ContarPersonas()
        {
            int t = 0;
            foreach (var r in reservas) t += r.Personas;
            return t;
        }

        public int ContarProximas()
        {
            int c = 0;
            foreach (var r in reservas)
                if (r.Estado == "Hoy" || r.Estado == "Próximo") c++;
            return c;
        }
    }
}
