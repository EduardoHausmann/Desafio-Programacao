using Model;
using Repository;
using Repository.Repositores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmPessoaEvento : Form
    {
        public frmPessoaEvento()
        {
            InitializeComponent();
        }

        EventoPessoaRepository repository = new EventoPessoaRepository();
        EventoPessoa eventoPessoa = new EventoPessoa();

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
            eventoPessoa.Descricao = txtDescrição.Text;
            eventoPessoa.IdSalaEvento = Convert.ToInt32(cbEvento.SelectedValue.ToString());
            eventoPessoa.IdPessoa = Convert.ToInt32(cbPessoa.SelectedValue.ToString());
            eventoPessoa.LotacaoAtual++;
            repository.Inserir(eventoPessoa);
        }

        public void Alterar()
        {
            eventoPessoa.Id = Convert.ToInt32(lblId.Text);
            eventoPessoa.Descricao = txtDescrição.Text;
            eventoPessoa.IdPessoa = Convert.ToInt32(cbPessoa.SelectedValue.ToString());
            eventoPessoa.IdSalaEvento = Convert.ToInt32(cbEvento.SelectedValue.ToString());
            repository.Alterar(eventoPessoa);
        }

        public void LimparCampos()
        {
            lblId.Text = "0";
            txtDescrição.Clear();
            cbPessoa.SelectedValue = -1;
            cbEvento.SelectedValue = -1;
        }

        public void AtualizarTabela()
        {
            List<EventoPessoa> eventoPessoas = repository.ObterTodos();
            dgvPessoaEvento.RowCount = 0;
            for (int i = 0; i < eventoPessoas.Count; i++)
            {
                eventoPessoa = eventoPessoas[i];
                dgvPessoaEvento.Rows.Add(new object[]
                {
                    eventoPessoa.Id.ToString(), eventoPessoa.Descricao, eventoPessoa.SalaEvento.Nome, String.Concat(eventoPessoa.Pessoa.Nome, " " + eventoPessoa.Pessoa.Sobrenome)
                });
            }
        }

        private void frmPessoaEvento_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
            CarregaEvento();
            CarregaPessoa();
        }

        private void dgvPessoaEvento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvPessoaEvento.CurrentRow.Cells[0].Value);
            eventoPessoa = repository.ObterPeloId(id);
            if (eventoPessoa != null)
            {
                lblId.Text = eventoPessoa.Id.ToString().ToString();
                txtDescrição.Text = eventoPessoa.Descricao;
                cbEvento.SelectedValue = eventoPessoa.IdSalaEvento;
                cbPessoa.SelectedValue = eventoPessoa.IdPessoa;
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desejá realmente desativar?", "AVISO!", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvPessoaEvento.CurrentRow.Cells[0].Value);
                repository.Apagar(id);
                eventoPessoa.LotacaoAtual--;
                AtualizarTabela();
            }
        }

        public void CarregaEvento()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT id, nome FROM sala_eventos WHERE registro_ativo = 1";
            SqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbEvento.DisplayMember = "nome";
            cbEvento.ValueMember = "id";
            cbEvento.DataSource = dt;
            comando.Connection.Close();
        }

        public void CarregaPessoa()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT id, nome FROM pessoas WHERE registro_ativo = 1";
            SqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbPessoa.DisplayMember = "nome";
            cbPessoa.ValueMember = "id";
            cbPessoa.DataSource = dt;
            comando.Connection.Close();
        }
    }
}
