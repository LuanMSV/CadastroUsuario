using System;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CadastroUsuario
{
    // Classe principal que representa o formul�rio de cadastro de usu�rios
    public partial class CadastroUsuario : Form
    {
        // Construtor do formul�rio
        public CadastroUsuario()
        {
            InitializeComponent(); // Inicializa os componentes gr�ficos do formul�rio
        }

        // DataTable para armazenar os usu�rios e exibi-los no DataGridView
        DataTable cadastroUsuario = new DataTable();

        // Lista para armazenar os usu�rios cadastrados na mem�ria
        List<Usuario> usuarios = new List<Usuario>();

        // M�todo chamado automaticamente quando o formul�rio � carregado
        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            // Adiciona colunas ao DataTable para armazenar os dados dos usu�rios
            cadastroUsuario.Columns.Add("Nome");
            cadastroUsuario.Columns.Add("Email");
            cadastroUsuario.Columns.Add("Idade");

            // Define o DataTable como a fonte de dados do DataGridView
            CadastroView.DataSource = cadastroUsuario;

            // Associa o evento de mudan�a de texto � fun��o de busca por nome
            NomeBuscaTextBox.TextChanged += NomeBuscaTextBox_TextChanged;
        }

        // M�todo para validar se o e-mail digitado tem um formato correto
        private bool ValidarEmail(string email)
        {
            // Express�o regular para validar o formato do e-mail
            string padraoEmail = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";

            // Retorna verdadeiro se o e-mail estiver no formato correto, falso caso contr�rio
            return Regex.IsMatch(email, padraoEmail);
        }

        // M�todo acionado quando o bot�o de cadastro � clicado
        private void CadastroButton_Click(object sender, EventArgs e)
        {
            // Verifica se o nome tem mais de 50 caracteres
            if (NomeTextBox.Text.Length > 50)
            {
                MessageBox.Show("O nome deve ter no m�ximo 50 caracteres."); // Exibe mensagem de erro
                return;
            }

            // Verifica se o e-mail � v�lido usando a fun��o ValidarEmail
            if (!ValidarEmail(EmailTextBox.Text))
            {
                MessageBox.Show("E-mail inv�lido. Digite um e-mail v�lido."); // Exibe mensagem de erro
                return;
            }

            // Tenta converter o texto digitado no campo de idade para um n�mero inteiro
            if (int.TryParse(IdadeTextBox.Text, out int idade))
            {
                // Cria um novo usu�rio com os dados fornecidos
                Usuario novoUsuario = new Usuario(NomeTextBox.Text, EmailTextBox.Text, idade);

                // Adiciona o novo usu�rio � lista de usu�rios
                usuarios.Add(novoUsuario);

                // Adiciona os dados do novo usu�rio ao DataTable para exibi��o no DataGridView
                cadastroUsuario.Rows.Add(novoUsuario.Nome, novoUsuario.Email, novoUsuario.Idade);

                // Limpa os campos de entrada ap�s o cadastro
                NomeTextBox.Text = "";
                EmailTextBox.Text = "";
                IdadeTextBox.Text = "";
            }
            else
            {
                // Exibe mensagem de erro caso a idade digitada n�o seja um n�mero v�lido
                MessageBox.Show("Idade inv�lida. Digite um n�mero v�lido.");
            }
        }

        // M�todo acionado quando o usu�rio digita algo no campo de busca por nome
        private void NomeBuscaTextBox_TextChanged(object sender, EventArgs e)
        {
            // Obt�m o texto digitado e remove espa�os extras, convertendo para min�sculas
            string nomeBusca = NomeBuscaTextBox.Text.Trim().ToLower();

            // Cria uma vis�o filtrada do DataTable, exibindo apenas os nomes que contenham o texto digitado
            DataView dv = cadastroUsuario.DefaultView;
            dv.RowFilter = string.Format("Nome LIKE '%{0}%'", nomeBusca);
        }

        // Classe que representa um usu�rio cadastrado
        public class Usuario
        {
            // Propriedade para armazenar o nome do usu�rio
            public string Nome { get; set; }

            // Propriedade para armazenar o e-mail do usu�rio
            public string Email { get; set; }

            // Propriedade para armazenar a idade do usu�rio
            public int Idade { get; set; }

            // Construtor da classe Usuario, que recebe nome, e-mail e idade como par�metros
            public Usuario(string nome, string email, int idade)
            {
                Nome = nome;
                Email = email;
                Idade = idade;
            }
        }
    }
}
