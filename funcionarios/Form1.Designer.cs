
using System.Reflection.Metadata.Ecma335;

namespace funcionarios
{
    partial class Form1
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

        private Label GetLabel4()
        {
            return label4;
        }


        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textNome = new TextBox();
            textEmail = new TextBox();
            textCpf = new TextBox();
            textEndereco = new TextBox();
            buttonCadasrtrar = new Button();
            buttonPesquisar = new Button();
            label1 = new Label();
            showID = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(100, 100);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(100, 138);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 2;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(100, 183);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 3;
            label4.Text = "Enderço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(100, 63);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 7;
            label5.Text = "Nome:";
            // 
            // textNome
            // 
            textNome.Location = new Point(178, 61);
            textNome.MaxLength = 100;
            textNome.Name = "textNome";
            textNome.Size = new Size(512, 23);
            textNome.TabIndex = 1;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(178, 96);
            textEmail.MaxLength = 100;
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(512, 23);
            textEmail.TabIndex = 2;
            // 
            // textCpf
            // 
            textCpf.Location = new Point(178, 139);
            textCpf.MaxLength = 11;
            textCpf.Name = "textCpf";
            textCpf.Size = new Size(512, 23);
            textCpf.TabIndex = 3;
            // 
            // textEndereco
            // 
            textEndereco.Location = new Point(178, 179);
            textEndereco.MaxLength = 200;
            textEndereco.Name = "textEndereco";
            textEndereco.Size = new Size(512, 23);
            textEndereco.TabIndex = 4;
            // 
            // buttonCadasrtrar
            // 
            buttonCadasrtrar.Location = new Point(495, 241);
            buttonCadasrtrar.Name = "buttonCadasrtrar";
            buttonCadasrtrar.Size = new Size(101, 32);
            buttonCadasrtrar.TabIndex = 5;
            buttonCadasrtrar.Text = "Cadastrar";
            buttonCadasrtrar.UseVisualStyleBackColor = true;
            buttonCadasrtrar.Click += buttonCadasrtrar_Click_1;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(602, 241);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(101, 32);
            buttonPesquisar.TabIndex = 8;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 20);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 9;
            label1.Text = "Funcionario ID:";
            label1.Click += label1_Click;
            // 
            // showID
            // 
            showID.AutoSize = true;
            showID.Location = new Point(128, 19);
            showID.Name = "showID";
            showID.Size = new Size(0, 15);
            showID.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 300);
            Controls.Add(showID);
            Controls.Add(label1);
            Controls.Add(buttonPesquisar);
            Controls.Add(label5);
            Controls.Add(buttonCadasrtrar);
            Controls.Add(textEndereco);
            Controls.Add(textCpf);
            Controls.Add(textEmail);
            Controls.Add(textNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textNome;
        private TextBox textEmail;
        private TextBox textCpf;
        private TextBox textEndereco;
        private Button buttonCadasrtrar;
        private Label label5;
        private Button buttonPesquisar;
        private Label showID;

        //public EventHandler Form1_Load { get; private set; }
    }
}
