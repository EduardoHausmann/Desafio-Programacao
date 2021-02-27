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
    public partial class frmPessoa : Form
    {
        public frmPessoa()
        {
            InitializeComponent();
        }

        PessoaRepository repository = new PessoaRepository();
        Pessoa pessoa = new Pessoa();

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
            if (txtNome.Text == "" || txtSobrenome.Text == "")
            {
                MessageBox.Show("Os campos Nome e Sobrenome são obrigatórios!");
            }
            else if (txtEndereco.Text == "")
            {
                MessageBox.Show("O campo Endereço é obrigatório!");
            } 
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("O campo E-mail é obrigatório!");
            }
            else if (txtNomeMae.Text == "")
            {
                MessageBox.Show("O campo Nome da Mãe é obrigatório!");
            }
            else if (rbFeminino.Checked == false && rbMasculino.Checked == false)
            {
                MessageBox.Show("O campo Sexo é obrigatório!");
            }
            else
            {
                pessoa.Nome = txtNome.Text.ToUpper();
                pessoa.Sobrenome = txtSobrenome.Text.ToUpper();
                pessoa.CPF = mbCpf.Text;
                pessoa.Endereco = txtEndereco.Text.ToUpper();
                pessoa.Telefone = mbTelefone.Text;
                pessoa.Email = txtEmail.Text;
                pessoa.DataNascimento = Convert.ToDateTime(dpDataNascimento.Value);
                pessoa.NomeMae = txtNomeMae.Text.ToUpper();
                if (rbFeminino.Checked)
                    pessoa.Sexo = "Feminino";
                else if (rbMasculino.Checked)
                    pessoa.Sexo = "Masculino";

                repository.Inserir(pessoa);
            }
        }

        public void Alterar()
        {
            pessoa.Id = Convert.ToInt32(lblId.Text);
            pessoa.Nome = txtNome.Text.ToUpper();
            pessoa.Sobrenome = txtSobrenome.Text.ToUpper();
            pessoa.CPF = mbCpf.Text;
            pessoa.Endereco = txtEndereco.Text.ToUpper();
            pessoa.Telefone = mbTelefone.Text;
            pessoa.Email = txtEmail.Text;
            pessoa.DataNascimento = Convert.ToDateTime(dpDataNascimento.Value);
            pessoa.NomeMae = txtNomeMae.Text.ToUpper();
            if (rbFeminino.Checked)
                pessoa.Sexo = "Feminino";
            else if (rbMasculino.Checked)
                pessoa.Sexo = "Masculino"; ;

            repository.Alterar(pessoa);
        }

        public void LimparCampos()
        {
            lblId.Text = "0";
            txtNome.Clear();
            txtSobrenome.Clear();
            mbCpf.Clear();
            txtEndereco.Clear();
            mbTelefone.Clear();
            txtEmail.Clear();
            dpDataNascimento.Value = DateTime.Now;
            txtNomeMae.Clear();
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
        }

        public void AtualizarTabela()
        {
            string busca = "";
            List<Pessoa> pessoas = repository.ObterTodos(busca);
            dgvPessoa.RowCount = 0;
            for (int i = 0; i < pessoas.Count; i++)
            {
                pessoa = pessoas[i];
                dgvPessoa.Rows.Add(new object[] {
                    pessoa.Id.ToString(), pessoa.Nome, pessoa.Sobrenome, pessoa.CPF, pessoa.Endereco, pessoa.Telefone, pessoa.Email, pessoa.DataNascimento.ToString(), pessoa.NomeMae, pessoa.Sexo
                });
            }
        }

        private void frmPessoa_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dgvPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvPessoa.CurrentRow.Cells[0].Value);
            pessoa = repository.ObterPeloId(id);
            if (pessoa != null)
            {
                lblId.Text = pessoa.Id.ToString();
                txtNome.Text = pessoa.Nome;
                txtSobrenome.Text = pessoa.Sobrenome;
                mbCpf.Text = pessoa.CPF;
                txtEndereco.Text = pessoa.Endereco;
                mbTelefone.Text = pessoa.Telefone;
                txtEmail.Text = pessoa.Email;
                dpDataNascimento.Text = pessoa.DataNascimento.ToString();
                txtNomeMae.Text = pessoa.NomeMae;
                if (pessoa.Sexo == "Feminino")
                    rbFeminino.Checked = true;
                else if (pessoa.Sexo == "Masculino")
                    rbMasculino.Checked = true;
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente desativar?", "AVISO!", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvPessoa.CurrentRow.Cells[0].Value);
                repository.Apagar(id);
                AtualizarTabela();
            }
        }
    }
}
