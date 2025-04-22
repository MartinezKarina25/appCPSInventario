namespace Backend.Models
{
    public class Inventario
    {
        public string _nne { get; set; }
        public string _ine { get; set; }
        public string _unimed { get; set; }
        public string _grupo { get; set; }
        public string _cuenta { get; set; }
        public int _cantidad { get; set; }

        public Inventario(string nne, string ine, string unimed, string grupo, string cuenta, int cantidad)
        {
            this._nne = nne;
            this._ine = ine;
            this._unimed = unimed;
            this._grupo = grupo;
            this._cuenta = cuenta;
            this._cantidad = cantidad;
        }
    
    }
}