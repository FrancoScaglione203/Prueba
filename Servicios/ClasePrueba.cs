namespace Prueba.Servicios
{
    public class ClasePrueba
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }  //El signo de pregunta es para que acepte valores NULL
        public decimal Precio { get; set; }

        public decimal CalcularDescuento(decimal porcentaje)
        {
            return Precio * (1 - porcentaje / 100);
        }
    }
}
