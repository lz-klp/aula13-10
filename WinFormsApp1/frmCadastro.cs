using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnNovaPessoa_Click(object sender, EventArgs e)
        {
            if (cbxCategoria.Text == "Cliente")
                new frmCliente().ShowDialog();
            if (cbxCategoria.Text == "Funcionário")
                new frmFuncionario().ShowDialog();
            if (cbxCategoria.Text == "Fornecedor")
                new frmFornecedor().ShowDialog();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            foreach (Control ctr in this.Controls)
            {
                if(ctr.GetType() == typeof(ListBox))
                {
                    var lbx = (ListBox)ctr;
                    if (lbx.Items.Count == 0)
                        lbx.Visible = false;
                }       
            }
        }

        private void frmCadastro_Enter(object sender, EventArgs e)
        {
            if (lbxNome.Items.Count != BD.pessoas.Count)
                AtualizarListas();
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(ListBox))
                    {
                        var lbx = (ListBox)ctr;
                            lbx.Visible = lbx.Items.Count != 0;
                    }
                }
        }
        void AtualizarListas()
        {
            lbxNome.Items.Clear();
            lbxCPF.Items.Clear();
            lbxCategoria.Items.Clear();
            lbxTelefone.Items.Clear();
            foreach (var pessoa in BD.pessoas)
            {
                lbxNome.Items.Add(pessoa.Nome);
                lbxCPF.Items.Add(pessoa.CPF);
                lbxTelefone.Items.Add(pessoa.Telefone);
                lbxCategoria.Items.Add(pessoa.Categoria);
            }
        }
    }
}
