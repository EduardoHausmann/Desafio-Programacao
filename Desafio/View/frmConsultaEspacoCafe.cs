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
    public partial class frmConsultaEspacoCafe : Form
    {
        public frmConsultaEspacoCafe()
        {
            InitializeComponent();
        }

        public void AtualizarTabela()
        {
            EspacoCafeRepository repository = new EspacoCafeRepository();
            string buscar = txtBuscar.Text.Trim();
            List<EspacoCafe> espacoCafes = repository.ObterTodos(buscar);
            dgvEspacoCafe.RowCount = 0;
            for (int i = 0; i < espacoCafes.Count; i++)
            {
                EspacoCafe espacoCafe = espacoCafes[i];
                dgvEspacoCafe.Rows.Add(new object[]
                {
                    espacoCafe.Id.ToString(),
                    espacoCafe.Nome,
                    espacoCafe.LotacaoMaxima
                });
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void frmConsultaEspacoCafe_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
