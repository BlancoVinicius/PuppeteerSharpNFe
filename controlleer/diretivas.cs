﻿using IntegrationPuppeteer;
using PuppeteerSharp;
using ConvertToCsv;


namespace diretivas { 


    
    public class controller
    {

        public static async Task dowloadChromium()
        {
            using var browserFetcher = new BrowserFetcher();
            await browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);
        }
    
        public async Task findNfeSaveCsv()
        {
            try
            {
                PuppeteerConnectBrowser p = new PuppeteerConnectBrowser();
                var listItens = await p.listData();
                CsvHeaderWriter csvHeaderWriter = new CsvHeaderWriter("C:\\TESTE\\teste2.csv", ';');

                foreach (var lista in listItens)
                {
                    csvHeaderWriter.WriteCsv(lista);
                }
    
                csvHeaderWriter.streamWriter.Close();

            }
            catch(UnauthorizedAccessException e)
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