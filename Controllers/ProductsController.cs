namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Entities;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Milo" },
        new Product { Id = 2, Name = "Tim Tams" }
    };

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_products);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var product = _products.Find(x => x.Id == id);
        if (product == null)
            return NotFound();

        return Ok(product);
    }
}
