using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaMain
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Bicicleta> bicicleta = new List<Bicicleta>();
            Boolean repeat = true;
            int opcao;
            int id = 0;
            string modelo, nome, descricao, dtFabricacao;
            //DateTime dtFabricacao;
            while (repeat)
            {
                Console.WriteLine("1- Incluir Bicicleta\n2- Visualizar Bicicletas Cadastradas\n0- Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        id++;
                        Console.WriteLine("Informe Modelo: ");
                        modelo = Console.ReadLine();
                        Console.WriteLine("Informe a data de fabricação: ");
                        dtFabricacao = Console.ReadLine();
                        Console.WriteLine("Informe o nome do fabricante: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Informe o cargo do fabricante: ");
                        descricao = Console.ReadLine();

                        bicicleta.Add(new Bicicleta()
                        {
                            id = id,
                            modelo = modelo,
                            dataFabricacao = Convert.ToDateTime(dtFabricacao),
                            fabricante = new Fabricante()
                            {
                                id = id,
                                nome = nome,
                                cargo = new Cargo()
                                {
                                    id = id,
                                    descricao = descricao
                                }
                            }
                        });

                        break;

                    case 2:
                        foreach (Bicicleta b in bicicleta)
                        {
                            Console.WriteLine(b+ "\n");
                            
                        }
                        break;
                    case 0:
                        repeat = false;
                        break;

                    default: Console.WriteLine("Opção Invalida");
                        break;




                }
            }
        }
    }
}
