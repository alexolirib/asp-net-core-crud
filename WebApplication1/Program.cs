using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {//constroi um host podendo passar arguentos que pode ser um web api ou servidor para executar
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args) //CreateDefaultBuilder - é o construtor da hospedagem web - objeto que sabe configurar nosso ambiente de servidor web para padrão 
                .UseStartup<Startup>()
                .Build();
    }
}
