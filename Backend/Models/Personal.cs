namespace Backend.Models
{
    public class Personal
    {
        public int _dni { get; set; }
        public int _idGrado { get; set; }
        public string _idArmEsp { get; set; }
        public string _apellido { get; set; }
        public string _nombre { get; set; }
        public string? _sNombre { get; set; }
        public string _destino { get; set; }
        public string _email { get; set; }
        public Grado? _idGrado { get; set; }
        public ArmEsp? _idArmEsp { get; set; }
        
        public Personal(int dni, int idGrado, string idArmEsp, string apellido, string nombre, string sNombre, string destino, string email)
        {
            this._dni = dni;
            this._idGrado = idGrado;
            this._idArmEsp = idArmEsp;
            this._apellido = apellido;
            this._nombre = nombre;
            this._sNombre = sNombre;
            this._destino = destino;
            this._email = email;
        }
    
    }
}