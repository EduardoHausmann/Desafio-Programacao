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
            salaEvento.Nome = txtNome.Text;
            salaEvento.LotacaoMaxima = Convert.ToInt32(nudLotacao.Value);
            repository.Inserir(salaEvento);
        }

        public void Alterar()
        {
            salaEvento.Id = Convert.ToInt32(lblId.Text);
            salaEvento.Nome = txtNome.Text;
            salaEvento.LotacaoMaxima = Convert.ToInt32(nudLotacao.Value);
            repository.Alterar(salaEvento);
        }

        public void LimparCampos()
        {
            lblId.Text = "0";
            txtNome.Clear();
            nudLotacao.Value = 1;
        }

        public void AtualizarTabela()
        {
            string busca = "";
            List<SalaEvento> salaEventos = repository.ObterTodos(busca);
            dgvSalaEvento.RowCount = 0;
            for (int i = 0; i < salaEventos.Count; i++)
            {
                salaEvento = salaEventos[i];
                dgvSalaEvento.Rows.Add(new object[]{
                    salaEvento.Id.ToString(), salaEvento.Nome, salaEvento.LotacaoMaxima.ToString()
                });
            }
        }

        private void frmSalaEvento_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dgvSalaEvento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvSalaEvento.CurrentRow.Cells[0].Value);
            salaEvento = repository.ObterPeloId(id);
            if (salaEvento != null)
            {
                lblId.Text = salaEvento.Id.ToString();
                txtNome.Text = salaEvento.Nome;
                nudLotacao.Value = Convert.ToInt32(salaEvento.LotacaoMaxima);
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente desativar?", "AVISO!", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvSalaEvento.CurrentRow.Cells[0].Value);
                repository.Apagar(id);
                AtualizarTabela();
            }
        }
    }
}
