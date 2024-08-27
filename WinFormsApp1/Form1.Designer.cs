namespace WinFormsApp1
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
            label1 = new Label();
            buttonContador = new Button();
            labelContador = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(258, 89);
            label1.Name = "label1";
            label1.Size = new Size(153, 30);
            label1.TabIndex = 0;
            label1.Text = "Exemplo Legal";
            // 
            // buttonContador
            // 
            buttonContador.Location = new Point(293, 206);
            buttonContador.Name = "buttonContador";
            buttonContador.Size = new Size(118, 23);
            buttonContador.TabIndex = 1;
            buttonContador.Text = "Clique Aqui";
            buttonContador.UseVisualStyleBackColor = true;
            buttonContador.Click += buttonContador_Click;
            // 
            // labelContador
            // 
            labelContador.AutoSize = true;
            labelContador.Location = new Point(343, 155);
            labelContador.Name = "labelContador";
            labelContador.Size = new Size(13, 15);
            labelContador.TabIndex = 2;
            labelContador.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(labelContador);
            Controls.Add(buttonContador);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonContador;
        private Label labelContador;
    }
}
