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
    public partial class frmPessoaEvento : Form
    {
        public frmPessoaEvento()
        {
            InitializeComponent();
        }

        EventoPessoaRepository repository = new EventoPessoaRepository();
        EventoPessoa eventoPessoa = new EventoPessoa();
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
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("O campo Descrição é obrigatório!");
            }
            else if (cbEvento.SelectedIndex == -1)
            {
                MessageBox.Show("O campo Evento é obrigatório!");
            }
            else if (cbPessoa.SelectedIndex == -1)
            {
                MessageBox.Show("O campo Pessoa é obrigatório!");
            }
            else
            {
                eventoPessoa.Descricao = txtDescricao.Text;
                eventoPessoa.IdSalaEvento = Convert.ToInt32(cbEvento.SelectedValue.ToString());
                eventoPessoa.IdPessoa = Convert.ToInt32(cbPessoa.SelectedValue.ToString());
                int id_evento = Convert.ToInt32(cbEvento.SelectedValue.ToString());
                int sala = Convert.ToInt32(cbEvento.SelectedValue.ToString());
                if (repository.ChecaEvento(id_evento) < repository.PegaLotacao(sala))
                {
                    if (txtDescricao.Text.Trim() == "")
                    {
                        MessageBox.Show("O campo descrição não pode ser vazio");
                        return;
                    }
                    else
                    {
                        repository.Inserir(eventoPessoa);
                    }
                }
                else
                {
                    MessageBox.Show("Lotação Máxima atingida", "Aviso!");
                    return;
                }
            }
        }

        public void Alterar()
        {
            eventoPessoa.Id = Convert.ToInt32(lblId.Text);
            eventoPessoa.Descricao = txtDescricao.Text;
            eventoPessoa.IdPessoa = Convert.ToInt32(cbPessoa.SelectedValue.ToString());
            eventoPessoa.IdSalaEvento = Convert.ToInt32(cbEvento.SelectedValue.ToString());
            int id_evento = Convert.ToInt32(cbEvento.SelectedValue.ToString());
            int lotacao = Convert.ToInt32(cbEvento.SelectedValue.ToString());
            repository.Alterar(eventoPessoa);
        }

        public void LimparCampos()
        {
            lblId.Text = "0";
            txtDescricao.Clear();
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
                    eventoPessoa.Id.ToString(), eventoPessoa.Descricao, eventoPessoa.SalaEvento.Nome, String.Concat(eventoPessoa.Pessoa.Nome, " " + eventoPessoa.Pessoa.Sobrenome), eventoPessoa.LotacaoAtual.ToString()
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
                lblId.Text = eventoPessoa.Id.ToString();
                txtDescricao.Text = eventoPessoa.Descricao;
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
