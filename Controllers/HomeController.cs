using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using senai_mvc.Models;

namespace senai_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Instâncias de Clientes
        Cliente cliente1 = new Cliente(1,"Neto Melo","000.000.000-00","netomelo.ti@gmail.com","Ralf");
        Cliente cliente2 = new Cliente(2,"Junior Silva","000.000.000-12","junior@gmail.com","Tropeço");
        Cliente cliente3 = new Cliente(3,"Lucas Menezes","000.000.000-23","lucas@gmail.com","Maya");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);

        ViewBag.listaClientes = listaClientes;

        // Instâncias de Fornecedores
        Fornecedor fornecedor1 = new Fornecedor(1,"MM LTDA","00.000.000/0000-00","mm.empresa");
        Fornecedor fornecedor2 = new Fornecedor(2,"J & A Comércio","00.000.000/0000-12","jea.empresa");
        Fornecedor fornecedor3 = new Fornecedor(3,"Higiene e Beleza","00.000.000/0000-23","higbel.empresa");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);


        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
