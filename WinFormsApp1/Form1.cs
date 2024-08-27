namespace WinFormsApp1
{
    public partial class Form1 : Form
    {   private int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonContador_Click(object sender, EventArgs e)
        {   cont++;
            labelContador.Text = cont.ToString();
        }
    }
}
