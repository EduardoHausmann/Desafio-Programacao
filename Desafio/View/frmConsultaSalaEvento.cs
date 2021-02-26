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
    public partial class frmConsultaSalaEvento : Form
    {
        public frmConsultaSalaEvento()
        {
            InitializeComponent();
        }

        public void AtualizarTabela()
        {
            EventoPessoaRepository repository = new EventoPessoaRepository();
            string buscar = cbEvento.SelectedValue.ToString();
            List<EventoPessoa> eventoPessoas = repository.ObterTodosPeloEvento(buscar);
            dgvSalaEvento.RowCount = 0;
            for (int i = 0; i < eventoPessoas.Count; i++)
            {
                EventoPessoa eventoPessoa = eventoPessoas[i];
                dgvSalaEvento.Rows.Add(new object[]
                {
                    eventoPessoa.Id.ToString(),
                    String.Concat(eventoPessoa.Pessoa.Nome, " ", eventoPessoa.Pessoa.Sobrenome)
                });
            }
        }

        private void frmConsultaSalaEvento_Load(object sender, EventArgs e)
        {
            CarregaEvento();
            AtualizarTabela();
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

        private void cbEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
