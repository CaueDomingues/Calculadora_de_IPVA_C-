using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace cadu_e_pablinhofofo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora de IPVA
            double valor, desconto, ipva;
            int parcela;

            //Escolha do estado
            Console.WriteLine("Escolha o estado de origem");
            Console.WriteLine("1-São Paulo\n2-Rio de Janeiro\n3-Espirito Santo\n4-Minas Gerais");
            int estado = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Voce escolheu o estado de {estado}");

            //Escolha do veiculo
            Console.WriteLine("Escolha o tipo do veiculo");
            Console.WriteLine("1-Carro\n2-Caminhão\n3-Motocicleta");
            int veiculo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Voce escolheu o veiculo {veiculo}");

            //Valor do carro
            Console.WriteLine("Digite o valor do veiculo");
            valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O valor do veiculo é de {valor}");


            switch (estado)
            {
                //Estado de São paulo

                case 1:

                    //Logica para calcular o IPVA e o desconto do primeiro veículo 
                    if (veiculo == 1)
                    {
                        ipva = valor * 0.04;
                        desconto = ipva * 0.05;
                        Console.WriteLine($"O valor do seu IPVA é de {ipva}");
                        Console.WriteLine("Digite 1 para parcela unica e receber 5% de desconto ou 2 para pagar em mais parcelas porem sem desconto");
                        Console.WriteLine("1-Parcela unica\n2-Mais parcelas");
                        parcela = Convert.ToInt32(Console.ReadLine());

                        //Logica de escolha do desconto 
                        if (parcela == 1)
                        {
                            Console.WriteLine($"Voce escolheu pagar em parcela unica, seu desconto é de {desconto}");
                            Console.WriteLine($"O valor total com o desconto é de {ipva - desconto}");
                        }
                        else if (parcela == 2)
                        {
                            Console.WriteLine($"Voce escolheu pagar em mais parcelas, seu desconto é de 0%");
                            Console.WriteLine($"O valor total é de {ipva}");
                        }
                    }
                    //Logica para calcular o IPVA e o desconto do segundo veículo
                    if (veiculo == 2)
                    {
                        ipva = valor * 0.015;
                        desconto = ipva * 0.05;
                        Console.WriteLine($"O valor do seu IPVA é de {ipva}");
                        Console.WriteLine("Digite 1 para parcela unica e receber 5% de desconto ou 2 para pagar em mais parcelas porem sem desconto");
                        Console.WriteLine("1-Parcela unica\n2-Mais parcelas");
                        parcela = Convert.ToInt32(Console.ReadLine());

                        //Logica de escolha do desconto
                        if (parcela == 1)
                        {
                            Console.WriteLine($"Voce escolheu pagar em parcela unica, seu desconto é de {desconto}");
                            Console.WriteLine($"O valor total com o desconto é de {ipva - desconto}");
                        }
                        else if (parcela == 2)
                        {
                            Console.WriteLine($"Voce escolheu pagar em mais parcelas, seu desconto é de 0%");
                            Console.WriteLine($"O valor total é de {ipva}");
                        }
                    }
                    //Logica para calcular o IPVA e o desconto do terceiro veículo
                    if (veiculo == 3)
                    {
                        ipva = valor * 0.02;
                        desconto = ipva * 0.05;
                        Console.WriteLine($"O valor do seu IPVA é de {ipva}");
                        Console.WriteLine("Digite 1 para parcela unica e receber 5% de desconto ou 2 para pagar em mais parcelas porem sem desconto");
                        Console.WriteLine("1-Parcela unica\n2-Mais parcelas");
                        parcela = Convert.ToInt32(Console.ReadLine());

                        //Logica de escolha do desconto
                        if (parcela == 1)
                        {
                            Console.WriteLine($"Voce escolheu pagar em parcela unica, seu desconto é de {desconto}");
                            Console.WriteLine($"O valor total com o desconto é de {ipva - desconto}");
                        }
                        else if (parcela == 2)
                        {
                            Console.WriteLine($"Voce escolheu pagar em mais parcelas, seu desconto é de 0%");
                            Console.WriteLine($"O valor total é de {ipva}");
                        }
                    }

                    break;



                //Estado do Rio de janeiro
                case 2:
                    //Logica para calcular o IPVA e o desconto do primeiro veículo
                    if (veiculo == 1)
                    {
                        ipva = valor * 0.041;
                        desconto = ipva * 0.05;
                        Console.WriteLine($"O valor do seu IPVA é de {ipva}");
                        Console.WriteLine("Digite 1 para parcela unica e receber 5% de desconto ou 2 para pagar em mais parcelas porem sem desconto");
                        Console.WriteLine("1-Parcela unica\n2-Mais parcelas");
                        parcela = Convert.ToInt32(Console.ReadLine());

                        //Logica de escolha do desconto
                        if (parcela == 1)
                        {
                            Console.WriteLine($"Voce escolheu pagar em parcela unica, seu desconto é de {desconto}");
                            Console.WriteLine($"O valor total com o desconto é de {ipva - desconto}");
                        }
                        else if (parcela == 2)
                        {
                            Console.WriteLine($"Voce escolheu pagar em mais parcelas, seu desconto é de 0%");
                            Console.WriteLine($"O valor total é de {ipva}");
                        }
                    }
                    //Logica para calcular o IPVA e o desconto do segundo veículo
                    if (veiculo == 2)
                    {
                        ipva = valor * 0.013;
                        desconto = ipva * 0.05;
                        Console.WriteLine($"O valor do seu IPVA é de {ipva}");
                        Console.WriteLine("Digite 1 para parcela unica e receber 5% de desconto ou 2 para pagar em mais parcelas porem sem desconto");
                        Console.WriteLine("1-Parcela unica\n2-Mais parcelas");
                        parcela = Convert.ToInt32(Console.ReadLine());

                        //Logica de escolha do desconto
                        if (parcela == 1)
                        {
                            Console.WriteLine($"Voce escolheu pagar em parcela unica, seu desconto é de {desconto}");
                            Console.WriteLine($"O valor total com o desconto é de {ipva - desconto}");
                        }
                        else if (parcela == 2)
                        {
                            Console.WriteLine($"Voce escolheu pagar em mais parcelas, seu desconto é de 0%");
                            Console.WriteLine($"O valor total é de {ipva}");
                        }
                    }
                    //Logica para calcular o IPVA e o desconto do terceiro veículo
                    if (veiculo == 3)
                    {
                        ipva = valor * 0.025;
                        desconto = ipva * 0.05;
                        Console.WriteLine($"O valor do seu IPVA é de {ipva}");
                        Console.WriteLine("Digite 1 para parcela unica e receber 5% de desconto ou 2 para pagar em mais parcelas porem sem desconto");
                        Console.WriteLine("1-Parcela unica\n2-Mais parcelas");
                        parcela = Convert.ToInt32(Console.ReadLine());

                        //Logica de escolha do desconto
                        if (parcela == 1)
                        {
                            Console.WriteLine($"Voce escolheu pagar em parcela unica, seu desconto é de {desconto}");
                            Console.WriteLine($"O valor total com o desconto é de {ipva - desconto}");
                        }
                        else if (parcela == 2)
                        {
                            Console.WriteLine($"Voce escolheu pagar em mais parcelas, seu desconto é de 0%");
                            Console.WriteLine($"O valor total é de {ipva}");
                        }
                    }
                    break;


                //Estado do Espirito santo
                case 3:
                    //Logica para calcular o IPVA e o desconto do primeiro veículo
                    if (veiculo == 1)
                    {
                        ipva = valor * 0.02;
                        desconto = ipva * 0.05;
                        Console.WriteLine($"O valor do seu IPVA é de {ipva}");
                        Console.WriteLine("Digite 1 para parcela unica e receber 5% de desconto ou 2 para pagar em mais parcelas porem sem desconto");
                        Console.WriteLine("1-Parcela unica\n2-Mais parcelas");
                        parcela = Convert.ToInt32(Console.ReadLine());

                        //Logica de escolha do desconto
                        if (parcela == 1)
                        {
                            Console.WriteLine($"Voce escolheu pagar em parcela unica, seu desconto é de {desconto}");
                            Console.WriteLine($"O valor total com o desconto é de {ipva - desconto}");
                        }
                        else if (parcela == 2)
                        {
                            Console.WriteLine($"Voce escolheu pagar em mais parcelas, seu desconto é de 0%");
                            Console.WriteLine($"O valor total é de {ipva}");
                        }
                    }
                    //Logica para calcular o IPVA e o desconto do segundo veículo
                    if (veiculo == 2)
                    {
                        ipva = valor * 0.03;
                        desconto = ipva * 0.05;
                        Console.WriteLine($"O valor do seu IPVA é de {ipva}");
                        Console.WriteLine("Digite 1 para parcela unica e receber 5% de desconto ou 2 para pagar em mais parcelas porem sem desconto");
                        Console.WriteLine("1-Parcela unica\n2-Mais parcelas");
                        parcela = Convert.ToInt32(Console.ReadLine());

                        //Logica de escolha do desconto
                        if (parcela == 1)
                        {
                            Console.WriteLine($"Voce escolheu pagar em parcela unica, seu desconto é de {desconto}");
                            Console.WriteLine($"O valor total com o desconto é de {ipva - desconto}");
                        }
                        else if (parcela == 2)
                        {
                            Console.WriteLine($"Voce escolheu pagar em mais parcelas, seu desconto é de 0%");
                            Console.WriteLine($"O valor total é de {ipva}");
                        }
                    }
                    //Logica para calcular o IPVA e o desconto do terceiro veículo
                    if (veiculo == 3)
                    {
                        ipva = valor * 0.0175;
                        desconto = ipva * 0.05;
                        Console.WriteLine($"O valor do seu IPVA é de {ipva}");
                        Console.WriteLine("Digite 1 para parcela unica e receber 5% de desconto ou 2 para pagar em mais parcelas porem sem desconto");
                        Console.WriteLine("1-Parcela unica\n2-Mais parcelas");
                        parcela = Convert.ToInt32(Console.ReadLine());

                        //Logica de escolha do desconto
                        if (parcela == 1)
                        {
                            Console.WriteLine($"Voce escolheu pagar em parcela unica, seu desconto é de {desconto}");
                            Console.WriteLine($"O valor total com o desconto é de {ipva - desconto}");
                        }
                        else if (parcela == 2)
                        {
                            Console.WriteLine($"Voce escolheu pagar em mais parcelas, seu desconto é de 0%");
                            Console.WriteLine($"O valor total é de {ipva}");
                        }
                    }
                    break;


                //Estado de Minas gerais
                case 4:
                    //Logica para calcular o IPVA e o desconto do primeiro veículo
                    if (veiculo == 1)
                    {
                        ipva = valor * 0.042;
                        desconto = ipva * 0.05;
                        Console.WriteLine($"O valor do seu IPVA é de {ipva}");
                        Console.WriteLine("Digite 1 para parcela unica e receber 5% de desconto ou 2 para pagar em mais parcelas porem sem desconto");
                        Console.WriteLine("1-Parcela unica\n2-Mais parcelas");
                        parcela = Convert.ToInt32(Console.ReadLine());

                        //Logica de escolha do desconto
                        if (parcela == 1)
                        {
                            Console.WriteLine($"Voce escolheu pagar em parcela unica, seu desconto é de {desconto}");
                            Console.WriteLine($"O valor total com o desconto é de {ipva - desconto}");
                        }
                        else if (parcela == 2)
                        {
                            Console.WriteLine($"Voce escolheu pagar em mais parcelas, seu desconto é de 0%");
                            Console.WriteLine($"O valor total é de {ipva}");
                        }
                    }
                    //Logica para calcular o IPVA e o desconto do segundo veículo
                    if (veiculo == 2)
                    {
                        ipva = valor * 0.01;
                        desconto = ipva * 0.05;
                        Console.WriteLine($"O valor do seu IPVA é de {ipva}");
                        Console.WriteLine("Digite 1 para parcela unica e receber 5% de desconto ou 2 para pagar em mais parcelas porem sem desconto");
                        Console.WriteLine("1-Parcela unica\n2-Mais parcelas");
                        parcela = Convert.ToInt32(Console.ReadLine());

                        //Logica de escolha do desconto
                        if (parcela == 1)
                        {
                            Console.WriteLine($"Voce escolheu pagar em parcela unica, seu desconto é de {desconto}");
                            Console.WriteLine($"O valor total com o desconto é de {ipva - desconto}");
                        }
                        else if (parcela == 2)
                        {
                            Console.WriteLine($"Voce escolheu pagar em mais parcelas, seu desconto é de 0%");
                            Console.WriteLine($"O valor total é de {ipva}");
                        }
                    }
                    //Logica para calcular o IPVA e o desconto do terceiro veículo
                    if (veiculo == 3)
                    {
                        ipva = valor * 0.022;
                        desconto = ipva * 0.05;
                        Console.WriteLine($"O valor do seu IPVA é de {ipva}");
                        Console.WriteLine("Digite 1 para parcela unica e receber 5% de desconto ou 2 para pagar em mais parcelas porem sem desconto");
                        Console.WriteLine("1-Parcela unica\n2-Mais parcelas");
                        parcela = Convert.ToInt32(Console.ReadLine());

                        //Logica de escolha do desconto
                        if (parcela == 1)
                        {
                            Console.WriteLine($"Voce escolheu pagar em parcela unica, seu desconto é de {desconto}");
                            Console.WriteLine($"O valor total com o desconto é de {ipva - desconto}");
                        }
                        else if (parcela == 2)
                        {
                            Console.WriteLine($"Voce escolheu pagar em mais parcelas, seu desconto é de 0%");
                            Console.WriteLine($"O valor total é de {ipva}");
                        }
                    }


                    break;
                default:
                    Console.WriteLine("Opçao invalida");
                    break;




            }
            Console.Read();
        }
    }
}