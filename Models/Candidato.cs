public class Candidato{
    public int IdCandidato {get;set;}
    public int IdPartido {get;set;}
    public string Apellido {get;set;}
    public string Nombre {get;set;}
    public DateTime FechaNacimiento {get;set;}
    public string Foto {get;set;}
    public string Postulacion {get;set;}
    public Candidato(){}
    
    public Candidato(int idcandidato, int idpartido, string apellido, string nombre, DateTime nacimiento, string foto, string postulacion){
        IdCandidato = idcandidato;
        IdPartido = idpartido;
        Apellido = apellido;
        Nombre = nombre;
        FechaNacimiento = nacimiento;
        Foto = foto;
        Postulacion = postulacion;
    }
} 