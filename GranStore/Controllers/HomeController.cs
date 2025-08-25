using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<Produto> produtos; 

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;

        List<Categoria> categorias = new()
        {
            new Categoria { Id = 1, Nome = "Livro"},
            new Categoria { Id = 2, Nome = "Marcadores"},
        };

        produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Café com teu Pai", Descricao = "Livro de Ajuda", Categoria = categorias[0], QtdeEstoque = 13, ValorCusto = 100.00m, ValorVenda = 200.00m, Foto = "/img/produtos/1.png"},
            new Produto { Id = 2, Nome = "Marcador de Coração", Descricao = "Marcador util para livros", Categoria = categorias[1], QtdeEstoque = 13, ValorCusto = 100.00m, ValorVenda = 200.00m, Foto = "/img/produtos/2.png"},
            new Produto { Id = 3, Nome = "Marcador de Flor", Descricao = "Marcador util para livros", Categoria = categorias[1], QtdeEstoque = 13, ValorCusto = 100.00m, ValorVenda = 200.00m, Foto = "/img/produtos/3.png"},
            new Produto { Id = 4, Nome = "Marcador Gravata", Descricao = "Marcador util para livros", Categoria = categorias[1], QtdeEstoque = 13, ValorCusto = 100.00m, ValorVenda = 200.00m, Foto = "/img/produtos/4.png"},
            new Produto { Id = 5, Nome = "Marcador Joaninha", Descricao = "Marcador util para livros", Categoria = categorias[1], QtdeEstoque = 13, ValorCusto = 100.00m, ValorVenda = 200.00m, Foto = "/img/produtos/5.png"},
            new Produto { Id = 6, Nome = "Marcador Liso Azul", Descricao = "Marcador util para livros", Categoria = categorias[1], QtdeEstoque = 13, ValorCusto = 100.00m, ValorVenda = 200.00m, Foto = "/img/produtos/6.png"},
            new Produto { Id = 7, Nome = "Marcador com Textura Xadrez", Descricao = "Marcador util para livros", Categoria = categorias[1], QtdeEstoque = 13, ValorCusto = 100.00m, ValorVenda = 200.00m, Foto = "/img/produtos/7.png"},
            new Produto { Id = 8, Nome = "Marcador de Xicara de Café", Descricao = "Marcador util para livros", Categoria = categorias[1], QtdeEstoque = 13, ValorCusto = 100.00m, ValorVenda = 200.00m, Foto = "/img/produtos/8.png"},
        };
    }

    public IActionResult Index()
    {
        return View(produtos);
    }

    public IActionResult Produto(int id)
    {
        var produto = produtos.SingleOrDefault(p => p.Id == id);
        return View(produto);
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
