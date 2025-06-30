
using Microsoft.AspNetCore.Mvc;
using LanchoneteMVC.Models;

namespace LanchoneteMVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IRepository<Produto> _produtoRepository;

        public ProdutoController(IRepository<Produto> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            var produtos = _produtoRepository.GetAll();
            return View(produtos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _produtoRepository.Add(produto);
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }
    }
}
