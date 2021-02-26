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
    public partial class frmTrocaSala : Form
    {
        public frmTrocaSala()
        {
            InitializeComponent();
        }

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
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbEvento1.DisplayMember = "nome";
            cbEvento1.ValueMember = "id";
            cbEvento1.DataSource = dt;
            comando.Connection.Close();
        }

        public void CarregaEvento2()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT id, nome FROM sala_eventos WHERE registro_ativo = 1";
            SqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbEvento2.DisplayMember = "nome";
            cbEvento2.ValueMember = "id";
            cbEvento2.DataSource = dt;
            comando.Connection.Close();
        }

        private void btnTroca_Click(object sender, EventArgs e)
        {
            
        }
    }
}
