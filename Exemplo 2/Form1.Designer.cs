namespace Exemplo_2
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Sobrenome = new Label();
            button1 = new Button();
            Nome = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Sobrenome
            // 
            Sobrenome.AutoSize = true;
            Sobrenome.Location = new Point(188, 168);
            Sobrenome.Name = "Sobrenome";
            Sobrenome.Size = new Size(132, 15);
            Sobrenome.TabIndex = 0;
            Sobrenome.Text = "Digite o seu sobrenome";
            // 
            // button1
            // 
            button1.Location = new Point(351, 189);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Clique aqui";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(214, 128);
            Nome.Name = "Nome";
            Nome.Size = new Size(106, 15);
            Nome.TabIndex = 3;
            Nome.Text = "Digite o seu nome:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(326, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(326, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(326, 259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 267);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 7;
            label1.Text = "Seu nome completo é: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Nome);
            Controls.Add(button1);
            Controls.Add(Sobrenome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Sobrenome;
        private Button button1;
        private Label Nome;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
    }
}
