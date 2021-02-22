using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmPessoa_Click(object sender, EventArgs e)
        {
            frmPessoa pessoa = new frmPessoa();
            pessoa.Show();
        }

        private void tsmSalaEvento_Click(object sender, EventArgs e)
        {
            frmSalaEvento salaEvento = new frmSalaEvento();
            salaEvento.Show();
        }

        private void tsmEspacoCafe_Click(object sender, EventArgs e)
        {
            frmEspacoCafe espacoCafe = new frmEspacoCafe();
            espacoCafe.Show();
        }

        private void tsmConsultaPessoa_Click(object sender, EventArgs e)
        {
            frmConsultaPessoa consultaPessoa = new frmConsultaPessoa();
            consultaPessoa.Show();
        }

        private void tsmConsultaSalaEvento_Click(object sender, EventArgs e)
        {
            frmConsultaSalaEvento consultaSalaEvento = new frmConsultaSalaEvento();
            consultaSalaEvento.Show();
        }

        private void tsmConsultaEspacoCafe_Click(object sender, EventArgs e)
        {
            frmConsultaEspacoCafe consultaEspacoCafe = new frmConsultaEspacoCafe();
            consultaEspacoCafe.Show();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsmPessoaEvento_Click(object sender, EventArgs e)
        {
            frmPessoaEvento pessoaEvento = new frmPessoaEvento();
            pessoaEvento.Show();
        }

        private void tsmPessoaEspaco_Click(object sender, EventArgs e)
        {
            frmPessoaEspaco pessoaEspaco = new frmPessoaEspaco();
            pessoaEspaco.Show();
        }
    }
}
