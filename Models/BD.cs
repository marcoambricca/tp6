using System.Data.SqlClient;
using Dapper;
public static class BD{

    private static string ConnectionString { get; set; } = @"Server=localhost;DataBase=Elecciones2023;Trusted_Connection=True;";
    public static void AgregarCandidato(Candidato candidato) {
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "INSERT INTO Candidato(IdPartido, Apellido, Nombre, FechaNacimiento, Foto, Postulacion) VALUES (@IdPartido, @Apellido, @Nombre, @FechaNacimiento, @Foto, @Postulacion)";
            db.Execute(sql, new { IdPartido = candidato.IdPartido, Apellido = candidato.Apellido, Nombre = candidato.Nombre, FechaNacimiento = candidato.FechaNacimiento, Foto = "img/"+candidato.Foto, Postulacion = candidato.Postulacion  });
        }
    }
    public static void EliminarCandidato(int idCandidato) {
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "DELETE FROM Candidato WHERE IdCandidato like @idCandidato";
            db.Execute(sql, new { idCandidato });
        }
    }
    public static Partido VerInfoPartido(int idPartido){
        Partido user = null;
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Partido WHERE IdPartido = @idPartido";
            user = db.QueryFirstOrDefault<Partido>(sql, new { idPartido });
        }
        return user;
    }
    public static Candidato VerInfoCandidato(int idCandidato){
        Candidato user = null;
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Candidato WHERE IdCandidato = @idCandidato";
            user = db.QueryFirstOrDefault<Candidato>(sql, new { idCandidato });
        }
        return user;
    }
    public static List<Partido> ListarPartidos(){
        List<Partido> user = null;
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Partido";
            user = db.Query<Partido>(sql).ToList();
        }
        return user;
    }
    public static List<Candidato> ListarCandidatos(int idPartido){
        List<Candidato> user = null;
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Candidato where IdPartido = @idPartido";
            user = db.Query<Candidato>(sql, new { idPartido }).ToList();
        }
        return user;
    }
}