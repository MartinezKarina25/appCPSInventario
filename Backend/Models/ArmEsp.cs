namespace Backend.Models
{
    public class ArmEsp
    {
        public int _id { get; set; }
        public string _abreviatutra { get; set; }
        public string? _armEsp { get; set; }
        
        public ArmEsp(int id, string abreviatura, string armesp)
        {
            this._id = id;
            this._abreviatutra = abreviatura;
            this._armEsp = armesp;
        }
    
    }
}