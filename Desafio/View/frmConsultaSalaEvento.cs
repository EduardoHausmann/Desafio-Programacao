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
    public partial class frmConsultaSalaEvento : Form
    {
        public frmConsultaSalaEvento()
        {
            InitializeComponent();
        }

        public void AtualizarTabela()
        {
            SalaEventoRepository repository = new SalaEventoRepository();
            string buscar = txtBuscar.Text.Trim();
            List<SalaEvento> salaEventos = repository.ObterTodos(buscar);
            dgvSalaEvento.RowCount = 0;
            for (int i = 0; i < salaEventos.Count; i++)
            {
                SalaEvento salaEvento = salaEventos[i];
                dgvSalaEvento.Rows.Add(new object[]
                {
                    salaEvento.Id.ToString(),
                    salaEvento.Nome,
                    salaEvento.LotacaoMaxima.ToString()
                });
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void frmConsultaSalaEvento_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
