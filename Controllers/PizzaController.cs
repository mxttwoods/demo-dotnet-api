using dotnet_api.Models;
using dotnet_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_api.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    [HttpGet(Name = "GetAllPizzas")]
    public List<Pizza> GetAll()
    {
        return PizzaService.GetAll();
    }

    // [HttpGet(Name = "GetPizzaById")]
    // public Pizza? Get(int id)
    // {
    //     return PizzaService.Get(id);
    // }

    [HttpPost(Name = "AddPizza")]
    public void Add(Pizza pizza)
    {
        PizzaService.Add(pizza);
    }

    [HttpPut(Name = "UpdatePizza")]
    public void Update(Pizza pizza)
    {
        PizzaService.Update(pizza);
    }

    [HttpDelete(Name = "DeletePizza")]
    public void Delete(int id)
    {
        PizzaService.Delete(id);
    }

}