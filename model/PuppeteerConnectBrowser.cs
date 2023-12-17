using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppeteerSharp;



namespace IntegrationPuppeteer
{
    public class PuppeteerConnectBrowser
    {
        public async Task<List<List<string>>> listData()
        {

            String[] argss = new String[1] { "--window-size=200,200" };
            List<List<string>> listItens = new List<List<string>>();

            try
            {
                using (var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = false, Args = argss }))
                {
                    using (var page = await browser.NewPageAsync())
                    {
                        await page.SetViewportAsync(new ViewPortOptions
                        { Width = 100, Height = 100, DeviceScaleFactor = 1 });
                        await page.GoToAsync("https://portaldatransparencia.gov.br/notas-fiscais/17231225043514000155558900059050071880657613?ordenarPor=dataEvento&direcao=asc");
                        var el = await page.WaitForSelectorAsync("#btnProdutosServicos");
                        await el.ClickAsync();


                        var th = await page.QuerySelectorAllAsync("#itens th");
                        var trs = await page.QuerySelectorAllAsync("#itens tr");
                        int thCount = th.Count();

                        List<string> listHeader = new List<string>();

                        for (int i = 0; i < thCount; i++)
                        {
                            var elTh = th.ElementAt(i);
                            var innertextHeader = await elTh.GetPropertyAsync("innerText");
                            listHeader.Add(await innertextHeader.JsonValueAsync<string>());
                        }

                        listItens.Add(listHeader);
                        foreach (var tr in trs)
                        {
                            var td = await tr.QuerySelectorAllAsync("td");
                            List<string>? listValue = new List<string>();
                            foreach (var item in td)
                            {
                                var texto = await item.GetPropertyAsync("innerText");
                                listValue.Add(await texto.JsonValueAsync<string>());
                            }
                            if (listValue.Count != 0)
                            {
                                listItens.Add(listValue);
                            }
                        }
                    }
                }
                return listItens;

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return listItens;
            }

        }

    }
    
}
