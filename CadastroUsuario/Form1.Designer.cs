namespace CadastroUsuario
{
    partial class CadastroUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NomeTextBox = new TextBox();
            EmailTextBox = new TextBox();
            IdadeTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CadastroButton = new Button();
            CadastroView = new DataGridView();
            NomeBuscaTextBox = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)CadastroView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 41);
            label1.Name = "label1";
            label1.Size = new Size(1492, 62);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Usuário";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // NomeTextBox
            // 
            NomeTextBox.Location = new Point(22, 205);
            NomeTextBox.Name = "NomeTextBox";
            NomeTextBox.Size = new Size(1482, 23);
            NomeTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(22, 261);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(1482, 23);
            EmailTextBox.TabIndex = 2;
            // 
            // IdadeTextBox
            // 
            IdadeTextBox.Location = new Point(22, 314);
            IdadeTextBox.Name = "IdadeTextBox";
            IdadeTextBox.Size = new Size(1482, 23);
            IdadeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 187);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 243);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 296);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Idade";
            // 
            // CadastroButton
            // 
            CadastroButton.BackColor = Color.FromArgb(192, 255, 255);
            CadastroButton.Location = new Point(673, 362);
            CadastroButton.Name = "CadastroButton";
            CadastroButton.Size = new Size(183, 42);
            CadastroButton.TabIndex = 7;
            CadastroButton.Text = "Cadastrar";
            CadastroButton.UseVisualStyleBackColor = false;
            CadastroButton.Click += CadastroButton_Click;
            // 
            // CadastroView
            // 
            CadastroView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CadastroView.BackgroundColor = Color.White;
            CadastroView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CadastroView.Location = new Point(22, 491);
            CadastroView.Name = "CadastroView";
            CadastroView.Size = new Size(1482, 313);
            CadastroView.TabIndex = 8;
            // 
            // NomeBuscaTextBox
            // 
            NomeBuscaTextBox.Location = new Point(22, 447);
            NomeBuscaTextBox.Name = "NomeBuscaTextBox";
            NomeBuscaTextBox.Size = new Size(1482, 23);
            NomeBuscaTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 429);
            label5.Name = "label5";
            label5.Size = new Size(160, 15);
            label5.TabIndex = 10;
            label5.Text = "Digite o nome para pesquisa:";
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1516, 816);
            Controls.Add(label5);
            Controls.Add(NomeBuscaTextBox);
            Controls.Add(CadastroView);
            Controls.Add(CadastroButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(IdadeTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(NomeTextBox);
            Controls.Add(label1);
            Name = "CadastroUsuario";
            Text = "Cadastro Usuario";
            Load += CadastroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)CadastroView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NomeTextBox;
        private TextBox EmailTextBox;
        private TextBox IdadeTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button CadastroButton;
        private DataGridView CadastroView;
        private TextBox NomeBuscaTextBox;
        private Label label5;
    }
}
