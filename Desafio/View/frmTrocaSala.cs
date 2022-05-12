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
    public partial class frmTrocaSala : Form
    {
        public frmTrocaSala()
        {
            InitializeComponent();
        }

        DataTable dtEvento1 = null;
        DataTable dtEvento2 = null;
        EventoPessoaRepository repository = new EventoPessoaRepository();
        HistoricoRepository repositoryHistorico = new HistoricoRepository();
        EventoPessoa eventoPessoa = new EventoPessoa();
        Historico historico = new Historico();

        public void AtualizaTabela1()
        {
            EventoPessoaRepository repository = new EventoPessoaRepository();
            string buscar1 = cbEvento1.SelectedValue.ToString();
            List<EventoPessoa> eventoPessoas = repository.ObterTodosPeloEvento(buscar1);
            dgvEvento1.RowCount = 0;
            for (int i = 0; i < eventoPessoas.Count; i++)
            {
                EventoPessoa eventoPessoa = eventoPessoas[i];
                dgvEvento1.Rows.Add(new object[]
                {
                    String.Concat(eventoPessoa.Pessoa.Nome, " ", eventoPessoa.Pessoa.Sobrenome)
                });
            }
        }

        public void AtualizaTabela2()
        {
            EventoPessoaRepository repository = new EventoPessoaRepository();
            string buscar2 = cbEvento2.SelectedValue.ToString();
            List<EventoPessoa> eventoPessoas = repository.ObterTodosPeloEvento(buscar2);
            dgvEvento2.RowCount = 0;
            for (int i = 0; i < eventoPessoas.Count; i++)
            {
                EventoPessoa eventoPessoa = eventoPessoas[i];
                dgvEvento2.Rows.Add(new object[]
                {
                    String.Concat(eventoPessoa.Pessoa.Nome, " ", eventoPessoa.Pessoa.Sobrenome)
                });
            }
        }

        private void frmTrocaSala_Load(object sender, EventArgs e)
        {
            CarregaEvento1();
            CarregaEvento2();
            CarregaPessoa1();
            CarregaPessoa2();
            AtualizaTabela1();
            AtualizaTabela2();
        }

        private void cbEvento1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaTabela1();
        }

        private void cbEvento2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaTabela2();
        }

        public void CarregaEvento1()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT id, nome FROM sala_eventos WHERE registro_ativo = 1";
            SqlDataReader dr = comando.ExecuteReader();
            dtEvento1 = new DataTable();
            dtEvento1.Load(dr);
            cbEvento1.DisplayMember = "nome";
            cbEvento1.ValueMember = "id";
            cbEvento1.DataSource = dtEvento1;
            comando.Connection.Close();
        }

        public void CarregaEvento2()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT id, nome FROM sala_eventos WHERE registro_ativo = 1";
            SqlDataReader dr = comando.ExecuteReader();
            dtEvento2 = new DataTable();
            dtEvento2.Load(dr);
            cbEvento2.DisplayMember = "nome";
            cbEvento2.ValueMember = "id";
            cbEvento2.DataSource = dtEvento2;
            comando.Connection.Close();
        }

        public void InserirHistorico1()
        {
            historico.Descricao = txtDescricao1.Text;
            historico.IdPessoa = Convert.ToInt32(cbPessoa1.SelectedValue.ToString());
            historico.IdSalaEvento = Convert.ToInt32(cbEvento1.SelectedValue.ToString());
            repositoryHistorico.Inserir(historico);
        }

        public void InserirHistorico2()
        {
            historico.Descricao = txtDescricao2.Text;
            historico.IdPessoa = Convert.ToInt32(cbPessoa2.SelectedValue.ToString());
            historico.IdSalaEvento = Convert.ToInt32(cbEvento2.SelectedValue.ToString());
            repositoryHistorico.Inserir(historico);
        }

        public void AlterarEventoPessoa1()
        {
            eventoPessoa.Id = Convert.ToInt32(lblId1.Text);
            eventoPessoa.Descricao = "";
            eventoPessoa.IdPessoa = Convert.ToInt32(cbPessoa1.SelectedValue.ToString());
            eventoPessoa.IdSalaEvento = Convert.ToInt32(cbEvento2.SelectedValue.ToString());
            repository.Alterar(eventoPessoa);
        }

        public void AlterarEventoPessoa2()
        {
            eventoPessoa.Id = Convert.ToInt32(lblId2.Text);
            eventoPessoa.Descricao = "";
            eventoPessoa.IdPessoa = Convert.ToInt32(cbPessoa2.SelectedValue.ToString());
            eventoPessoa.IdSalaEvento = Convert.ToInt32(cbEvento1.SelectedValue.ToString());
            repository.Alterar(eventoPessoa);
        }

        public void CarregaPessoa1()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT id, CONCAT(nome, ' ', sobrenome) AS 'NomeCompleto' FROM pessoas WHERE registro_ativo = 1";
            SqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbPessoa1.DisplayMember = "NomeCompleto";
            cbPessoa1.ValueMember = "id";
            cbPessoa1.DataSource = dt;
            comando.Connection.Close();
        }

        public void CarregaPessoa2()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT id, CONCAT(nome, ' ', sobrenome) AS 'NomeCompleto' FROM pessoas WHERE registro_ativo = 1";
            SqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbPessoa2.DisplayMember = "NomeCompleto";
            cbPessoa2.ValueMember = "id";
            cbPessoa2.DataSource = dt;
            comando.Connection.Close();
        }

        private void btnTroca_Click(object sender, EventArgs e)
        {
            if (cbEvento1.SelectedValue.ToString() == cbEvento2.SelectedValue.ToString())
            {
                MessageBox.Show("Os campos de Evento devem ter informações diferentes!", "Aviso!");
                return;
            }
            else
            {
                if (dgvEvento1.Rows.Count == 0)
                {
                    MessageBox.Show("Selecione um Evento que possua registros");
                    return;
                }
                else if (dgvEvento2.Rows.Count == 0)
                {
                    MessageBox.Show("Selecione um Evento que possua registros");
                    return;
                }
                else
                {
                    int id_evento1 = Convert.ToInt32(cbEvento1.SelectedValue.ToString());
                    int id_evento2 = Convert.ToInt32(cbEvento2.SelectedValue.ToString());
                    int evento1 = repository.ChecaEvento(id_evento1);
                    int evento2 = repository.ChecaEvento(id_evento2);
                    int lotacao1 = evento1 / 2;
                    int lotacao2 = evento2 / 2;

                    if (evento1 < evento2)
                    {
                        for (int i = 0; i <= lotacao1; i++)
                        {

                        }
                    }
                    else
                    {
                        for (int i = 0; i <= lotacao2; i++)
                        {

                        }
                    }
                }
            }
        }
    }
}
