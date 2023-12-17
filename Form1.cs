using diretivas;

namespace view
{
    public partial class Form1 : Form
    {
        controller? controller = null;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if(this.controller == null) { 
                this.controller = new controller();
                await controller.dowloadChromium();
                await controller.findNfeSaveCsv();
                this.controller = null;
                MessageBox.Show("Programa finalizado");
            }
        }
    }
}