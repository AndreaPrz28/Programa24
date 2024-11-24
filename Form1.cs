namespace Programa24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            this.muestraTabla();
        }

        private void muestraTabla()
        {
            int n = Convert.ToInt32(this.textBoxnum.Text);
            string tabla = "";
            for (int i = 1; i <= 10; i++)
            {
                tabla = tabla + n + " x " + i + " = " + (n * i) + "\n";
            }
            this.richTextBoxResultados.AppendText(tabla);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelprincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
