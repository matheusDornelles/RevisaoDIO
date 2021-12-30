using System;

namespace Revisao
{

    class Program{

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {

                switch (opcaoUsuario)
                {

                    case "1":
                        //TODO: ADD ALUNO
                        break;
                    //TODO: LIST ALUNO
                    case "2":

                        break;

                    case "3":

                        break;
                    default:

                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = opcaoUsuario;
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1-Inserir novo aluno:");
            Console.WriteLine("2-Listar alunos");
            Console.WriteLine("3-Calcular média geral");
            Console.WriteLine("x - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
