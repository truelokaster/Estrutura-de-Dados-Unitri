using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Angela_VT_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val1, val2, pes1, pes2;

            val1 = 0;
            val2 = 0;
            pes1 = 1;
            pes2 = 1;

                      
            if (textBox1.Text != "")
               val1 = Convert.ToDouble(textBox1.Text);
            if (textBox2.Text != "")
               val2 = Convert.ToDouble(textBox2.Text);
            if (textBox3.Text != "")
               pes1 = Convert.ToDouble(textBox3.Text);
            if (textBox4.Text != "") 
               pes2 = Convert.ToDouble(textBox4.Text);
            if (textBox1.Text == "")
                textBox5.Text = Convert.ToString(val2);
            if (textBox2.Text == "")
                textBox5.Text = Convert.ToString(val1);



            if (rbtsoma.Checked)
            {
                CSoma objetoSoma;
                objetoSoma = new CSoma(val1, val2);
                textBox5.Text = Convert.ToString(objetoSoma.calculasoma());
            }

            if (rbtsub.Checked)
            {
                CSubtracao objetoSubtracao;
                objetoSubtracao = new CSubtracao(val1, val2);
                textBox5.Text = Convert.ToString(objetoSubtracao.calculasub());
            }
            if (rbtmult.Checked)
            {
                CMultiplicacao objetoMultiplicacao;
                objetoMultiplicacao = new CMultiplicacao(val1, val2);
                textBox5.Text = Convert.ToString(objetoMultiplicacao.calculamulti());
            }
            if (rbtdiv.Checked)
            {
                CDivisao objetoDivisao;
                objetoDivisao = new CDivisao(val1, val2);
                textBox5.Text = Convert.ToString(objetoDivisao.calculadiv());
            }
            if (rbtmed.Checked)
            { 
                CMedia objetomedia;
                objetomedia = new CMedia(val1, val2);
                textBox5.Text = Convert.ToString(objetomedia.calculamedia());
            }
            if (rbtmedpond.Checked)
            {
                CMediaPonderada objetomediapond;
                objetomediapond = new CMediaPonderada(val1, val2, pes1, pes2);
                textBox5.Text = Convert.ToString(objetomediapond.calculamediapond());
            }
        }
    }
}
