namespace AgenciaTours.Logica
{
    public static class CatalogoTours
    {
        public static string ObtenerNombre(int indice)
        {
            return indice switch
            {
                0 => "Vuelo sobre el Bosque Nuboso",
                1 => "Corrientes del Caribe",
                2 => "Caminata entre Fumarolas",
                3 => "Aromas del Valle del Café",
                4 => "Sabor Bribri en Talamanca",
                5 => "Historia en San José",
                _ => "Desconocido"
            };
        }

        public static string ObtenerTipo(int indice)
        {
            return indice < 3 ? "Aventura" : "Cultural";
        }

        public static decimal ObtenerPrecio(int indice)
        {
            return indice switch
            {
                0 => 35000m,
                1 => 55000m,
                2 => 28000m,
                3 => 24000m,
                4 => 30000m,
                5 => 18000m,
                _ => 0
            };
        }

        public static string ObtenerDificultad(int indice)
        {
            return indice switch
            {
                0 => "Media",
                1 => "Alta",
                2 => "Baja",
                _ => ""
            };
        }

        public static int Cantidad => 6;
    }
}
