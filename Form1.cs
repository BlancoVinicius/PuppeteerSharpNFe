using diretivas;
using System.Diagnostics;

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

            if(txtNFe.Text == "")
            {
                MessageBox.Show("Digite uma chave de NFe para ser pesquisada!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fielName = "NFe " + txtNFe.Text + ".csv";
            string pathSave = string.Join('\\', txtPathName.Text, fielName);
            if (this.controller == null)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    this.controller = new controller();
                    await controller.dowloadChromium();
                    await controller.findNfeSaveCsv(pathSave);
                    this.controller = null;
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Programa finalizado");
                }
                finally 
                { 
                    this.Cursor = Cursors.Default;
                    //Process.Start(new ProcessStartInfo(pathSave) { UseShellExecute = true});
                }
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

        private void txtNFe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}