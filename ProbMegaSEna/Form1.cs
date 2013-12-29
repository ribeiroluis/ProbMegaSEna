using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace ProbMegaSEna
{
    public partial class Form1 : Form
    {
        List<Sorteio> ListSorteio;
        public Form1()
        {
            InitializeComponent();
            CarregaNumeros();
        }

        private void CarregaNumeros()
        {
            ListSorteio = new List<Sorteio>();
            string[] Recebido = File.ReadAllLines(@"megasena.csv");
            Sorteio s;
            for (int i = 1; i < Recebido.Length; i++)
            {
                s = new Sorteio();
                var x = Recebido[i].Split(';');
                s.NumSorteio = int.Parse(x[0]);
                s.DataSorteio = DateTime.Parse(x[1]);
                for (int k = 2; k < 8; k++)
                {
                    s._Numeros = new Numeros();
                    s._Numeros.Num = int.Parse(x[k]);
                    s.ListNumeros.Add(s._Numeros);
                }
                ListSorteio.Add(s);
            }
 
        }

        private void btnFrequencia_Click(object sender, EventArgs e)
        {
            Hashtable hash = new Hashtable();
            foreach (var item in ListSorteio)
            {
                for (int i = 0; i < 6; i++)
                {
                    var x = hash[item.ListNumeros[i].Num];
                    if (x != null)
                    {
                        hash[item.ListNumeros[i].Num] = (int)hash[item.ListNumeros[i].Num] + 1;
                    }
                    else
                    {
                        hash.Add(item.ListNumeros[i].Num, 1);
                    }
                        
                }
            }
            Frequencia f = new Frequencia();
            List<Frequencia> fre = new List<Frequencia>();

            foreach (DictionaryEntry item in hash)
            {
                f.Numero = (int)item.Key;
                f.Quantidade = (int)item.Value;
                fre.Add(f);
                f = new Frequencia();
                
            }

            dtgDados.DataSource = fre;

            var x = Select fre in 

        }
    }
}
