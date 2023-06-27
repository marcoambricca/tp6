public class Partido{
    public int IdPartido {get;set;}
    public string Nombre {get;set;}
    public string Logo {get;set;}
    public string SitioWeb {get;set;}
    public DateTime FechaFundacion {get;set;}
    public int CantidadDiputados {get;set;}
    public int CantidadSenadores {get;set;}
 
  public Partido(){}
  public Partido(int idpartido, string nombre, string logo, string sitioweb, DateTime fundacion, int cantdiputados, int cantsenadores){
    IdPartido = idpartido;
    Nombre = nombre;
    Logo = logo;
    SitioWeb = sitioweb;
    FechaFundacion = fundacion;
    CantidadDiputados = cantdiputados;
    CantidadSenadores = cantsenadores;
  }
}