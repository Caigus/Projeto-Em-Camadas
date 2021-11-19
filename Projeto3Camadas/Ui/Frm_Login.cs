using System;
using System.Windows.Forms;
using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;
using System.Net;
using System.Net.Mail;

namespace Projeto3Camadas.Ui
{
    public partial class Frm_Login : Form
    {

        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                Frm_Museu frm_Museu = new Frm_Museu();
                frm_Museu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique o e-mail e senha.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LnkLabEsqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("redfiregamer2015@gmail.com", "seifqgaopsdkzwdb"),
                EnableSsl = true
            };

            loginDTO.Email = txtEmail.Text;
            string senha = loginBLL.RetornarSenha(loginDTO);

            client.Send("redfiregamer2015@gmail.com", $"{txtEmail.Text}", "Redefinição de Senha", $"Seu e-mail é {txtEmail.Text} com senha {senha}");
            MessageBox.Show("E-mail e senha enviados com sucesso", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
