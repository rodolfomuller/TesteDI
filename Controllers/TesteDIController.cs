using DI.Classes3;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class TesteDIController : ControllerBase
{

   private readonly IClasse3 classe3;      

    public TesteDIController(IClasse3 classe3){
        this.classe3 = classe3;
    }

    [HttpGet]
    [Route("teste")]
    public IActionResult ChamarClasse()
    {
        var classe1 = new Classe1(classe3);
        classe1.chamarClasse2Async();
        return Ok();
    }
}
