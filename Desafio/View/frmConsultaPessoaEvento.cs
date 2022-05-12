using Model;
using Repository;
using Repository.Repositores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace View
{
    public partial class frmConsultaPessoaEvento : Form
    {
        public frmConsultaPessoaEvento()
        {
            InitializeComponent();
        }

        EventoPessoaRepository repository = new EventoPessoaRepository();
        EventoPessoa eventoPessoa = new EventoPessoa();

        public void AtualizaTabela()
        {
            string busca = cbPessoa.SelectedValue.ToString();
            List<EventoPessoa> eventoPessoas = repository.ObterTodosIdPessoa(busca);
            dgvPessoaEvento.RowCount = 0;
            for (int i = 0; i < eventoPessoas.Count; i++)
            {
                eventoPessoa = eventoPessoas[i];
                dgvPessoaEvento.Rows.Add(new object[]
                {
                    eventoPessoa.Id.ToString(), String.Concat(eventoPessoa.Pessoa.Nome, " ", eventoPessoa.Pessoa.Sobrenome), eventoPessoa.SalaEvento.Nome
                });
            }
        }

        private void frmConsultaPessoaEvento_Load(object sender, EventArgs e)
        {
            CarregaPessoa();
            AtualizaTabela();
        }

        private void cbEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaTabela();
        }

        public void CarregaPessoa()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT id, CONCAT(nome, ' ', sobrenome) AS 'NomeCompleto' FROM pessoas WHERE registro_ativo = 1";
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
