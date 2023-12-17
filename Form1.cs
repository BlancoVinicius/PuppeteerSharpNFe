using diretivas;

namespace view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            controller controller = new controller();
            await controller.dowloadChromium();
            await controller.findNfeSaveCsv();
            MessageBox.Show("Programa finalizado");
        }
    }
}