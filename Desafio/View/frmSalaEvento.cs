using Model;
using Repository.Repositores;
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
    public partial class frmSalaEvento : Form
    {
        public frmSalaEvento()
        {
            InitializeComponent();
        }

        SalaEventoRepository repository = new SalaEventoRepository();
        SalaEvento salaEvento = new SalaEvento();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "0")
                Inserir();
            else
                Alterar();
            LimparCampos();
            AtualizarTabela();
        }

        public void Inserir()
        {

        }

        public void Alterar()
        {

        }

        public void LimparCampos()
        {

        }

        public void AtualizarTabela()
        {

        }

        private void frmSalaEvento_Load(object sender, EventArgs e)
        {

        }

        private void dgvSalaEvento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {

        }
    }
}
