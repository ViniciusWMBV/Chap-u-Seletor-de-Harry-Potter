using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapeuseletor
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int start, grifinoria, sonserina, lufalufa, corvinal, temp;
            grifinoria = 0;
            sonserina = 0;
            lufalufa = 0;
            corvinal = 0;
            Console.WriteLine("Bem Vindo ao Chapeu Seletor!, Qual é seu nome?:");
            nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Bem Vindo " + nome + "!");
            Console.WriteLine("Para começar o teste digite 1 para sair digite 0:");
            start = int.Parse(Console.ReadLine());
            if (start == 1)
                {
                Console.Clear();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Agradecemos a sua presença, até a proxima!");
                Console.ReadKey();
             }
            Console.WriteLine("1) Qual é o seu tipo de personalidade favorito em outras pessoas? \n 1) ambicioso \n 2) corajoso e leal \n 3) inteligente e racional \n 4) otimista e divertido");
            temp = int.Parse(Console.ReadLine());
            
            if (temp == 1)
            {
                sonserina= sonserina + 1;
            }

            if (temp == 2)
            {
                grifinoria = grifinoria+1;
            }

            if (temp == 3)
            {
                corvinal = corvinal+1;
            }
            if (temp == 4)
            {
                lufalufa = lufalufa+1;
            }
            Console.Clear();

            Console.WriteLine("2)Como você lida com o fracasso? \n 1) Analisando o que deu errado e buscando uma solução \n 2) Aceitando o fracasso e seguindo em frente \n 3) Trabalhando ainda mais duro para ter sucesso na próxima vez \n 4) Buscando apoio de amigos e continuando a lutar");
            temp = int.Parse(Console.ReadLine());
            if (temp == 1)
            {
                corvinal = corvinal+1;
            }

            if (temp == 2)
            {
                lufalufa = lufalufa+1;
            }

            if (temp == 3)
            {
                sonserina = sonserina+1;
            }
            if (temp == 4)
            {
                grifinoria = grifinoria+1;
            }

            Console.Clear();
            Console.WriteLine("3)Qual é a sua postura diante da justiça? \n 1) A justiça é o que importa acima de tudo \n 2) A justiça deve ser equilibrada com a compaixão \n 3) A justiça deve ser baseada na lei e na razão \n 4) A justiça é secundária aos meus objetivos pessoais");
            temp = int.Parse(Console.ReadLine());
            if (temp == 1)
            {
                grifinoria = grifinoria + 1;
            }

            if (temp == 2)
            {
                lufalufa = lufalufa + 1;
            }

            if (temp == 3)
            {
                corvinal = corvinal + 1;
            }
            if (temp == 4)
            {
                sonserina = sonserina + 1;
            }
            Console.Clear();

            Console.WriteLine("4)Como você se relaciona com os outros? \n 1) Estabeleço relacionamentos fortes e duradouros \n 2) Gosto de ter muitos amigos e conhecer novas pessoas \n 3) Prefiro relacionamentos baseados em interesses comuns \n 4) Mantenho relacionamentos formais e profissionais");
            temp = int.Parse(Console.ReadLine());
            if (temp == 1)
            {
                grifinoria = grifinoria + 1;
            }

            if (temp == 2)
            {
                lufalufa = lufalufa + 1;
            }

            if (temp == 3)
            {
                sonserina = sonserina + 1;
            }
            if (temp == 4)
            {
                corvinal = corvinal + 1;
            }
            Console.Clear();
            Console.WriteLine(grifinoria);
            Console.WriteLine(sonserina);
            Console.WriteLine(lufalufa);
            Console.WriteLine(corvinal);
            Console.ReadKey();
        }
    }
}
