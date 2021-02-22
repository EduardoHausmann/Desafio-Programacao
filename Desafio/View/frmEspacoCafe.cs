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
    public partial class frmEspacoCafe : Form
    {
        public frmEspacoCafe()
        {
            InitializeComponent();
        }

        EspacoCafeRepository repository = new EspacoCafeRepository();
        EspacoCafe espacoCafe = new EspacoCafe();

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
            espacoCafe.NumeroSala = Convert.ToInt32(txtNumeroSala.Text);
            espacoCafe.LotacaoMaxima = Convert.ToInt32(nudLotacao.Value);
            repository.Inserir(espacoCafe);
        }

        public void Alterar()
        {
            espacoCafe.Id = Convert.ToInt32(lblId.Text);
            espacoCafe.NumeroSala = Convert.ToInt32(txtNumeroSala.Text);
            espacoCafe.LotacaoMaxima = Convert.ToInt32(nudLotacao.Value);
            repository.Alterar(espacoCafe);
        }

        public void LimparCampos()
        {
            lblId.Text = "0";
            txtNumeroSala.Clear();
            nudLotacao.Value = 1;
        }

        public void AtualizarTabela()
        {
            string busca = "";
            List<EspacoCafe> espacoCafes = repository.ObterTodos(busca);
            dgvEspacoCafe.RowCount = 0;
            for (int i = 0; i < espacoCafes.Count; i++)
            {
                espacoCafe = espacoCafes[i];
                dgvEspacoCafe.Rows.Add(new object[]{
                    espacoCafe.Id.ToString(), espacoCafe.NumeroSala, espacoCafe.LotacaoMaxima.ToString()
                });
            }
        }

        private void frmEspacoCafe_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dgvEspacoCafe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvEspacoCafe.CurrentRow.Cells[0].Value);
            espacoCafe = repository.ObterPeloId(id);
            if (espacoCafe != null)
            {
                lblId.Text = espacoCafe.Id.ToString();
                txtNumeroSala.Text = espacoCafe.NumeroSala.ToString();
                nudLotacao.Value = Convert.ToInt32(espacoCafe.LotacaoMaxima);
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente desativar?", "AVISO!", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvEspacoCafe.CurrentRow.Cells[0].Value);
                repository.Apagar(id);
                AtualizarTabela();
            }
        }
    }
}
