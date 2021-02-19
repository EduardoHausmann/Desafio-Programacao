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
    public partial class frmConsultaPessoa : Form
    {
        public frmConsultaPessoa()
        {
            InitializeComponent();
        }

        public void AtualizarTabela()
        {
            PessoaRepository repository = new PessoaRepository();
            string buscar = txtBuscar.Text.Trim();
            List<Pessoa> pessoas = repository.ObterTodos(buscar);
            dgvPessoa.RowCount = 0;
            for (int i = 0; i < pessoas.Count; i++)
            {
                Pessoa pessoa = pessoas[i];
                dgvPessoa.Rows.Add(new object[]
                {
                    pessoa.Id.ToString(), pessoa.Nome, pessoa.Sobrenome, pessoa.CPF, pessoa.Endereco, pessoa.Telefone, pessoa.Email, pessoa.DataNascimento.ToString(), pessoa.NomeMae
                });
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void frmConsultaPessoa_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
