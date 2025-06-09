namespace AdmVeterinaria.Clases
{
    public class Atencion
    {
        public string TipoAtencion { get; set; }
        public string Motivo {  get; set; }
        public string TratamientoRebicido { get; set; }
        public string Medicamentos {  get; set; }
        public DateTime Fecha { get; set; }
        public Animal Animal { get; set; }
    }
}
