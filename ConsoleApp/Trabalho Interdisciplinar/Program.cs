using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Interdisciplinar
{
    class Program
    {
        static void Diagnostico(bool[,] tabelaVerdade, bool[,] resultado)
        {
            int[] doencaP12 = new int[32768];
            int[] sintoma = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int cont = 0;
            for (int i = 0; i < 32768; i++)
            {
                //tabelaVerdade[i,9] == P10... resultado[i,14] == Saída da sentença completa...
                if (!tabelaVerdade[i, 9] && !tabelaVerdade[i, 10] && tabelaVerdade[i, 11] && !tabelaVerdade[i, 12] && !tabelaVerdade[i, 13] && !tabelaVerdade[i, 14] && resultado[i, 14])
                {
                    doencaP12[cont] = i;
                    cont++;
                }
            }
            for (int i = 0; i < cont; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (tabelaVerdade[doencaP12[i], j])
                    {
                        sintoma[j]++;
                    }
                }
            }
        }
        //Armazena a tabela da verdade.
        static bool[,] PreencheTabela(bool[,] tabelaPossi)
        {
            bool valor = true;
            //i = Números de colunas.
            for (int i = 0; i < 15; i++)
            {
                //j = Números de linhas.
                for (int j = 0; j < 32768; j++)
                {
                    //1ª Coluna:
                    if (i == 0)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 16384; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //2ª Coluna:
                    if (i == 1)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 8192; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //3ª Coluna:
                    if (i == 2)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 4096; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //4ª Coluna:
                    if (i == 3)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 2048; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //5ª Coluna:
                    if (i == 4)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 1024; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //6ª Coluna:
                    if (i == 5)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 512; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //7ª Coluna:
                    if (i == 6)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 256; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //8ª Coluna:
                    if (i == 7)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 128; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //9ª Coluna:
                    if (i == 8)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 64; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //10ª Coluna:
                    if (i == 9)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 32; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //11ª Coluna:
                    if (i == 10)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 16; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //12ª Coluna:
                    if (i == 11)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 8; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //13ª Coluna:
                    if (i == 12)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 4; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //14ª Coluna:
                    if (i == 13)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 2; k++)
                        {
                            tabelaPossi[j, i] = valor;
                            j++;
                        }
                        j--;
                        valor = !valor;
                    }

                    //15ª Coluna:
                    if (i == 14)
                    {
                        //k = Contador que mostra a hora de trocar o valor.
                        for (int k = 0; k < 1; k++)
                        {
                            tabelaPossi[j, i] = valor;
                        }
                        valor = !valor;
                    }
                }
            }
            return tabelaPossi;
        }

        //Imprime a tabela da verdade e o resultado no console.
        static void Imprime(bool[,] tabelaPossi, bool[,] resultado)
        {
            //Percorre a matriz verificando cada valor e adicionando uma string no lugar do valor booleano para montar a tabela.
            for (int i = 0; i < 32768; i++)
            {
                //Imprime a tabela com sua possibilidades.
                for (int j = 0; j < 15; j++)
                {
                    if (tabelaPossi[i, j] == true)
                    {
                        Console.Write("T  ");
                    }
                    else
                    {
                        Console.Write("F  ");
                    }
                }

                //Imprime o resultado de cada linha da tabela implementada na sentença.
                for (int k = 0; k < 15; k++)
                {
                    if (resultado[i, k] == true)
                    {
                        Console.Write("T  ");
                    }
                    else
                    {
                        Console.Write("F  ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("01 02 03 04 05 06 07 08 09 10 11 12 13 14 15 A  B  C  D  E  F  G  H  I  J  K  L  M  N  O");
            //Legenda.
            Console.WriteLine("\nLegenda:");
            Console.WriteLine("01 = P1");
            Console.WriteLine("02 = P2");
            Console.WriteLine("03 = P3");
            Console.WriteLine("04 = P4");
            Console.WriteLine("05 = P5");
            Console.WriteLine("06 = P6");
            Console.WriteLine("07 = P7");
            Console.WriteLine("08 = P8");
            Console.WriteLine("09 = P9");
            Console.WriteLine("10 = P10");
            Console.WriteLine("11 = P11");
            Console.WriteLine("12 = P12");
            Console.WriteLine("13 = P13");
            Console.WriteLine("14 = P14");
            Console.WriteLine("15 = P15");
            Console.WriteLine("A = P1 and P2");
            Console.WriteLine("B = !P3");
            Console.WriteLine("C = B and P14");
            Console.WriteLine("D = if P12 then P3 else C");
            Console.WriteLine("E = P1 and P7 and P10");
            Console.WriteLine("F = P8 and P9 and P11");
            Console.WriteLine("G = E or F");
            Console.WriteLine("H = P1 and P4 and P5 and P8");
            Console.WriteLine("I = P1 or P8");
            Console.WriteLine("J = if A then D");
            Console.WriteLine("K = if P6 then G");
            Console.WriteLine("L = if P13 then H");
            Console.WriteLine("M = !I");
            Console.WriteLine("N = J and K and L and M");
            Console.WriteLine("O = if N then P15 (Resultado)");
        }

        //Conectivo AND com 2 parâmetros.
        static bool And(bool a, bool b)
        {
            return a && b;
        }

        //Conectivo AND com 3 parâmetros.
        static bool And(bool a, bool b, bool c)
        {
            return a && b && c;
        }

        //Conectivo AND com 4 parâmetros.
        static bool And(bool a, bool b, bool c, bool d)
        {
            return a && b && c && d;
        }

        //Conectivo OR
        static bool Or(bool a, bool b)
        {
            return a || b;
        }

        //Conectivo NOT
        static bool Not(bool a)
        {
            return !a;
        }

        //Conectivo IF THEN
        static bool IfThen(bool a, bool b)
        {
            if (a == true)
            {
                return b;
            }
            else
            {
                return true;
            }
        }

        //Conectivo IF THEN ELSE
        static bool IfThenElse(bool a, bool b, bool c)
        {
            if (a == true)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        //Calcula a sentença.
        static bool[] CalculaSentenca(bool p1, bool p2, bool p3, bool p4, bool p5, bool p6, bool p7, bool p8, bool p9, bool p10, bool p11, bool p12, bool p13, bool p14, bool p15)
        {
            bool a, b, c, d, e, f, g, h, i, j, k, l, m, n, o;
            bool[] resultado = new bool[15];

            a = And(p1, p2);
            b = Not(p3);
            c = And(b, p14);
            d = IfThenElse(p12, p3, c);
            e = And(p1, p7, p10);
            f = And(p8, p9, p11);
            g = Or(e, f);
            h = And(p1, p4, p5, p8);
            i = Or(p1, p8);
            j = IfThen(a, d);
            k = IfThen(p6, g);
            l = IfThen(p13, h);
            m = Not(i);
            n = And(j, k, l, m);
            o = IfThen(n, p15);

            resultado[0] = a;
            resultado[1] = b;
            resultado[2] = c;
            resultado[3] = d;
            resultado[4] = e;
            resultado[5] = f;
            resultado[6] = g;
            resultado[7] = h;
            resultado[8] = i;
            resultado[9] = j;
            resultado[10] = k;
            resultado[11] = l;
            resultado[12] = m;
            resultado[13] = n;
            resultado[14] = o;

            return resultado;
        }

        //Classifica a sentença.
        static void Classifica(bool[,] resultado)
        {
            int resultTrue = 0, resultFalse = 0;
            for (int i = 0; i < 32768; i++)
            {
                if (resultado[i, 14] == true)
                {
                    resultTrue++;
                }
                else
                {
                    resultFalse++;
                }
            }

            if (resultTrue == 32768)
            {
                Console.WriteLine("\nA sentença é válida.");
            }
            else if (resultFalse == 32768)
            {
                Console.WriteLine("\nA sentença é contraditória.");
            }
            else
            {
                Console.WriteLine("\nA sentença é satisfatória.");
            }
        }

        static void Main(string[] args)
        {
            bool[,] tabelaPossi = new bool[32768, 15];
            bool[,] resultado = new bool[32768, 15];
            bool[] resultadoDaLinha = new bool[15];

            //Chama a função para preencher a tabela.
            tabelaPossi = PreencheTabela(tabelaPossi);

            //Armazena todas as possibilidades de resultados em uma matriz.
            for (int i = 0; i < 32768; i++)
            {
                resultadoDaLinha = CalculaSentenca(tabelaPossi[i, 0], tabelaPossi[i, 1], tabelaPossi[i, 2], tabelaPossi[i, 3], tabelaPossi[i, 4], tabelaPossi[i, 5], tabelaPossi[i, 6], tabelaPossi[i, 7], tabelaPossi[i, 8], tabelaPossi[i, 9], tabelaPossi[i, 10], tabelaPossi[i, 11], tabelaPossi[i, 12], tabelaPossi[i, 13], tabelaPossi[i, 14]);
                for (int j = 0; j < 15; j++)
                {
                    resultado[i, j] = resultadoDaLinha[j];
                }
            }

            //Imprime a tabela, resultado, legenda e classifica a sentença.
           //Imprime(tabelaPossi, resultado);
           Classifica(resultado);

            Diagnostico(tabelaPossi, resultado);

            Console.ReadKey();
        }
    }
}
