using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetClientes()
        {
            Cliente c1 = new Cliente(1, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c2 = new Cliente(2, "João", "joao@example.com", "2345-6789", new DateOnly(1999, 12, 3));
            Cliente c3 = new Cliente(3, "Eduarda", "eduarda@example.com", "3456-7890", new DateOnly(2001, 4, 15));
            Cliente c4 = new Cliente(4, "Mario", "mario@example.com", "4567-8901", new DateOnly(1991, 5, 13));
            Cliente c5 = new Cliente(5, "Laura", "laura@example.com", "5678-9012", new DateOnly(1997, 11, 24));

            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes.Add(c1);
            listaClientes.Add(c2);
            listaClientes.Add(c3);
            listaClientes.Add(c4);
            listaClientes.Add(c5);

            return View(listaClientes);
        }
    }
}
