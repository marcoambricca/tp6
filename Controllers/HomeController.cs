using Microsoft.AspNetCore.Mvc;

namespace TPElecciones.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.partidos = BD.ListarPartidos();
        return View();
    }
    public IActionResult VerDetallePartido(int idPartido)
    {
        ViewBag.detallePartido = BD.VerInfoPartido(idPartido);
        ViewBag.listaCandidatos = BD.ListarCandidatos(idPartido);
        return View();
    }
    public IActionResult VerDetalleCandidato(int idCandidato)
    {
        ViewBag.detalleCandidato = BD.VerInfoCandidato(idCandidato);
        return View();
    }
    public IActionResult AgregarCandidato(int idPartido)
    {
        ViewBag.idPartido = idPartido;
        return View();
    }

    [HttpPost]
    public IActionResult GuardarCandidato(Candidato can)
    {
        BD.AgregarCandidato(can);
        ViewBag.detallePartido = BD.VerInfoPartido(can.IdPartido);
        ViewBag.listaCandidatos = BD.ListarCandidatos(can.IdPartido);
        return View("VerDetallePartido");
    }

    public IActionResult EliminarCandidato(int idCandidato, int idPartido){
        BD.EliminarCandidato(idCandidato);
        ViewBag.detallePartido = BD.VerInfoPartido(idPartido);
        ViewBag.listaCandidatos = BD.ListarCandidatos(idPartido);
        return View("VerDetallePartido");
    }
    public IActionResult Elecciones(){
        ViewBag.Candidatos = BD.ListarPartidos();
        return View();
    }
}
