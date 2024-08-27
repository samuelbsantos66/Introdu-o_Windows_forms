namespace Exemplo_2
{
    public partial class Form1 : Form
    {
        string nome, sobrenome, completo;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nome = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sobrenome = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = nome + ' ' +sobrenome;
        }
    }
}
