using danfe;
using PuppeteerSharp;
using ConvertToCsv;


namespace diretivas
{ 
    //passar o nome do arquivo de forma dinamica
    //passar numero da nota de forma dinamica
    //passar path para salvamento de forma dinamica

    //https://consultadanfe.com/#

    
    public class controller
    {
        
        public static async Task dowloadChromium()
        {
            using var browserFetcher = new BrowserFetcher();
            await browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);
        }

        //public async Task findNfeSaveCsv(string pathFullName)
        //{
        //    try
        //    {
        //        PuppeteerConnectBrowserDanfe p = new PuppeteerConnectBrowserDanfe();
        //        var listItens = await p.listData();
        //        CsvHeaderWriter csvHeaderWriter = new CsvHeaderWriter(pathFullName, ';');

        //        foreach (var lista in listItens)
        //        {
        //            csvHeaderWriter.WriteCsv(lista);
        //        }

        //        csvHeaderWriter.streamWriter.Close();
        //    }
        //    catch (UnauthorizedAccessException e)
        //    {
        //        MessageBox.Show("Voçe não pode pode salvar o arquivo em um pasta com privilégisos de administrados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}



        public async Task findNfeSaveCsv(string pathFullName)
        {
            try
            {
                PuppeteerConnectBrowser p = new PuppeteerConnectBrowser();
                var listItens = await p.listData();
                CsvHeaderWriter csvHeaderWriter = new CsvHeaderWriter(pathFullName, ';');

                foreach (var lista in listItens)
                {
                    csvHeaderWriter.WriteCsv(lista);
                }

                csvHeaderWriter.streamWriter.Close();
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("Voçe não pode pode salvar o arquivo em um pasta com privilégisos de administrados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}