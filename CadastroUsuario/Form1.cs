using System;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CadastroUsuario
{
    // Classe principal que representa o formulário de cadastro de usuários
    public partial class CadastroUsuario : Form
    {
        // Construtor do formulário
        public CadastroUsuario()
        {
            InitializeComponent(); // Inicializa os componentes gráficos do formulário
        }

        // DataTable para armazenar os usuários e exibi-los no DataGridView
        DataTable cadastroUsuario = new DataTable();

        // Lista para armazenar os usuários cadastrados na memória
        List<Usuario> usuarios = new List<Usuario>();

        // Método chamado automaticamente quando o formulário é carregado
        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            // Adiciona colunas ao DataTable para armazenar os dados dos usuários
            cadastroUsuario.Columns.Add("Nome");
            cadastroUsuario.Columns.Add("Email");
            cadastroUsuario.Columns.Add("Idade");

            // Define o DataTable como a fonte de dados do DataGridView
            CadastroView.DataSource = cadastroUsuario;

            // Associa o evento de mudança de texto à função de busca por nome
            NomeBuscaTextBox.TextChanged += NomeBuscaTextBox_TextChanged;
        }

        // Método para validar se o e-mail digitado tem um formato correto
        private bool ValidarEmail(string email)
        {
            // Expressão regular para validar o formato do e-mail
            string padraoEmail = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";

            // Retorna verdadeiro se o e-mail estiver no formato correto, falso caso contrário
            return Regex.IsMatch(email, padraoEmail);
        }

        // Método acionado quando o botão de cadastro é clicado
        private void CadastroButton_Click(object sender, EventArgs e)
        {
            // Verifica se o nome tem mais de 50 caracteres
            if (NomeTextBox.Text.Length > 50)
            {
                MessageBox.Show("O nome deve ter no máximo 50 caracteres."); // Exibe mensagem de erro
                return;
            }

            // Verifica se o e-mail é válido usando a função ValidarEmail
            if (!ValidarEmail(EmailTextBox.Text))
            {
                MessageBox.Show("E-mail inválido. Digite um e-mail válido."); // Exibe mensagem de erro
                return;
            }

            // Tenta converter o texto digitado no campo de idade para um número inteiro
            if (int.TryParse(IdadeTextBox.Text, out int idade))
            {
                // Cria um novo usuário com os dados fornecidos
                Usuario novoUsuario = new Usuario(NomeTextBox.Text, EmailTextBox.Text, idade);

                // Adiciona o novo usuário à lista de usuários
                usuarios.Add(novoUsuario);

                // Adiciona os dados do novo usuário ao DataTable para exibição no DataGridView
                cadastroUsuario.Rows.Add(novoUsuario.Nome, novoUsuario.Email, novoUsuario.Idade);

                // Limpa os campos de entrada após o cadastro
                NomeTextBox.Text = "";
                EmailTextBox.Text = "";
                IdadeTextBox.Text = "";
            }
            else
            {
                // Exibe mensagem de erro caso a idade digitada não seja um número válido
                MessageBox.Show("Idade inválida. Digite um número válido.");
            }
        }

        // Método acionado quando o usuário digita algo no campo de busca por nome
        private void NomeBuscaTextBox_TextChanged(object sender, EventArgs e)
        {
            // Obtém o texto digitado e remove espaços extras, convertendo para minúsculas
            string nomeBusca = NomeBuscaTextBox.Text.Trim().ToLower();

            // Cria uma visão filtrada do DataTable, exibindo apenas os nomes que contenham o texto digitado
            DataView dv = cadastroUsuario.DefaultView;
            dv.RowFilter = string.Format("Nome LIKE '%{0}%'", nomeBusca);
        }

        // Classe que representa um usuário cadastrado
        public class Usuario
        {
            // Propriedade para armazenar o nome do usuário
            public string Nome { get; set; }

            // Propriedade para armazenar o e-mail do usuário
            public string Email { get; set; }

            // Propriedade para armazenar a idade do usuário
            public int Idade { get; set; }

            // Construtor da classe Usuario, que recebe nome, e-mail e idade como parâmetros
            public Usuario(string nome, string email, int idade)
            {
                Nome = nome;
                Email = email;
                Idade = idade;
            }
        }
    }
}
