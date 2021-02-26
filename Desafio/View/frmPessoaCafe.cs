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
    public partial class frmPessoaCafe : Form
    {
        public frmPessoaCafe()
        {
            InitializeComponent();
        }

        CafePessoaRepository repository = new CafePessoaRepository();
        CafePessoa cafePessoa = new CafePessoa();

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
            cafePessoa.IdEspacoCafe = Convert.ToInt32(cbEspaco.SelectedValue.ToString());
            cafePessoa.IdPessoa = Convert.ToInt32(cbPessoa.SelectedValue.ToString());
            int id_espaco = Convert.ToInt32(cbEspaco.SelectedValue.ToString());
            int cafe = Convert.ToInt32(cbEspaco.SelectedValue.ToString());
            if (repository.ChecaEspacoCafe(id_espaco) < repository.PegaLotacaoCafe(cafe))
            {
                repository.Inserir(cafePessoa);
            }
            else
            {
                MessageBox.Show("Lotação máxima atingida!", "Aviso!");
                return;
            }
        }

        public void Alterar()
        {
            cafePessoa.Id = Convert.ToInt32(lblId.Text);
            cafePessoa.IdEspacoCafe = Convert.ToInt32(cbEspaco.SelectedValue.ToString());
            cafePessoa.IdPessoa = Convert.ToInt32(cbPessoa.SelectedValue.ToString());
            repository.Alterar(cafePessoa);
        }

        public void LimparCampos()
        {
            lblId.Text = "0";
            cbEspaco.SelectedValue = -1;
            cbPessoa.SelectedValue = -1;
        }

        public void AtualizarTabela()
        {
            string busca = "";
            List<CafePessoa> cafePessoas = repository.ObterTodos(busca);
            dgvPessoaEspaco.RowCount = 0;
            for (int i = 0; i < cafePessoas.Count; i++)
            {
                cafePessoa = cafePessoas[i];
                dgvPessoaEspaco.Rows.Add(new object[]
                {
                    cafePessoa.Id.ToString(), cafePessoa.EspacoCafe.Nome, String.Concat(cafePessoa.Pessoa.Nome, " " + cafePessoa.Pessoa.Sobrenome)
                });
            }
        }

        private void frmPessoaCafe_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
            CarregaEspaco();
            CarregaPessoa();
        }

        private void dgvPessoaEspaco_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvPessoaEspaco.CurrentRow.Cells[0].Value);
            cafePessoa = repository.ObterPeloId(id);
            if (cafePessoa != null)
            {
                lblId.Text = cafePessoa.Id.ToString();
                cbEspaco.SelectedValue = cafePessoa.IdEspacoCafe;
                cbPessoa.SelectedValue = cafePessoa.IdPessoa;
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desejá realmente desativar?", "Aviso!", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvPessoaEspaco.CurrentRow.Cells[0].Value);
                cafePessoa.LotacaoAtual--;
                repository.Apagar(id);
                AtualizarTabela();
            }
        }

        public void CarregaEspaco()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT id, nome FROM espaco_cafes WHERE registro_ativo = 1";
            SqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbEspaco.DisplayMember = "nome";
            cbEspaco.ValueMember = "id";
            cbEspaco.DataSource = dt;
            comando.Connection.Close();
        }

        public void CarregaPessoa()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT id, Concat(nome, ' ', sobrenome) AS 'NomeCompleto' FROM pessoas WHERE registro_ativo = 1";
            SqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbPessoa.DisplayMember = "NomeCompleto";
            cbPessoa.ValueMember = "id";
            cbPessoa.DataSource = dt;
            comando.Connection.Close();
        }
    }
}
