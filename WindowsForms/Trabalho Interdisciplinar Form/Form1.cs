using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Interdisciplinar_Form
{
    public partial class form_Inicio : Form
    {
        public form_Inicio()
        {
            InitializeComponent();
        }

        //Faz o diagnostico das doenças.
        static void Diagnostico(bool[,] tabelaVerdade, bool[,] resultado, Label labelP10, Label labelP11, Label labelP12, Label labelP13, Label labelP14)
        {
            int[] doencaP10 = new int[32768];
            int[] doencaP11 = new int[32768];
            int[] doencaP12 = new int[32768];
            int[] doencaP13 = new int[32768];
            int[] doencaP14 = new int[32768];
            int[] sintomaP10 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] sintomaP11 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] sintomaP12 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] sintomaP13 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] sintomaP14 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int maior = int.MinValue;

            //P10
            //Procura as linhas que tem somente uma doença verdadeira.
            int cont = 0;
            for (int i = 0; i < 32768; i++)
            {
                if (tabelaVerdade[i, 9] && !tabelaVerdade[i, 10] && !tabelaVerdade[i, 11] && !tabelaVerdade[i, 12] && !tabelaVerdade[i, 13] && !tabelaVerdade[i, 14] && resultado[i, 14])
                {
                    doencaP10[cont] = i;
                    cont++;
                }
            }
            //Conta os sintomas para ver os que apareceram mais.
            for (int i = 0; i < cont; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (tabelaVerdade[doencaP10[i], j])
                    {
                        sintomaP10[j]++;
                    }
                }
            }
            //Olha qual apareceu mais veses.
            for (int i = 0; i < 9; i++)
            {
                if (sintomaP10[i] > maior)
                {
                    maior = sintomaP10[i];
                }
            }
            //Imprime os simtomas.
            for (int i = 0; i < 9; i++)
            {
                if (sintomaP10[i] == maior)
                {
                    switch (i)
                    {
                        case 0:
                            labelP10.Text += "Febre\n";
                            break;
                        case 1:
                            labelP10.Text += "Erupção cutanelas\n";
                            break;
                        case 2:
                            labelP10.Text += "Ganglios linfaticos\n";
                            break;
                        case 3:
                            labelP10.Text += "Coriza\n";
                            break;
                        case 4:
                            labelP10.Text += "Fotofobia\n";
                            break;
                        case 5:
                            labelP10.Text += "Dificuldade de Respirar\n";
                            break;
                        case 6:
                            labelP10.Text += "Falta de apetite\n";
                            break;
                        case 7:
                            labelP10.Text += "Tosse\n";
                            break;
                        case 8:
                            labelP10.Text += "Chiado no peitoral\n";
                            break;
                    }
                }
            }

            //P11
            //Procura as linhas que tem somente uma doença verdadeira.
            cont = 0;
            for (int i = 0; i < 32768; i++)
            {
                if (!tabelaVerdade[i, 9] && tabelaVerdade[i, 10] && !tabelaVerdade[i, 11] && !tabelaVerdade[i, 12] && !tabelaVerdade[i, 13] && !tabelaVerdade[i, 14] && resultado[i, 14])
                {
                    doencaP11[cont] = i;
                    cont++;
                }
            }
            //Conta os sintomas para ver os que apareceram mais.
            for (int i = 0; i < cont; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (tabelaVerdade[doencaP11[i], j])
                    {
                        sintomaP11[j]++;
                    }
                }
            }
            //Olha qual apareceu mais veses.
            maior = int.MinValue;
            for (int i = 0; i < 9; i++)
            {
                if (sintomaP11[i] > maior)
                {
                    maior = sintomaP11[i];
                }
            }
            //Imprime os simtomas.
            for (int i = 0; i < 9; i++)
            {
                if (sintomaP11[i] == maior)
                {
                    switch (i)
                    {
                        case 0:
                            labelP11.Text += "Febre\n";
                            break;
                        case 1:
                            labelP11.Text += "Erupção cutanelas\n";
                            break;
                        case 2:
                            labelP11.Text += "Ganglios linfaticos\n";
                            break;
                        case 3:
                            labelP11.Text += "Coriza\n";
                            break;
                        case 4:
                            labelP11.Text += "Fotofobia\n";
                            break;
                        case 5:
                            labelP11.Text += "Dificuldade de Respirar\n";
                            break;
                        case 6:
                            labelP11.Text += "Falta de apetite\n";
                            break;
                        case 7:
                            labelP11.Text += "Tosse\n";
                            break;
                        case 8:
                            labelP11.Text += "Chiado no peitoral\n";
                            break;
                    }
                }
            }

            //P12
            //Procura as linhas que tem somente uma doença verdadeira.
            cont = 0;
            for (int i = 0; i < 32768; i++)
            {
                if (!tabelaVerdade[i, 9] && !tabelaVerdade[i, 10] && tabelaVerdade[i, 11] && !tabelaVerdade[i, 12] && !tabelaVerdade[i, 13] && !tabelaVerdade[i, 14] && resultado[i, 14])
                {
                    doencaP12[cont] = i;
                    cont++;
                }
            }
            //Conta os sintomas para ver os que apareceram mais.
            for (int i = 0; i < cont; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (tabelaVerdade[doencaP12[i], j])
                    {
                        sintomaP12[j]++;
                    }
                }
            }
            //Olha qual apareceu mais veses.
            maior = int.MinValue;
            for (int i = 0; i < 9; i++)
            {
                if (sintomaP12[i] > maior)
                {
                    maior = sintomaP12[i];
                }
            }
            //Imprime os simtomas.
            for (int i = 0; i < 9; i++)
            {
                if (sintomaP12[i] == maior)
                {
                    switch (i)
                    {
                        case 0:
                            labelP12.Text += "Febre\n";
                            break;
                        case 1:
                            labelP12.Text += "Erupção cutanelas\n";
                            break;
                        case 2:
                            labelP12.Text += "Ganglios linfaticos\n";
                            break;
                        case 3:
                            labelP12.Text += "Coriza\n";
                            break;
                        case 4:
                            labelP12.Text += "Fotofobia\n";
                            break;
                        case 5:
                            labelP12.Text += "Dificuldade de Respirar\n";
                            break;
                        case 6:
                            labelP12.Text += "Falta de apetite\n";
                            break;
                        case 7:
                            labelP12.Text += "Tosse\n";
                            break;
                        case 8:
                            labelP12.Text += "Chiado no peitoral\n";
                            break;
                    }
                }
            }

            //P13
            //Procura as linhas que tem somente uma doença verdadeira.
            cont = 0;
            for (int i = 0; i < 32768; i++)
            {
                if (!tabelaVerdade[i, 9] && !tabelaVerdade[i, 10] && !tabelaVerdade[i, 11] && tabelaVerdade[i, 12] && !tabelaVerdade[i, 13] && !tabelaVerdade[i, 14] && resultado[i, 14])
                {
                    doencaP13[cont] = i;
                    cont++;
                }
            }
            //Conta os sintomas para ver os que apareceram mais.
            for (int i = 0; i < cont; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (tabelaVerdade[doencaP13[i], j])
                    {
                        sintomaP13[j]++;
                    }
                }
            }
            //Olha qual apareceu mais veses.
            maior = int.MinValue;
            for (int i = 0; i < 9; i++)
            {
                if (sintomaP13[i] > maior)
                {
                    maior = sintomaP13[i];
                }
            }
            //Imprime os simtomas.
            for (int i = 0; i < 9; i++)
            {
                if (sintomaP13[i] == maior)
                {
                    switch (i)
                    {
                        case 0:
                            labelP13.Text += "Febre\n";
                            break;
                        case 1:
                            labelP13.Text += "Erupção cutanelas\n";
                            break;
                        case 2:
                            labelP13.Text += "Ganglios linfaticos\n";
                            break;
                        case 3:
                            labelP13.Text += "Coriza\n";
                            break;
                        case 4:
                            labelP13.Text += "Fotofobia\n";
                            break;
                        case 5:
                            labelP13.Text += "Dificuldade de Respirar\n";
                            break;
                        case 6:
                            labelP13.Text += "Falta de apetite\n";
                            break;
                        case 7:
                            labelP13.Text += "Tosse\n";
                            break;
                        case 8:
                            labelP13.Text += "Chiado no peitoral\n";
                            break;
                    }
                }
            }

            //P14
            //Procura as linhas que tem somente uma doença verdadeira.
            cont = 0;
            for (int i = 0; i < 32768; i++)
            {
                if (!tabelaVerdade[i, 9] && !tabelaVerdade[i, 10] && !tabelaVerdade[i, 11] && !tabelaVerdade[i, 12] && tabelaVerdade[i, 13] && !tabelaVerdade[i, 14] && resultado[i, 14])
                {
                    doencaP14[cont] = i;
                    cont++;
                }
            }
            //Conta os sintomas para ver os que apareceram mais.
            for (int i = 0; i < cont; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (tabelaVerdade[doencaP14[i], j])
                    {
                        sintomaP14[j]++;
                    }
                }
            }
            //Olha qual apareceu mais veses.
            maior = int.MinValue;
            for (int i = 0; i < 9; i++)
            {
                if (sintomaP14[i] > maior)
                {
                    maior = sintomaP14[i];
                }
            }
            //Imprime os simtomas.
            for (int i = 0; i < 9; i++)
            {
                if (sintomaP14[i] == maior)
                {
                    switch (i)
                    {
                        case 0:
                            labelP14.Text += "Febre\n";
                            break;
                        case 1:
                            labelP14.Text += "Erupção cutanelas\n";
                            break;
                        case 2:
                            labelP14.Text += "Ganglios linfaticos\n";
                            break;
                        case 3:
                            labelP14.Text += "Coriza\n";
                            break;
                        case 4:
                            labelP14.Text += "Fotofobia\n";
                            break;
                        case 5:
                            labelP14.Text += "Dificuldade de Respirar\n";
                            break;
                        case 6:
                            labelP14.Text += "Falta de apetite\n";
                            break;
                        case 7:
                            labelP14.Text += "Tosse\n";
                            break;
                        case 8:
                            labelP14.Text += "Chiado no peitoral\n";
                            break;
                    }
                }
            }
        }
        //Preenche a tabela
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
        static void Imprime(bool[,] tabelaPossi, bool[,] resultado, DataGridView dataGridViewTabela)
        {
            //Percorre a matriz verificando cada valor e adicionando uma string no lugar do valor booleano para montar a tabela.
            for (int i = 0; i < 32768; i++)
            {
                dataGridViewTabela.Rows.Add();
                //Imprime a tabela com sua possibilidades.
                for (int j = 0; j < 15; j++)
                {
                    if (tabelaPossi[i, j] == true)
                    {
                        dataGridViewTabela.Rows[i].Cells[j].Value = "T";
                    }
                    else
                    {
                        dataGridViewTabela.Rows[i].Cells[j].Value = "F";
                    }
                }
                int cont = 0;
                //Imprime o resultado de cada linha da tabela implementada na sentença.
                for (int k = 15; k < 30; k++)
                {
                    if (resultado[i, cont] == true)
                    {
                        dataGridViewTabela.Rows[i].Cells[k].Value = "T";
                    }
                    else
                    {
                        dataGridViewTabela.Rows[i].Cells[k].Value = "F";
                    }
                    cont++;
                }
            }
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
        static void Classifica(bool[,] resultado, Label label1)
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
                label1.Text += "válida.";
            }
            else if (resultFalse == 32768)
            {
                label1.Text += "contraditória.";
            }
            else
            {
                label1.Text += "satisfatória.";
            }
        }

        private void form_Inicio_Load(object sender, EventArgs e)
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
            Imprime(tabelaPossi, resultado, dataGridViewTabela);
            //Classifica  sentença.
            Classifica(resultado, label1);
            //Diagnostica as doenças.
            Diagnostico(tabelaPossi, resultado, labelP10, labelP11, labelP12, labelP13, labelP14);
        }
    }
}
