namespace Empregado
{
    public partial class Form1 : Form
    {
        Empregado cadEmpregado;
        public Form1()
        {
            InitializeComponent();
            cadEmpregado = new Empregado();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string mensagem = "Tem Certeza que quer sair do programa?";
            string rotulo = "Sair do Programa";
            MessageBoxButtons sair = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mensagem, rotulo, sair);
            if (resultado != System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Form1 aux = new Form1();
                aux.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadEmpregado.Nome = textBox1.Text;
            label5.Text = cadEmpregado.Nome;
            label2.Text = (cadEmpregado.Idade).ToString();
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label8.Text = (trackBar1.Value).ToString();
            cadEmpregado.Idade = trackBar1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cadEmpregado.Nome = textBox1.Text;
            label9.Text = cadEmpregado.Nome;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
