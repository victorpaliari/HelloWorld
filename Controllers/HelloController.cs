using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("~/")]
    //como se fosse a homepage da aplicação
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello Turma . NET 03!";
        }

        [HttpGet("/meunome")]
        public string MeuNome()
        {
            return "Victor Paliari";
        }
    }
}
