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
    public partial class frmConsultaEspacoCafe : Form
    {
        public frmConsultaEspacoCafe()
        {
            InitializeComponent();
        }

        public void AtualizarTabela()
        {
            CafePessoaRepository repository = new CafePessoaRepository();
            string buscar = cbEspaco.SelectedValue.ToString();
            List<CafePessoa> cafePessoas = repository.ObterTodos(buscar);
            dgvEspacoCafe.RowCount = 0;
            for (int i = 0; i < cafePessoas.Count; i++)
            {
                CafePessoa cafePessoa = cafePessoas[i];
                dgvEspacoCafe.Rows.Add(new object[]
                {
                    cafePessoa.Id.ToString(),
                    String.Concat(cafePessoa.Pessoa.Nome, " ", cafePessoa.Pessoa.Sobrenome)
                });
            }
        }

        private void frmConsultaEspacoCafe_Load(object sender, EventArgs e)
        {
            CarregaEspaco();
            AtualizarTabela();
        }

        private void cbEspaco_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTabela();
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
    }
}
