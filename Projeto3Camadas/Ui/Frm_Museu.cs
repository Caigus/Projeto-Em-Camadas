using System;
using System.Windows.Forms;

//Importação da camada de negócio
using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;

namespace Projeto3Camadas
{
    public partial class Frm_Museu : Form
    {
        //Criação dos objetos que acessam a camada de negócio
        MuseuBLL medbll = new MuseuBLL();
        MuseuDTO meddto = new MuseuDTO();
        public Frm_Museu()
        {
            InitializeComponent();
            dataGridView1.DataSource = medbll.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meddto.Nome = txtNome.Text;
            meddto.Email = txtEmail.Text;
            meddto.Senha = txtSenha.Text;

            medbll.Inserir(meddto);

            MessageBox.Show("Cadastrado com sucesso!", "Museu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.DataSource = medbll.Listar();
            txtSenha.Clear();
            txtNome.Clear();
            txtEmail.Clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            meddto.Id = txtId.Text;
            meddto.Nome = txtNome.Text;
            meddto.Email = txtEmail.Text;
            meddto.Senha = txtSenha.Text;

            medbll.Editar(meddto);
            MessageBox.Show("Editado com sucesso!", "Museu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txtSenha.Clear();
            txtNome.Clear();
            txtEmail.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            meddto.Id = txtId.Text;
            meddto.Nome = txtNome.Text;
            meddto.Email = txtEmail.Text;
            meddto.Senha = txtSenha.Text;

            medbll.Excluir(meddto);
            MessageBox.Show("Excluido com sucesso!", "Museu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txtSenha.Clear();
            txtNome.Clear();
            txtEmail.Clear();
        }

        private void Frm_Museu_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSenha.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
