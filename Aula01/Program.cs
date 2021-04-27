using System;
using System.Threading.Tasks;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //var

            string nome;
            int numeroRegistro;
            int setor;
            int turno;
            int registroOnline;

            //body

            Console.WriteLine();
            Console.WriteLine("Cadastro Online de Funcionário!!");
            Console.WriteLine();
            Console.Write("Digite seu nome:  ");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Bem vindo ");
            Console.WriteLine(nome);
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Agora vamos completar seu perfil ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Número de registro(sem caracteres especiais)  ");
            numeroRegistro = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Número de Setor:  ");
            setor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Turno (1,2 ou 3): ");
            turno = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Confirma seus dados? ");
            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine();
            Console.Write("Registro - ");
            Console.WriteLine(numeroRegistro);
            Console.Write("Setor - ");
            Console.WriteLine(setor);
            Console.Write("Turno - ");
            Console.WriteLine(turno);
            Console.WriteLine();
            Console.WriteLine("Aperte Enter para finalizar");
            Console.WriteLine();
           
           // var t = task.run(async delegate
           // {
           //     await task.delay(1000, source.token);
           //     return 42;
           // });
            Console.WriteLine();
            Console.WriteLine("Parabéns, seu número de Registro Online foi cadastrado! ");
            Console.WriteLine();
            Console.WriteLine(registroOnline);
            Console.WriteLine();
            Console.WriteLine("---- não perca esse número ----");






        }
    }
}
