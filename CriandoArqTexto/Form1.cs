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

namespace CriandoArqTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            StreamWriter ficheiro = new StreamWriter(@"C:\developments\file.txt", true, Encoding.Default);
            ficheiro.WriteLine(txt1.Text);
            ficheiro.Dispose(); 

            txt1.Text = "";
            txt1.Focus();
        }

        private void btn_Exibir_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            StreamReader streamReader = new StreamReader(@"C:\developments\file.txt", Encoding.Default);

            while(!streamReader.EndOfStream)
                lista.Items.Add(streamReader.ReadLine());

            streamReader.Dispose();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }
    }
}
