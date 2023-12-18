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
            if (txtPathName.Text == "")
            {
                MessageBox.Show("Selecione uma pasta para salvar o arquivo!", "PASTA NÂO SELECIONADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (this.controller == null)
            {
                this.controller = new controller();
                await controller.dowloadChromium();
                await controller.findNfeSaveCsv("C:\\TESTE\\teste2.csv");
                this.controller = null;
                MessageBox.Show("Programa finalizado");
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Selecione uma pasta para salvar o arquivo";
            dialog.RootFolder = Environment.SpecialFolder.MyDocuments;


            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txtPathName.Text = dialog.SelectedPath;
            }
        }
    }
}