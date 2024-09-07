﻿// See https://aka.ms/new-console-template for more information
using HtmlAgilityPack;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://www.sbs.gob.pe/app/pp/sistip_portal/paginas/publicacion/tipocambiopromedio.aspx";
        using HttpClient client = new HttpClient();
        var resp = await client.GetStringAsync(url);

        if (resp != null)
        {
            var html = new HtmlDocument();
            html.LoadHtml(resp);
            var table = html.DocumentNode.SelectSingleNode("//table[@id='ctl00_cphContent_rgTipoCambio_ctl00']");
            var row = table.SelectSingleNode(".//tr[@id='ctl00_cphContent_rgTipoCambio_ctl00__0']");
            var nombreMoneda = row.SelectSingleNode(".//td[@class='APLI_fila3']");           
            var montoMoneda = row.SelectNodes(".//tr[@class=APLI_fila2']");
            var moneda =nombreMoneda.InnerText.Trim();
            var compra = montoMoneda[0].InnerText.Trim();
            var venta = montoMoneda[1].InnerText.Trim();
            Console.WriteLine($"Moneda: {moneda}");
            Console.WriteLine($"Compra: {compra}");
            Console.WriteLine($"Venta: {venta}");
        }
    }
}