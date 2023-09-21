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
        [HttpGet("/bsms")]
        public string Bsm()
        {
            return "As BSM's são: " +
                "\nBSM 1 - Responsabilidade Pessoal" +
                "\nBSM 2 - Mentalidade de Crescimento" +
                "\nBSM 3 - Orientação ao futuro" +
                "\nBSM 4 - Persistência" +
                "\nBSM 5 - Comunicação" +
                "\nBSM 6 - Orientação ao detalhe" +
                "\nBSM 7 - Trabalho em equipe" +
                "\nBSM 8 - Proatividade";
        }

        [HttpGet("/objetivos")]
        public string Objetivos()
        {
            return "Objetivos dessa semana: " +
                "\n1: Realizar meu primeiro Pitch Pessoal" +
                "\n2: Introduzir conhecimentos de ASP.NET" +
                "\n3: Aplicar para mais algumas vagas de desenvolvedor Jr";


        }

    }
}
