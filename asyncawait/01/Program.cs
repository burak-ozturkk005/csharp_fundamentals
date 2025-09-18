//async/await

async Task<string> GetData()
{
    using var http = new HttpClient();
    string html = await http.GetStringAsync("https://example.com");
    return html;
}
//GetStringAsync > ben gidip siteye sorayım, veriyi çekeyim diyor
//await > tamam sen gidip getir ben bu srada boş boş beklememeyeyim. Bitince bana haber ver diyor.
//async > bu metotta bekleme olabilir hazılrıklı ol.
//await > Burada işi başkasına pasla, bitince devam et.
//task > arkaplanda yapılacak işin temsilcisi.
//AWAIT
async Task<string> GetLink()
{
    using var http = new HttpClient();
    await Task.Delay(3000); //3 saniye bekle
    return "Link hazır.";
}
string link = await GetLink();
Console.WriteLine(link);