using HtmlAgilityPack;
using System;
using System.Net.Http;

namespace WebScraper
{
    class Program
    {
        static void Main(String[] args)
        {
            ;
            // Send get request to weather.com
            String urlIllinois = "https://weather.com/weather/today/l/624f0cccc10bececfa4c083056cef743837a76588790f476c9ebea44be35e51f";
            var httpClientIllinois = new HttpClient();
            var htmlIllInois = httpClientIllinois.GetStringAsync(urlIllinois).Result;
            var htmlDocumentIllinois = new HtmlDocument();
            htmlDocumentIllinois.LoadHtml(htmlIllInois);


            htmlDocumentIllinois.LoadHtml(htmlIllInois);
            // Get the temperature
            var HightemperatureElementIllinois = htmlDocumentIllinois.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureIllinois = HightemperatureElementIllinois.InnerText.Trim();
            Console.WriteLine(" highest Temperature expected: " + highttemperatureIllinois);

            // Get the conditions
            var conditionElementIllinois = htmlDocumentIllinois.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditions = conditionElementIllinois.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditions);

            // Get the location
            var cityElementIllinois = htmlDocumentIllinois.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityIllinois = cityElementIllinois.InnerText.Trim();
            Console.WriteLine("City: " + cityIllinois);

            String urlIllinoisA = "https://www.iqair.com/usa/illinois/chicago";
            var httpClientIllinoisA = new HttpClient();
            var htmlchicagoA = httpClientIllinoisA.GetStringAsync(urlIllinoisA).Result;
            var htmlDocumentIllinoisA = new HtmlDocument();
            htmlDocumentIllinoisA.LoadHtml(htmlchicagoA);

            var aircualElementIllinois = htmlDocumentIllinoisA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var aircualIllinois = aircualElementIllinois.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + aircualIllinois + " Where estado= " + '\u0022' + cityIllinois + '\u0022');



            String urlIllinoisCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/illinois/";
            var httpClientIllinoisCo = new HttpClient();
            var htmlIllinoisCo = httpClientIllinoisCo.GetStringAsync(urlIllinoisCo).Result;
            var htmlDocumentIllinoisCo
                = new HtmlDocument();
            htmlDocumentIllinoisCo.LoadHtml(htmlIllinoisCo);

            htmlDocumentIllinoisCo.LoadHtml(htmlIllinoisCo);
            var CovidCaseselementIllinois = htmlDocumentIllinoisCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesIllinois = CovidCaseselementIllinois.InnerText.Trim();
            decimal CovidCasesNumIllinois = Convert.ToDecimal(CovidCasesIllinois);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumIllinois + " Where estado= " + '\u0022' + cityIllinois + '\u0022');


            // Send get request to weather.com for California
            String urlCalifornia = "https://weather.com/weather/today/l/d1be3e5aec1726d0df2d6c19f21655d8892d3b197982f191b9dc36a6aa27333c";
            var httpClientCalifornia = new HttpClient();
            var htmlCalifornia = httpClientCalifornia.GetStringAsync(urlCalifornia).Result;
            var htmlDocumentCalifornia = new HtmlDocument();
            htmlDocumentCalifornia.LoadHtml(htmlCalifornia);

            // Get the temperature for California
            var HightemperatureElementCalifornia = htmlDocumentCalifornia.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureCalifornia = HightemperatureElementCalifornia.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureCalifornia);

            // Get the conditions for California
            var conditionElementCalifornia = htmlDocumentCalifornia.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsCalifornia = conditionElementCalifornia.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsCalifornia);

            // Get the location for California
            var cityElementCalifornia = htmlDocumentCalifornia.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityCalifornia = cityElementCalifornia.InnerText.Trim();
            Console.WriteLine("City: " + cityCalifornia);

            // Send get request to iqair.com for California
            String urlCaliforniaA = "https://www.iqair.com/usa/california/los-angeles";
            var httpClientCaliforniaA = new HttpClient();
            var htmlLosAngelesA = httpClientCaliforniaA.GetStringAsync(urlCaliforniaA).Result;
            var htmlDocumentLosAngelesA = new HtmlDocument();
            htmlDocumentLosAngelesA.LoadHtml(htmlLosAngelesA);

            var airQualityElementCalifornia = htmlDocumentLosAngelesA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityCalifornia = airQualityElementCalifornia.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityCalifornia + " Where estado= " + '\u0022' + cityCalifornia + '\u0022');

            // Send get request to worldometers.info for California
            String urlCaliforniaCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/california/";
            var httpClientCaliforniaCo = new HttpClient();
            var htmlCaliforniaCo = httpClientCaliforniaCo.GetStringAsync(urlCaliforniaCo).Result;
            var htmlDocumentCaliforniaCo = new HtmlDocument();
            htmlDocumentCaliforniaCo.LoadHtml(htmlCaliforniaCo);

            var CovidCaseselementCalifornia = htmlDocumentCaliforniaCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesCalifornia = CovidCaseselementCalifornia.InnerText.Trim();
            decimal CovidCasesNumCalifornia = Convert.ToDecimal(CovidCasesCalifornia);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumCalifornia + " Where estado= " + '\u0022' + cityCalifornia + '\u0022');


            // Send get request to weather.com for Texas
            String urlTexas = "https://weather.com/weather/today/l/11ced1a50f32c7cf61e54953785e421b2da48d77e41168794d1feb190a99d49b";
            var httpClientTexas = new HttpClient();
            var htmlTexas = httpClientTexas.GetStringAsync(urlTexas).Result;
            var htmlDocumentTexas = new HtmlDocument();
            htmlDocumentTexas.LoadHtml(htmlTexas);

            // Get the temperature for Texas
            var HightemperatureElementTexas = htmlDocumentTexas.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureTexas = HightemperatureElementTexas.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureTexas);

            // Get the conditions for Texas
            var conditionElementTexas = htmlDocumentTexas.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsTexas = conditionElementTexas.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsTexas);

            // Get the location for Texas
            var cityElementTexas = htmlDocumentTexas.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityTexas = cityElementTexas.InnerText.Trim();
            Console.WriteLine("City: " + cityTexas);

            // Send get request to iqair.com for Texas
            String urlTexasA = "https://www.iqair.com/usa/texas/austin";
            var httpClientTexasA = new HttpClient();
            var htmlHoustonA = httpClientTexasA.GetStringAsync(urlTexasA).Result;
            var htmlDocumentHoustonA = new HtmlDocument();
            htmlDocumentHoustonA.LoadHtml(htmlHoustonA);

            var airQualityElementTexas = htmlDocumentHoustonA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityTexas = airQualityElementTexas.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityTexas + " Where estado= " + '\u0022' + cityTexas + '\u0022');

            // Send get request to worldometers.info for Texas
            String urlTexasCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/texas/";
            var httpClientTexasCo = new HttpClient();
            var htmlTexasCo = httpClientTexasCo.GetStringAsync(urlTexasCo).Result;
            var htmlDocumentTexasCo = new HtmlDocument();
            htmlDocumentTexasCo.LoadHtml(htmlTexasCo);

            var CovidCaseselementTexas = htmlDocumentTexasCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesTexas = CovidCaseselementTexas.InnerText.Trim();
            decimal CovidCasesNumTexas = Convert.ToDecimal(CovidCasesTexas);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumTexas + " Where estado= " + '\u0022' + cityTexas + '\u0022');


            // Send get request to weather.com for Florida
            String urlFlorida = "https://weather.com/weather/today/l/7e9d86575c95148b7223887f96fdda1197a6dbe644f4c0dae9addb51395d92d5";
            var httpClientFlorida = new HttpClient();
            var htmlFlorida = httpClientFlorida.GetStringAsync(urlFlorida).Result;
            var htmlDocumentFlorida = new HtmlDocument();
            htmlDocumentFlorida.LoadHtml(htmlFlorida);

            // Get the temperature for Florida
            var HightemperatureElementFlorida = htmlDocumentFlorida.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureFlorida = HightemperatureElementFlorida.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureFlorida);

            // Get the conditions for Florida
            var conditionElementFlorida = htmlDocumentFlorida.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsFlorida = conditionElementFlorida.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsFlorida);

            // Get the location for Florida
            var cityElementFlorida = htmlDocumentFlorida.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityFlorida = cityElementFlorida.InnerText.Trim();
            Console.WriteLine("City: " + cityFlorida);

            // Send get request to iqair.com for Florida
            String urlFloridaA = "https://www.iqair.com/usa/florida/tallahassee";
            var httpClientFloridaA = new HttpClient();
            var htmlMiamiA = httpClientFloridaA.GetStringAsync(urlFloridaA).Result;
            var htmlDocumentTallahassee = new HtmlDocument();
            htmlDocumentTallahassee.LoadHtml(htmlMiamiA);

            var airQualityElementFlorida = htmlDocumentTallahassee.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityFlorida = airQualityElementFlorida.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityFlorida + " Where estado= " + '\u0022' + cityFlorida + '\u0022');

            // Send get request to worldometers.info for Florida
            String urlFloridaCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/florida/";
            var httpClientFloridaCo = new HttpClient();
            var htmlFloridaCo = httpClientFloridaCo.GetStringAsync(urlFloridaCo).Result;
            var htmlDocumentFloridaCo = new HtmlDocument();
            htmlDocumentFloridaCo.LoadHtml(htmlFloridaCo);

            var CovidCaseselementFlorida = htmlDocumentFloridaCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesFlorida = CovidCaseselementFlorida.InnerText.Trim();
            decimal CovidCasesNumFlorida = Convert.ToDecimal(CovidCasesFlorida);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumFlorida + " Where estado= " + '\u0022' + cityFlorida + '\u0022');


            // Send get request to weather.com for Pennsylvania
            String urlPennsylvania = "https://weather.com/weather/today/l/a3c2ebfbcc98af1b533214f4c9fcdc4cd0ef541ae77ba9576fa2504447a35ef8";
            var httpClientPennsylvania = new HttpClient();
            var htmlPennsylvania = httpClientPennsylvania.GetStringAsync(urlPennsylvania).Result;
            var htmlDocumentPennsylvania = new HtmlDocument();
            htmlDocumentPennsylvania.LoadHtml(htmlPennsylvania);

            // Get the temperature for Pennsylvania
            var HightemperatureElementPennsylvania = htmlDocumentPennsylvania.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperaturePennsylvania = HightemperatureElementPennsylvania.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperaturePennsylvania);

            // Get the conditions for Pennsylvania
            var conditionElementPennsylvania = htmlDocumentPennsylvania.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsPennsylvania = conditionElementPennsylvania.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsPennsylvania);

            // Get the location for Pennsylvania
            var cityElementPennsylvania = htmlDocumentPennsylvania.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityPennsylvania = cityElementPennsylvania.InnerText.Trim();
            Console.WriteLine("City: " + cityPennsylvania);

            // Send get request to iqair.com for Pennsylvania
            String urlPennsylvaniaA = "https://www.iqair.com/usa/pennsylvania/philadelphia";
            var httpClientPennsylvaniaA = new HttpClient();
            var htmlPhiladelphiaA = httpClientPennsylvaniaA.GetStringAsync(urlPennsylvaniaA).Result;
            var htmlDocumentPhiladelphiaA = new HtmlDocument();
            htmlDocumentPhiladelphiaA.LoadHtml(htmlPhiladelphiaA);

            var airQualityElementPennsylvania = htmlDocumentPhiladelphiaA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityPennsylvania = airQualityElementPennsylvania.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityPennsylvania + " Where estado= " + '\u0022' + cityPennsylvania + '\u0022');

            // Send get request to worldometers.info for Pennsylvania
            String urlPennsylvaniaCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/pennsylvania/";
            var httpClientPennsylvaniaCo = new HttpClient();
            var htmlPennsylvaniaCo = httpClientPennsylvaniaCo.GetStringAsync(urlPennsylvaniaCo).Result;
            var htmlDocumentPennsylvaniaCo = new HtmlDocument();
            htmlDocumentPennsylvaniaCo.LoadHtml(htmlPennsylvaniaCo);

            var CovidCaseselementPennsylvania = htmlDocumentPennsylvaniaCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesPennsylvania = CovidCaseselementPennsylvania.InnerText.Trim();
            decimal CovidCasesNumPennsylvania = Convert.ToDecimal(CovidCasesPennsylvania);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumPennsylvania + " Where estado= " + '\u0022' + cityPennsylvania + '\u0022');


            // Send get request to weather.com for North Carolina
            String urlNorthCarolina = "https://weather.com/weather/today/l/73fff128154fb2d7da0e7ad33920ddfa25fde0ea55eb76265badbe3c5c6ee0b1";
            var httpClientNorthCarolina = new HttpClient();
            var htmlNorthCarolina = httpClientNorthCarolina.GetStringAsync(urlNorthCarolina).Result;
            var htmlDocumentNorthCarolina = new HtmlDocument();
            htmlDocumentNorthCarolina.LoadHtml(htmlNorthCarolina);

            // Get the temperature for North Carolina
            var HightemperatureElementNorthCarolina = htmlDocumentNorthCarolina.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureNorthCarolina = HightemperatureElementNorthCarolina.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureNorthCarolina);

            // Get the conditions for North Carolina
            var conditionElementNorthCarolina = htmlDocumentNorthCarolina.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsNorthCarolina = conditionElementNorthCarolina.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsNorthCarolina);

            // Get the location for North Carolina
            var cityElementNorthCarolina = htmlDocumentNorthCarolina.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityNorthCarolina = cityElementNorthCarolina.InnerText.Trim();
            Console.WriteLine("City: " + cityNorthCarolina);

            // Send get request to iqair.com for North Carolina
            String urlNorthCarolinaA = "https://www.iqair.com/usa/north-carolina/raleigh";
            var httpClientNorthCarolinaA = new HttpClient();
            var htmlRaleighA = httpClientNorthCarolinaA.GetStringAsync(urlNorthCarolinaA).Result;
            var htmlDocumentRaleighA = new HtmlDocument();
            htmlDocumentRaleighA.LoadHtml(htmlRaleighA);

            var airQualityElementNorthCarolina = htmlDocumentRaleighA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityNorthCarolina = airQualityElementNorthCarolina.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityNorthCarolina + " Where estado= " + '\u0022' + cityNorthCarolina + '\u0022');

            // Send get request to worldometers.info for North Carolina
            String urlNorthCarolinaCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/north-carolina/";
            var httpClientNorthCarolinaCo = new HttpClient();
            var htmlNorthCarolinaCo = httpClientNorthCarolinaCo.GetStringAsync(urlNorthCarolinaCo).Result;
            var htmlDocumentNorthCarolinaCo = new HtmlDocument();
            htmlDocumentNorthCarolinaCo.LoadHtml(htmlNorthCarolinaCo);

            var CovidCaseselementNorthCarolina = htmlDocumentNorthCarolinaCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesNorthCarolina = CovidCaseselementNorthCarolina.InnerText.Trim();
            decimal CovidCasesNumNorthCarolina = Convert.ToDecimal(CovidCasesNorthCarolina);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumNorthCarolina + " Where estado= " + '\u0022' + cityNorthCarolina + '\u0022');


            // Send get request to weather.com for Ohio
            String urlOhio = "https://weather.com/weather/today/l/22f95f93bf8dd09a25319080a4edde543e8d8d240ab2d14b6f4894ac8f3991c8";
            var httpClientOhio = new HttpClient();
            var htmlOhio = httpClientOhio.GetStringAsync(urlOhio).Result;
            var htmlDocumentOhio = new HtmlDocument();
            htmlDocumentOhio.LoadHtml(htmlOhio);

            // Get the temperature for Ohio
            var HightemperatureElementOhio = htmlDocumentOhio.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureOhio = HightemperatureElementOhio.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureOhio);

            // Get the conditions for Ohio
            var conditionElementOhio = htmlDocumentOhio.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsOhio = conditionElementOhio.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsOhio);

            // Get the location for Ohio
            var cityElementOhio = htmlDocumentOhio.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityOhio = cityElementOhio.InnerText.Trim();
            Console.WriteLine("City: " + cityOhio);

            // Send get request to iqair.com for Ohio
            String urlOhioA = "https://www.iqair.com/usa/ohio/columbus";
            var httpClientOhioA = new HttpClient();
            var htmlColumbusA = httpClientOhioA.GetStringAsync(urlOhioA).Result;
            var htmlDocumentColumbusA = new HtmlDocument();
            htmlDocumentColumbusA.LoadHtml(htmlColumbusA);

            var airQualityElementOhio = htmlDocumentColumbusA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityOhio = airQualityElementOhio.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityOhio + " Where estado= " + '\u0022' + cityOhio + '\u0022');

            // Send get request to worldometers.info for Ohio
            String urlOhioCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/ohio/";
            var httpClientOhioCo = new HttpClient();
            var htmlOhioCo = httpClientOhioCo.GetStringAsync(urlOhioCo).Result;
            var htmlDocumentOhioCo = new HtmlDocument();
            htmlDocumentOhioCo.LoadHtml(htmlOhioCo);

            var CovidCaseselementOhio = htmlDocumentOhioCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesOhio = CovidCaseselementOhio.InnerText.Trim();
            decimal CovidCasesNumOhio = Convert.ToDecimal(CovidCasesOhio);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumOhio + " Where estado= " + '\u0022' + cityOhio + '\u0022');


            // Send get request to weather.com for Georgia
            String urlGeorgia = "https://weather.com/weather/today/l/5ac25efae2da09ef41a88d34d013308e7e65963c09e202cb63ee11437c619d71";
            var httpClientGeorgia = new HttpClient();
            var htmlGeorgia = httpClientGeorgia.GetStringAsync(urlGeorgia).Result;
            var htmlDocumentGeorgia = new HtmlDocument();
            htmlDocumentGeorgia.LoadHtml(htmlGeorgia);

            // Get the temperature for Georgia
            var HightemperatureElementGeorgia = htmlDocumentGeorgia.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureGeorgia = HightemperatureElementGeorgia.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureGeorgia);

            // Get the conditions for Georgia
            var conditionElementGeorgia = htmlDocumentGeorgia.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsGeorgia = conditionElementGeorgia.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsGeorgia);

            // Get the location for Georgia
            var cityElementGeorgia = htmlDocumentGeorgia.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityGeorgia = cityElementGeorgia.InnerText.Trim();
            Console.WriteLine("City: " + cityGeorgia);

            // Send get request to iqair.com for Georgia
            String urlGeorgiaA = "https://www.iqair.com/usa/georgia/atlanta";
            var httpClientGeorgiaA = new HttpClient();
            var htmlAtlantaA = httpClientGeorgiaA.GetStringAsync(urlGeorgiaA).Result;
            var htmlDocumentAtlantaA = new HtmlDocument();
            htmlDocumentAtlantaA.LoadHtml(htmlAtlantaA);

            var airQualityElementGeorgia = htmlDocumentAtlantaA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityGeorgia = airQualityElementGeorgia.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityGeorgia + " Where estado= " + '\u0022' + cityGeorgia + '\u0022');

            // Send get request to worldometers.info for Georgia
            String urlGeorgiaCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/georgia/";
            var httpClientGeorgiaCo = new HttpClient();
            var htmlGeorgiaCo = httpClientGeorgiaCo.GetStringAsync(urlGeorgiaCo).Result;
            var htmlDocumentGeorgiaCo = new HtmlDocument();
            htmlDocumentGeorgiaCo.LoadHtml(htmlGeorgiaCo);

            var CovidCaseselementGeorgia = htmlDocumentGeorgiaCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesGeorgia = CovidCaseselementGeorgia.InnerText.Trim();
            decimal CovidCasesNumGeorgia = Convert.ToDecimal(CovidCasesGeorgia);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumGeorgia + " Where estado= " + '\u0022' + cityGeorgia + '\u0022');


            // Send get request to weather.com for Michigan
            String urlMichigan = "https://weather.com/weather/today/l/67182baa187fb3d5599acefe1d9b112228928ab581352910469f13d2c5f46208";
            var httpClientMichigan = new HttpClient();
            var htmlMichigan = httpClientMichigan.GetStringAsync(urlMichigan).Result;
            var htmlDocumentMichigan = new HtmlDocument();
            htmlDocumentMichigan.LoadHtml(htmlMichigan);

            // Get the temperature for Michigan
            var HightemperatureElementMichigan = htmlDocumentMichigan.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureMichigan = HightemperatureElementMichigan.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureMichigan);

            // Get the conditions for Michigan
            var conditionElementMichigan = htmlDocumentMichigan.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsMichigan = conditionElementMichigan.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsMichigan);

            // Get the location for Michigan
            var cityElementMichigan = htmlDocumentMichigan.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityMichigan = cityElementMichigan.InnerText.Trim();
            Console.WriteLine("City: " + cityMichigan);

            // Send get request to iqair.com for Michigan
            String urlMichiganA = "https://www.iqair.com/usa/michigan/detroit";
            var httpClientMichiganA = new HttpClient();
            var htmlDetroitA = httpClientMichiganA.GetStringAsync(urlMichiganA).Result;
            var htmlDocumentDetroitA = new HtmlDocument();
            htmlDocumentDetroitA.LoadHtml(htmlDetroitA);

            var airQualityElementMichigan = htmlDocumentDetroitA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityMichigan = airQualityElementMichigan.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityMichigan + " Where estado= " + '\u0022' + cityMichigan + '\u0022');

            // Send get request to worldometers.info for Michigan
            String urlMichiganCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/michigan/";
            var httpClientMichiganCo = new HttpClient();
            var htmlMichiganCo = httpClientMichiganCo.GetStringAsync(urlMichiganCo).Result;
            var htmlDocumentMichiganCo = new HtmlDocument();
            htmlDocumentMichiganCo.LoadHtml(htmlMichiganCo);

            var CovidCaseselementMichigan = htmlDocumentMichiganCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesMichigan = CovidCaseselementMichigan.InnerText.Trim();
            decimal CovidCasesNumMichigan = Convert.ToDecimal(CovidCasesMichigan);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumMichigan + " Where estado= " + '\u0022' + cityMichigan + '\u0022');


            // Send get request to weather.com for New Jersey
            String urlNewJersey = "https://weather.com/weather/today/l/91bb4f38a94d219572b1ba247902e95978f72437f97075783dc3c42cb2754039";
            var httpClientNewJersey = new HttpClient();
            var htmlNewJersey = httpClientNewJersey.GetStringAsync(urlNewJersey).Result;
            var htmlDocumentNewJersey = new HtmlDocument();
            htmlDocumentNewJersey.LoadHtml(htmlNewJersey);

            // Get the temperature for New Jersey
            var HightemperatureElementNewJersey = htmlDocumentNewJersey.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureNewJersey = HightemperatureElementNewJersey.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureNewJersey);

            // Get the conditions for New Jersey
            var conditionElementNewJersey = htmlDocumentNewJersey.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsNewJersey = conditionElementNewJersey.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsNewJersey);

            // Get the location for New Jersey
            var cityElementNewJersey = htmlDocumentNewJersey.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityNewJersey = cityElementNewJersey.InnerText.Trim();
            Console.WriteLine("City: " + cityNewJersey);

            // Send get request to iqair.com for New Jersey
            String urlNewJerseyA = "https://www.iqair.com/usa/new-jersey/newark";
            var httpClientNewJerseyA = new HttpClient();
            var htmlNewarkA = httpClientNewJerseyA.GetStringAsync(urlNewJerseyA).Result;
            var htmlDocumentNewarkA = new HtmlDocument();
            htmlDocumentNewarkA.LoadHtml(htmlNewarkA);

            var airQualityElementNewJersey = htmlDocumentNewarkA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityNewJersey = airQualityElementNewJersey.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityNewJersey + " Where estado= " + '\u0022' + cityNewJersey + '\u0022');

            // Send get request to worldometers.info for New Jersey
            String urlNewJerseyCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/new-jersey/";
            var httpClientNewJerseyCo = new HttpClient();
            var htmlNewJerseyCo = httpClientNewJerseyCo.GetStringAsync(urlNewJerseyCo).Result;
            var htmlDocumentNewJerseyCo = new HtmlDocument();
            htmlDocumentNewJerseyCo.LoadHtml(htmlNewJerseyCo);

            var CovidCaseselementNewJersey = htmlDocumentNewJerseyCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesNewJersey = CovidCaseselementNewJersey.InnerText.Trim();
            decimal CovidCasesNumNewJersey = Convert.ToDecimal(CovidCasesNewJersey);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumNewJersey + " Where estado= " + '\u0022' + cityNewJersey + '\u0022');


            // Send get request to weather.com for Tennessee
            String urlTennessee = "https://weather.com/weather/today/l/186a81e22474b3fb49f488cbf30fb246b6fdbe59c85c554439e1fc7992e7601f";
            var httpClientTennessee = new HttpClient();
            var htmlTennessee = httpClientTennessee.GetStringAsync(urlTennessee).Result;
            var htmlDocumentTennessee = new HtmlDocument();
            htmlDocumentTennessee.LoadHtml(htmlTennessee);

            // Get the temperature for Tennessee
            var HightemperatureElementTennessee = htmlDocumentTennessee.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureTennessee = HightemperatureElementTennessee.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureTennessee);

            // Get the conditions for Tennessee
            var conditionElementTennessee = htmlDocumentTennessee.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsTennessee = conditionElementTennessee.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsTennessee);

            // Get the location for Tennessee
            var cityElementTennessee = htmlDocumentTennessee.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityTennessee = cityElementTennessee.InnerText.Trim();
            Console.WriteLine("City: " + cityTennessee);

            // Send get request to iqair.com for Tennessee
            String urlTennesseeA = "https://www.iqair.com/usa/tennessee/nashville";
            var httpClientTennesseeA = new HttpClient();
            var htmlNashvilleA = httpClientTennesseeA.GetStringAsync(urlTennesseeA).Result;
            var htmlDocumentNashvilleA = new HtmlDocument();
            htmlDocumentNashvilleA.LoadHtml(htmlNashvilleA);

            var airQualityElementTennessee = htmlDocumentNashvilleA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityTennessee = airQualityElementTennessee.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityTennessee + " Where estado= " + '\u0022' + cityTennessee + '\u0022');

            // Send get request to worldometers.info for Tennessee
            String urlTennesseeCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/tennessee/";
            var httpClientTennesseeCo = new HttpClient();
            var htmlTennesseeCo = httpClientTennesseeCo.GetStringAsync(urlTennesseeCo).Result;
            var htmlDocumentTennesseeCo = new HtmlDocument();
            htmlDocumentTennesseeCo.LoadHtml(htmlTennesseeCo);

            var CovidCaseselementTennessee = htmlDocumentTennesseeCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesTennessee = CovidCaseselementTennessee.InnerText.Trim();
            decimal CovidCasesNumTennessee = Convert.ToDecimal(CovidCasesTennessee);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumTennessee + " Where estado= " + '\u0022' + cityTennessee + '\u0022');


            // Send get request to weather.com for Arizona
            String urlArizona = "https://weather.com/weather/today/l/db20864c0126ac8fefa7670ac10d78bdfcdfe8eb9d8f1aae0aadbd1b776809ca";
            var httpClientArizona = new HttpClient();
            var htmlArizona = httpClientArizona.GetStringAsync(urlArizona).Result;
            var htmlDocumentArizona = new HtmlDocument();
            htmlDocumentArizona.LoadHtml(htmlArizona);

            // Get the temperature for Arizona
            var HightemperatureElementArizona = htmlDocumentArizona.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureArizona = HightemperatureElementArizona.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureArizona);

            // Get the conditions for Arizona
            var conditionElementArizona = htmlDocumentArizona.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsArizona = conditionElementArizona.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsArizona);

            // Get the location for Arizona
            var cityElementArizona = htmlDocumentArizona.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityArizona = cityElementArizona.InnerText.Trim();
            Console.WriteLine("City: " + cityArizona);

            // Send get request to iqair.com for Arizona
            String urlArizonaA = "https://www.iqair.com/usa/arizona/phoenix";
            var httpClientArizonaA = new HttpClient();
            var htmlPhoenixA = httpClientArizonaA.GetStringAsync(urlArizonaA).Result;
            var htmlDocumentPhoenixA = new HtmlDocument();
            htmlDocumentPhoenixA.LoadHtml(htmlPhoenixA);

            var airQualityElementArizona = htmlDocumentPhoenixA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityArizona = airQualityElementArizona.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityArizona + " Where estado= " + '\u0022' + cityArizona + '\u0022');

            // Send get request to worldometers.info for Arizona
            String urlArizonaCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/arizona/";
            var httpClientArizonaCo = new HttpClient();
            var htmlArizonaCo = httpClientArizonaCo.GetStringAsync(urlArizonaCo).Result;
            var htmlDocumentArizonaCo = new HtmlDocument();
            htmlDocumentArizonaCo.LoadHtml(htmlArizonaCo);

            var CovidCaseselementArizona = htmlDocumentArizonaCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesArizona = CovidCaseselementArizona.InnerText.Trim();
            decimal CovidCasesNumArizona = Convert.ToDecimal(CovidCasesArizona);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumArizona + " Where estado= " + '\u0022' + cityArizona + '\u0022');


            // Send get request to weather.com for Virginia
            String urlVirginia = "https://weather.com/weather/today/l/45f08ac6d380f3261e631578acc83b6a7cbd306aaa37be501198d949b60ac84f";
            var httpClientVirginia = new HttpClient();
            var htmlVirginia = httpClientVirginia.GetStringAsync(urlVirginia).Result;
            var htmlDocumentVirginia = new HtmlDocument();
            htmlDocumentVirginia.LoadHtml(htmlVirginia);

            // Get the temperature for Virginia
            var HightemperatureElementVirginia = htmlDocumentVirginia.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureVirginia = HightemperatureElementVirginia.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureVirginia);

            // Get the conditions for Virginia
            var conditionElementVirginia = htmlDocumentVirginia.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsVirginia = conditionElementVirginia.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsVirginia);

            // Get the location for Virginia
            var cityElementVirginia = htmlDocumentVirginia.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityVirginia = cityElementVirginia.InnerText.Trim();
            Console.WriteLine("City: " + cityVirginia);

            // Send get request to iqair.com for Virginia
            String urlVirginiaA = "https://www.iqair.com/usa/virginia/richmond";
            var httpClientVirginiaA = new HttpClient();
            var htmlRichmondA = httpClientVirginiaA.GetStringAsync(urlVirginiaA).Result;
            var htmlDocumentRichmondA = new HtmlDocument();
            htmlDocumentRichmondA.LoadHtml(htmlRichmondA);

            var airQualityElementVirginia = htmlDocumentRichmondA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityVirginia = airQualityElementVirginia.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityVirginia + " Where estado= " + '\u0022' + cityVirginia + '\u0022');

            // Send get request to worldometers.info for Virginia
            String urlVirginiaCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/virginia/";
            var httpClientVirginiaCo = new HttpClient();
            var htmlVirginiaCo = httpClientVirginiaCo.GetStringAsync(urlVirginiaCo).Result;
            var htmlDocumentVirginiaCo = new HtmlDocument();
            htmlDocumentVirginiaCo.LoadHtml(htmlVirginiaCo);

            var CovidCaseselementVirginia = htmlDocumentVirginiaCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesVirginia = CovidCaseselementVirginia.InnerText.Trim();
            decimal CovidCasesNumVirginia = Convert.ToDecimal(CovidCasesVirginia);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumVirginia + " Where estado= " + '\u0022' + cityVirginia + '\u0022');


            // Send get request to weather.com for Massachusetts
            String urlMassachusetts = "https://weather.com/weather/today/l/6f03ddf87585ae5600e3dee28e519d788ddeb749efefa3f236796ef7167fc411";
            var httpClientMassachusetts = new HttpClient();
            var htmlMassachusetts = httpClientMassachusetts.GetStringAsync(urlMassachusetts).Result;
            var htmlDocumentMassachusetts = new HtmlDocument();
            htmlDocumentMassachusetts.LoadHtml(htmlMassachusetts);

            // Get the temperature for Massachusetts
            var HightemperatureElementMassachusetts = htmlDocumentMassachusetts.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureMassachusetts = HightemperatureElementMassachusetts.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureMassachusetts);

            // Get the conditions for Massachusetts
            var conditionElementMassachusetts = htmlDocumentMassachusetts.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsMassachusetts = conditionElementMassachusetts.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsMassachusetts);

            // Get the location for Massachusetts
            var cityElementMassachusetts = htmlDocumentMassachusetts.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityMassachusetts = cityElementMassachusetts.InnerText.Trim();
            Console.WriteLine("City: " + cityMassachusetts);

            // Send get request to iqair.com for Massachusetts
            String urlMassachusettsA = "https://www.iqair.com/usa/massachusetts/boston";
            var httpClientMassachusettsA = new HttpClient();
            var htmlBostonA = httpClientMassachusettsA.GetStringAsync(urlMassachusettsA).Result;
            var htmlDocumentBostonA = new HtmlDocument();
            htmlDocumentBostonA.LoadHtml(htmlBostonA);

            var airQualityElementMassachusetts = htmlDocumentBostonA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityMassachusetts = airQualityElementMassachusetts.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityMassachusetts + " Where estado= " + '\u0022' + cityMassachusetts + '\u0022');

            // Send get request to worldometers.info for Massachusetts
            String urlMassachusettsCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/massachusetts/";
            var httpClientMassachusettsCo = new HttpClient();
            var htmlMassachusettsCo = httpClientMassachusettsCo.GetStringAsync(urlMassachusettsCo).Result;
            var htmlDocumentMassachusettsCo = new HtmlDocument();
            htmlDocumentMassachusettsCo.LoadHtml(htmlMassachusettsCo);

            var CovidCaseselementMassachusetts = htmlDocumentMassachusettsCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesMassachusetts = CovidCaseselementMassachusetts.InnerText.Trim();
            decimal CovidCasesNumMassachusetts = Convert.ToDecimal(CovidCasesMassachusetts);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumMassachusetts + " Where estado= " + '\u0022' + cityMassachusetts + '\u0022');


            // Send get request to weather.com for Indiana
            String urlIndiana = "https://weather.com/weather/today/l/0cb740ae40518252bdebfa05d6f47d943f870ddc520e94d5316910439d60bc25";
            var httpClientIndiana = new HttpClient();
            var htmlIndiana = httpClientIndiana.GetStringAsync(urlIndiana).Result;
            var htmlDocumentIndiana = new HtmlDocument();
            htmlDocumentIndiana.LoadHtml(htmlIndiana);

            // Get the temperature for Indiana
            var HightemperatureElementIndiana = htmlDocumentIndiana.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureIndiana = HightemperatureElementIndiana.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureIndiana);

            // Get the conditions for Indiana
            var conditionElementIndiana = htmlDocumentIndiana.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsIndiana = conditionElementIndiana.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsIndiana);

            // Get the location for Indiana
            var cityElementIndiana = htmlDocumentIndiana.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityIndiana = cityElementIndiana.InnerText.Trim();
            Console.WriteLine("City: " + cityIndiana);

            // Send get request to iqair.com for Indiana
            String urlIndianaA = "https://www.iqair.com/usa/indiana/indianapolis";
            var httpClientIndianaA = new HttpClient();
            var htmlIndianapolisA = httpClientIndianaA.GetStringAsync(urlIndianaA).Result;
            var htmlDocumentIndianapolisA = new HtmlDocument();
            htmlDocumentIndianapolisA.LoadHtml(htmlIndianapolisA);

            var airQualityElementIndiana = htmlDocumentIndianapolisA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityIndiana = airQualityElementIndiana.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityIndiana + " Where estado= " + '\u0022' + cityIndiana + '\u0022');

            // Send get request to worldometers.info for Indiana
            String urlIndianaCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/indiana/";
            var httpClientIndianaCo = new HttpClient();
            var htmlIndianaCo = httpClientIndianaCo.GetStringAsync(urlIndianaCo).Result;
            var htmlDocumentIndianaCo = new HtmlDocument();
            htmlDocumentIndianaCo.LoadHtml(htmlIndianaCo);

            var CovidCaseselementIndiana = htmlDocumentIndianaCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesIndiana = CovidCaseselementIndiana.InnerText.Trim();
            decimal CovidCasesNumIndiana = Convert.ToDecimal(CovidCasesIndiana);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumIndiana + " Where estado= " + '\u0022' + cityIndiana + '\u0022');

            // Send get request to weather.com for Wisconsin
            String urlWisconsin = "https://weather.com/weather/today/l/195e999bd129ae70f07d61c7ca8629e414b925c1ffe2d1511ac2f4a0c54850e2";
            var httpClientWisconsin = new HttpClient();
            var htmlWisconsin = httpClientWisconsin.GetStringAsync(urlWisconsin).Result;
            var htmlDocumentWisconsin = new HtmlDocument();
            htmlDocumentWisconsin.LoadHtml(htmlWisconsin);

            // Get the temperature for Wisconsin
            var HightemperatureElementWisconsin = htmlDocumentWisconsin.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var hightemperatureWisconsin = HightemperatureElementWisconsin.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + hightemperatureWisconsin);

            // Get the conditions for Wisconsin
            var conditionElementWisconsin = htmlDocumentWisconsin.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsWisconsin = conditionElementWisconsin.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsWisconsin);

            // Get the location for Wisconsin
            var cityElementWisconsin = htmlDocumentWisconsin.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityWisconsin = cityElementWisconsin.InnerText.Trim();
            Console.WriteLine("City: " + cityWisconsin);

            // Send get request to iqair.com for Wisconsin
            String urlWisconsinA = "https://www.iqair.com/usa/wisconsin/milwaukee";
            var httpClientWisconsinA = new HttpClient();
            var htmlMilwaukeeA = httpClientWisconsinA.GetStringAsync(urlWisconsinA).Result;
            var htmlDocumentMilwaukeeA = new HtmlDocument();
            htmlDocumentMilwaukeeA.LoadHtml(htmlMilwaukeeA);

            var airQualityElementWisconsin = htmlDocumentMilwaukeeA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityWisconsin = airQualityElementWisconsin.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityWisconsin + " Where estado= " + '\u0022' + cityWisconsin + '\u0022');

            // Send get request to worldometers.info for Wisconsin
            String urlWisconsinCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/wisconsin/";
            var httpClientWisconsinCo = new HttpClient();
            var htmlWisconsinCo = httpClientWisconsinCo.GetStringAsync(urlWisconsinCo).Result;
            var htmlDocumentWisconsinCo = new HtmlDocument();
            htmlDocumentWisconsinCo.LoadHtml(htmlWisconsinCo);

            var CovidCaseselementWisconsin = htmlDocumentWisconsinCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesWisconsin = CovidCaseselementWisconsin.InnerText.Trim();
            decimal CovidCasesNumWisconsin = Convert.ToDecimal(CovidCasesWisconsin);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumWisconsin + " Where estado= " + '\u0022' + cityWisconsin + '\u0022');

            // Send a GET request to weather.com for Washington
            string urlWashington = "https://weather.com/weather/today/l/448ae8141eaaad900798d0b2d8d69b6a96c10cea9e8d8fe657a0d8ab045a111b";
            var httpClientWashington = new HttpClient();
            var htmlWashington = httpClientWashington.GetStringAsync(urlWashington).Result;
            var htmlDocumentWashington = new HtmlDocument();
            htmlDocumentWashington.LoadHtml(htmlWashington);

            // Get the temperature for Washington
            var highTemperatureElementWashington = htmlDocumentWashington.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highTemperatureWashington = highTemperatureElementWashington.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highTemperatureWashington);

            // Get the conditions for Washington
            var conditionElementWashington = htmlDocumentWashington.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsWashington = conditionElementWashington.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsWashington);

            // Get the location for Washington
            var cityElementWashington = htmlDocumentWashington.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityWashington = cityElementWashington.InnerText.Trim();
            Console.WriteLine("City: " + cityWashington);

            // Send a GET request to iqair.com for Washington
            string urlWashingtonA = "https://www.iqair.com/usa/washington/seattle"; // Update the URL for Washington
            var httpClientWashingtonA = new HttpClient();
            var htmlSeattleA = httpClientWashingtonA.GetStringAsync(urlWashingtonA).Result;
            var htmlDocumentSeattleA = new HtmlDocument();
            htmlDocumentSeattleA.LoadHtml(htmlSeattleA);

            var airQualityElementWashington = htmlDocumentSeattleA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityWashington = airQualityElementWashington.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityWashington + " Where estado= " + '\u0022' + cityWashington + '\u0022');

            // Send a GET request to worldometers.info for Washington
            string urlWashingtonCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/washington//"; // Update the URL for Washington
            var httpClientWashingtonCo = new HttpClient();
            var htmlWashingtonCo = httpClientWashingtonCo.GetStringAsync(urlWashingtonCo).Result;
            var htmlDocumentWashingtonCo = new HtmlDocument();
            htmlDocumentWashingtonCo.LoadHtml(htmlWashingtonCo);

            var CovidCasesElementWashington = htmlDocumentWashingtonCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesWashington = CovidCasesElementWashington.InnerText.Trim();
            decimal CovidCasesNumWashington = Convert.ToDecimal(CovidCasesWashington);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumWashington + " Where estado= " + '\u0022' + cityWashington + '\u0022');


            // Send get request to weather.com for South Carolina
            String urlSouthCarolina = "https://weather.com/weather/today/l/e6aefab22b1dff1e631d94b13db6fd56e96b1900dfe42a5fa7cfadbf49dc4699";
            var httpClientSouthCarolina = new HttpClient();
            var htmlSouthCarolina = httpClientSouthCarolina.GetStringAsync(urlSouthCarolina).Result;
            var htmlDocumentSouthCarolina = new HtmlDocument();
            htmlDocumentSouthCarolina.LoadHtml(htmlSouthCarolina);

            // Get the temperature for South Carolina
            var HightemperatureElementSouthCarolina = htmlDocumentSouthCarolina.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var highttemperatureSouthCarolina = HightemperatureElementSouthCarolina.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + highttemperatureSouthCarolina);

            // Get the conditions for South Carolina
            var conditionElementSouthCarolina = htmlDocumentSouthCarolina.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsSouthCarolina = conditionElementSouthCarolina.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsSouthCarolina);

            // Get the location for South Carolina
            var cityElementSouthCarolina = htmlDocumentSouthCarolina.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var citySouthCarolina = cityElementSouthCarolina.InnerText.Trim();
            Console.WriteLine("City: " + citySouthCarolina);

            // Send get request to iqair.com for South Carolina
            String urlSouthCarolinaA = "https://www.iqair.com/usa/south-carolina/charleston";
            var httpClientSouthCarolinaA = new HttpClient();
            var htmlCharlestonA = httpClientSouthCarolinaA.GetStringAsync(urlSouthCarolinaA).Result;
            var htmlDocumentCharlestonA = new HtmlDocument();
            htmlDocumentCharlestonA.LoadHtml(htmlCharlestonA);

            var airQualityElementSouthCarolina = htmlDocumentCharlestonA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualitySouthCarolina = airQualityElementSouthCarolina.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualitySouthCarolina + " Where estado= " + '\u0022' + citySouthCarolina + '\u0022');

            // Send get request to worldometers.info for South Carolina
            String urlSouthCarolinaCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/south-carolina/";
            var httpClientSouthCarolinaCo = new HttpClient();
            var htmlSouthCarolinaCo = httpClientSouthCarolinaCo.GetStringAsync(urlSouthCarolinaCo).Result;
            var htmlDocumentSouthCarolinaCo = new HtmlDocument();
            htmlDocumentSouthCarolinaCo.LoadHtml(htmlSouthCarolinaCo);

            var CovidCaseselementSouthCarolina = htmlDocumentSouthCarolinaCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesSouthCarolina = CovidCaseselementSouthCarolina.InnerText.Trim();
            decimal CovidCasesNumSouthCarolina = Convert.ToDecimal(CovidCasesSouthCarolina);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumSouthCarolina + " Where estado= " + '\u0022' + citySouthCarolina + '\u0022');


            // Send get request to weather.com for Minnesota
            String urlMinnesota = "https://weather.com/weather/today/l/bf6dff92b2dfcdea92ec11f9d4530c164566f7ee02fbf671fbc028f0eb2dc67f";
            var httpClientMinnesota = new HttpClient();
            var htmlMinnesota = httpClientMinnesota.GetStringAsync(urlMinnesota).Result;
            var htmlDocumentMinnesota = new HtmlDocument();
            htmlDocumentMinnesota.LoadHtml(htmlMinnesota);

            // Get the temperature for Minnesota
            var HightemperatureElementMinnesota = htmlDocumentMinnesota.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var hightemperatureMinnesota = HightemperatureElementMinnesota.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + hightemperatureMinnesota);

            // Get the conditions for Minnesota
            var conditionElementMinnesota = htmlDocumentMinnesota.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsMinnesota = conditionElementMinnesota.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsMinnesota);

            // Get the location for Minnesota
            var cityElementMinnesota = htmlDocumentMinnesota.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityMinnesota = cityElementMinnesota.InnerText.Trim();
            Console.WriteLine("City: " + cityMinnesota);

            // Send get request to iqair.com for Minnesota
            String urlMinnesotaA = "https://www.iqair.com/usa/minnesota/minneapolis";
            var httpClientMinnesotaA = new HttpClient();
            var htmlMinneapolisA = httpClientMinnesotaA.GetStringAsync(urlMinnesotaA).Result;
            var htmlDocumentMinneapolisA = new HtmlDocument();
            htmlDocumentMinneapolisA.LoadHtml(htmlMinneapolisA);

            var airQualityElementMinnesota = htmlDocumentMinneapolisA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityMinnesota = airQualityElementMinnesota.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityMinnesota + " Where estado= " + '\u0022' + cityMinnesota + '\u0022');

            // Send get request to worldometers.info for Minnesota
            String urlMinnesotaCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/minnesota/";
            var httpClientMinnesotaCo = new HttpClient();
            var htmlMinnesotaCo = httpClientMinnesotaCo.GetStringAsync(urlMinnesotaCo).Result;
            var htmlDocumentMinnesotaCo = new HtmlDocument();
            htmlDocumentMinnesotaCo.LoadHtml(htmlMinnesotaCo);

            var CovidCaseselementMinnesota = htmlDocumentMinnesotaCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesMinnesota = CovidCaseselementMinnesota.InnerText.Trim();
            decimal CovidCasesNumMinnesota = Convert.ToDecimal(CovidCasesMinnesota);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumMinnesota + " Where estado= " + '\u0022' + cityMinnesota + '\u0022');


            // Send get request to weather.com for Colorado
            String urlColorado = "https://weather.com/weather/today/l/3f345b93f02bdea125a122a4798a6b17174a3153bb0f45b4d5238343613d7368";
            var httpClientColorado = new HttpClient();
            var htmlColorado = httpClientColorado.GetStringAsync(urlColorado).Result;
            var htmlDocumentColorado = new HtmlDocument();
            htmlDocumentColorado.LoadHtml(htmlColorado);

            // Get the temperature for Colorado
            var HightemperatureElementColorado = htmlDocumentColorado.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var hightemperatureColorado = HightemperatureElementColorado.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + hightemperatureColorado);

            // Get the conditions for Colorado
            var conditionElementColorado = htmlDocumentColorado.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsColorado = conditionElementColorado.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsColorado);

            // Get the location for Colorado
            var cityElementColorado = htmlDocumentColorado.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityColorado = cityElementColorado.InnerText.Trim();
            Console.WriteLine("City: " + cityColorado);

            // Send get request to iqair.com for Colorado
            String urlColoradoA = "https://www.iqair.com/usa/colorado/denver";
            var httpClientColoradoA = new HttpClient();
            var htmlDenverA = httpClientColoradoA.GetStringAsync(urlColoradoA).Result;
            var htmlDocumentDenverA = new HtmlDocument();
            htmlDocumentDenverA.LoadHtml(htmlDenverA);

            var airQualityElementColorado = htmlDocumentDenverA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityColorado = airQualityElementColorado.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityColorado + " Where estado= " + '\u0022' + cityColorado + '\u0022');

            // Send get request to worldometers.info for Colorado
            String urlColoradoCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/colorado/";
            var httpClientColoradoCo = new HttpClient();
            var htmlColoradoCo = httpClientColoradoCo.GetStringAsync(urlColoradoCo).Result;
            var htmlDocumentColoradoCo = new HtmlDocument();
            htmlDocumentColoradoCo.LoadHtml(htmlColoradoCo);

            var CovidCaseselementColorado = htmlDocumentColoradoCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesColorado = CovidCaseselementColorado.InnerText.Trim();
            decimal CovidCasesNumColorado = Convert.ToDecimal(CovidCasesColorado);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumColorado + " Where estado= " + '\u0022' + cityColorado + '\u0022');


            // Send get request to weather.com for Louisiana
            String urlLouisiana = "https://weather.com/weather/today/l/3515239198508b1ca7a9cd5fc912004aeea27f8e1d3fae87afade88fa6bd38df";
            var httpClientLouisiana = new HttpClient();
            var htmlLouisiana = httpClientLouisiana.GetStringAsync(urlLouisiana).Result;
            var htmlDocumentLouisiana = new HtmlDocument();
            htmlDocumentLouisiana.LoadHtml(htmlLouisiana);

            // Get the temperature for Louisiana
            var HightemperatureElementLouisiana = htmlDocumentLouisiana.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var hightemperatureLouisiana = HightemperatureElementLouisiana.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + hightemperatureLouisiana);

            // Get the conditions for Louisiana
            var conditionElementLouisiana = htmlDocumentLouisiana.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsLouisiana = conditionElementLouisiana.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsLouisiana);

            // Get the location for Louisiana
            var cityElementLouisiana = htmlDocumentLouisiana.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityLouisiana = cityElementLouisiana.InnerText.Trim();
            Console.WriteLine("City: " + cityLouisiana);

            // Send get request to iqair.com for Louisiana
            String urlLouisianaA = "https://www.iqair.com/usa/louisiana/new-orleans";
            var httpClientLouisianaA = new HttpClient();
            var htmlNewOrleansA = httpClientLouisianaA.GetStringAsync(urlLouisianaA).Result;
            var htmlDocumentNewOrleansA = new HtmlDocument();
            htmlDocumentNewOrleansA.LoadHtml(htmlNewOrleansA);

            var airQualityElementLouisiana = htmlDocumentNewOrleansA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityLouisiana = airQualityElementLouisiana.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityLouisiana + " Where estado= " + '\u0022' + cityLouisiana + '\u0022');

            // Send get request to worldometers.info for Louisiana
            String urlLouisianaCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/louisiana/";
            var httpClientLouisianaCo = new HttpClient();
            var htmlLouisianaCo = httpClientLouisianaCo.GetStringAsync(urlLouisianaCo).Result;
            var htmlDocumentLouisianaCo = new HtmlDocument();
            htmlDocumentLouisianaCo.LoadHtml(htmlLouisianaCo);

            var CovidCaseselementLouisiana = htmlDocumentLouisianaCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesLouisiana = CovidCaseselementLouisiana.InnerText.Trim();
            decimal CovidCasesNumLouisiana = Convert.ToDecimal(CovidCasesLouisiana);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumLouisiana + " Where estado= " + '\u0022' + cityLouisiana + '\u0022');


            // Send get request to weather.com for Missouri
            String urlMissouri = "https://weather.com/weather/today/l/bbbd94d3bf643055b67e37889febb3d76e8ca3d91e280695660d3d793675ba43";
            var httpClientMissouri = new HttpClient();
            var htmlMissouri = httpClientMissouri.GetStringAsync(urlMissouri).Result;
            var htmlDocumentMissouri = new HtmlDocument();
            htmlDocumentMissouri.LoadHtml(htmlMissouri);

            // Get the temperature for Missouri
            var HightemperatureElementMissouri = htmlDocumentMissouri.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var hightemperatureMissouri = HightemperatureElementMissouri.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + hightemperatureMissouri);

            // Get the conditions for Missouri
            var conditionElementMissouri = htmlDocumentMissouri.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsMissouri = conditionElementMissouri.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsMissouri);

            // Get the location for Missouri
            var cityElementMissouri = htmlDocumentMissouri.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityMissouri = cityElementMissouri.InnerText.Trim();
            Console.WriteLine("City: " + cityMissouri);

            // Send get request to iqair.com for Missouri
            String urlMissouriA = "https://www.iqair.com/usa/missouri/kansas-city";
            var httpClientMissouriA = new HttpClient();
            var htmlKansasCityA = httpClientMissouriA.GetStringAsync(urlMissouriA).Result;
            var htmlDocumentKansasCityA = new HtmlDocument();
            htmlDocumentKansasCityA.LoadHtml(htmlKansasCityA);

            var airQualityElementMissouri = htmlDocumentKansasCityA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityMissouri = airQualityElementMissouri.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityMissouri + " Where estado= " + '\u0022' + cityMissouri + '\u0022');

            // Send get request to worldometers.info for Missouri
            String urlMissouriCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/missouri/";
            var httpClientMissouriCo = new HttpClient();
            var htmlMissouriCo = httpClientMissouriCo.GetStringAsync(urlMissouriCo).Result;
            var htmlDocumentMissouriCo = new HtmlDocument();
            htmlDocumentMissouriCo.LoadHtml(htmlMissouriCo);

            var CovidCaseselementMissouri = htmlDocumentMissouriCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesMissouri = CovidCaseselementMissouri.InnerText.Trim();
            decimal CovidCasesNumMissouri = Convert.ToDecimal(CovidCasesMissouri);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumMissouri + " Where estado= " + '\u0022' + cityMissouri + '\u0022');


            // Send get request to weather.com for Alabama
            String urlAlabama = "https://weather.com/weather/today/l/afbf572fe13c41d86db65907b685e61e0364027ff5d4c61d82a7c6b29ea9ae74";
            var httpClientAlabama = new HttpClient();
            var htmlAlabama = httpClientAlabama.GetStringAsync(urlAlabama).Result;
            var htmlDocumentAlabama = new HtmlDocument();
            htmlDocumentAlabama.LoadHtml(htmlAlabama);

            // Get the temperature for Alabama
            var HightemperatureElementAlabama = htmlDocumentAlabama.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var hightemperatureAlabama = HightemperatureElementAlabama.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + hightemperatureAlabama);

            // Get the conditions for Alabama
            var conditionElementAlabama = htmlDocumentAlabama.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsAlabama = conditionElementAlabama.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsAlabama);

            // Get the location for Alabama
            var cityElementAlabama = htmlDocumentAlabama.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityAlabama = cityElementAlabama.InnerText.Trim();
            Console.WriteLine("City: " + cityAlabama);

            // Send get request to iqair.com for Alabama
            String urlAlabamaA = "https://www.iqair.com/usa/alabama/birmingham";
            var httpClientAlabamaA = new HttpClient();
            var htmlBirminghamA = httpClientAlabamaA.GetStringAsync(urlAlabamaA).Result;
            var htmlDocumentBirminghamA = new HtmlDocument();
            htmlDocumentBirminghamA.LoadHtml(htmlBirminghamA);

            var airQualityElementAlabama = htmlDocumentBirminghamA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityAlabama = airQualityElementAlabama.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityAlabama + " Where estado= " + '\u0022' + cityAlabama + '\u0022');

            // Send get request to worldometers.info for Alabama
            String urlAlabamaCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/alabama/";
            var httpClientAlabamaCo = new HttpClient();
            var htmlAlabamaCo = httpClientAlabamaCo.GetStringAsync(urlAlabamaCo).Result;
            var htmlDocumentAlabamaCo = new HtmlDocument();
            htmlDocumentAlabamaCo.LoadHtml(htmlAlabamaCo);

            var CovidCaseselementAlabama = htmlDocumentAlabamaCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesAlabama = CovidCaseselementAlabama.InnerText.Trim();
            decimal CovidCasesNumAlabama = Convert.ToDecimal(CovidCasesAlabama);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumAlabama + " Where estado= " + '\u0022' + cityAlabama + '\u0022');


            // Send get request to weather.com for Kentucky
            String urlKentucky = "https://weather.com/weather/today/l/52c963b5da1cc8ba157bdcefa424ccb9900be927a76889705ff7c6d8b4e7a6c6";
            var httpClientKentucky = new HttpClient();
            var htmlKentucky = httpClientKentucky.GetStringAsync(urlKentucky).Result;
            var htmlDocumentKentucky = new HtmlDocument();
            htmlDocumentKentucky.LoadHtml(htmlKentucky);

            // Get the temperature for Kentucky
            var HightemperatureElementKentucky = htmlDocumentKentucky.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var hightemperatureKentucky = HightemperatureElementKentucky.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + hightemperatureKentucky);

            // Get the conditions for Kentucky
            var conditionElementKentucky = htmlDocumentKentucky.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsKentucky = conditionElementKentucky.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsKentucky);

            // Get the location for Kentucky
            var cityElementKentucky = htmlDocumentKentucky.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityKentucky = cityElementKentucky.InnerText.Trim();
            Console.WriteLine("City: " + cityKentucky);

            // Send get request to iqair.com for Kentucky
            String urlKentuckyA = "https://www.iqair.com/usa/kentucky/louisville";
            var httpClientKentuckyA = new HttpClient();
            var htmlLouisvilleA = httpClientKentuckyA.GetStringAsync(urlKentuckyA).Result;
            var htmlDocumentLouisvilleA = new HtmlDocument();
            htmlDocumentLouisvilleA.LoadHtml(htmlLouisvilleA);

            var airQualityElementKentucky = htmlDocumentLouisvilleA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityKentucky = airQualityElementKentucky.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityKentucky + " Where estado= " + '\u0022' + cityKentucky + '\u0022');

            // Send get request to worldometers.info for Kentucky
            String urlKentuckyCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/kentucky/";
            var httpClientKentuckyCo = new HttpClient();
            var htmlKentuckyCo = httpClientKentuckyCo.GetStringAsync(urlKentuckyCo).Result;
            var htmlDocumentKentuckyCo = new HtmlDocument();
            htmlDocumentKentuckyCo.LoadHtml(htmlKentuckyCo);

            var CovidCaseselementKentucky = htmlDocumentKentuckyCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesKentucky = CovidCaseselementKentucky.InnerText.Trim();
            decimal CovidCasesNumKentucky = Convert.ToDecimal(CovidCasesKentucky);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumKentucky + " Where estado= " + '\u0022' + cityKentucky + '\u0022');


            // Send get request to weather.com for Maryland
            String urlMaryland = "https://weather.com/weather/today/l/b9f68830e04a4b31ef75d363676088c2535e168516879561fa20fd8759edb5c0";
            var httpClientMaryland = new HttpClient();
            var htmlMaryland = httpClientMaryland.GetStringAsync(urlMaryland).Result;
            var htmlDocumentMaryland = new HtmlDocument();
            htmlDocumentMaryland.LoadHtml(htmlMaryland);

            // Get the temperature for Maryland
            var HightemperatureElementMaryland = htmlDocumentMaryland.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var hightemperatureMaryland = HightemperatureElementMaryland.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + hightemperatureMaryland);

            // Get the conditions for Maryland
            var conditionElementMaryland = htmlDocumentMaryland.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsMaryland = conditionElementMaryland.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsMaryland);

            // Get the location for Maryland
            var cityElementMaryland = htmlDocumentMaryland.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityMaryland = cityElementMaryland.InnerText.Trim();
            Console.WriteLine("City: " + cityMaryland);

            // Send get request to iqair.com for Maryland
            String urlMarylandA = "https://www.iqair.com/usa/maryland/baltimore";
            var httpClientMarylandA = new HttpClient();
            var htmlBaltimoreA = httpClientMarylandA.GetStringAsync(urlMarylandA).Result;
            var htmlDocumentBaltimoreA = new HtmlDocument();
            htmlDocumentBaltimoreA.LoadHtml(htmlBaltimoreA);

            var airQualityElementMaryland = htmlDocumentBaltimoreA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityMaryland = airQualityElementMaryland.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityMaryland + " Where estado= " + '\u0022' + cityMaryland + '\u0022');

            // Send get request to worldometers.info for Maryland
            String urlMarylandCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/maryland/";
            var httpClientMarylandCo = new HttpClient();
            var htmlMarylandCo = httpClientMarylandCo.GetStringAsync(urlMarylandCo).Result;
            var htmlDocumentMarylandCo = new HtmlDocument();
            htmlDocumentMarylandCo.LoadHtml(htmlMarylandCo);

            var CovidCaseselementMaryland = htmlDocumentMarylandCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesMaryland = CovidCaseselementMaryland.InnerText.Trim();
            decimal CovidCasesNumMaryland = Convert.ToDecimal(CovidCasesMaryland);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumMaryland + " Where estado= " + '\u0022' + cityMaryland + '\u0022');


            // Send get request to weather.com for Oklahoma
            String urlOklahoma = "https://weather.com/weather/today/l/2f1fc1a42db8ce5905c09e81e950aa8490a03ccf3fc0531201aa36121203afbf";
            var httpClientOklahoma = new HttpClient();
            var htmlOklahoma = httpClientOklahoma.GetStringAsync(urlOklahoma).Result;
            var htmlDocumentOklahoma = new HtmlDocument();
            htmlDocumentOklahoma.LoadHtml(htmlOklahoma);

            // Get the temperature for Oklahoma
            var HightemperatureElementOklahoma = htmlDocumentOklahoma.DocumentNode.SelectSingleNode("//span[@data-testid='TemperatureValue']");
            var hightemperatureOklahoma = HightemperatureElementOklahoma.InnerText.Trim();
            Console.WriteLine("Highest Temperature expected: " + hightemperatureOklahoma);

            // Get the conditions for Oklahoma
            var conditionElementOklahoma = htmlDocumentOklahoma.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditionsOklahoma = conditionElementOklahoma.InnerText.Trim();
            Console.WriteLine("Conditions: " + conditionsOklahoma);

            // Get the location for Oklahoma
            var cityElementOklahoma = htmlDocumentOklahoma.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var cityOklahoma = cityElementOklahoma.InnerText.Trim();
            Console.WriteLine("City: " + cityOklahoma);

            // Send get request to iqair.com for Oklahoma
            String urlOklahomaA = "https://www.iqair.com/usa/oklahoma/oklahoma-city";
            var httpClientOklahomaA = new HttpClient();
            var htmlOklahomaCityA = httpClientOklahomaA.GetStringAsync(urlOklahomaA).Result;
            var htmlDocumentOklahomaCityA = new HtmlDocument();
            htmlDocumentOklahomaCityA.LoadHtml(htmlOklahomaCityA);

            var airQualityElementOklahoma = htmlDocumentOklahomaCityA.DocumentNode.SelectSingleNode("//span[@class='aqi-status__text']");
            var airQualityOklahoma = airQualityElementOklahoma.InnerText.Trim();
            Console.WriteLine("UPDATE air set cantidad = " + airQualityOklahoma + " Where estado= " + '\u0022' + cityOklahoma + '\u0022');

            // Send get request to worldometers.info for Oklahoma
            String urlOklahomaCo = "https://usafacts.org/visualizations/coronavirus-covid-19-spread-map/state/oklahoma/";
            var httpClientOklahomaCo = new HttpClient();
            var htmlOklahomaCo = httpClientOklahomaCo.GetStringAsync(urlOklahomaCo).Result;
            var htmlDocumentOklahomaCo = new HtmlDocument();
            htmlDocumentOklahomaCo.LoadHtml(htmlOklahomaCo);

            var CovidCaseselementOklahoma = htmlDocumentOklahomaCo.DocumentNode.SelectSingleNode("//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeSmall']");
            var CovidCasesOklahoma = CovidCaseselementOklahoma.InnerText.Trim();
            decimal CovidCasesNumOklahoma = Convert.ToDecimal(CovidCasesOklahoma);
            Console.WriteLine("UPDATE covid set cantidad = " + CovidCasesNumOklahoma + " Where estado= " + '\u0022' + cityOklahoma + '\u0022');
            List<decimal> covidCasesSum = new List<decimal>();
            covidCasesSum.Add(CovidCasesNumIllinois);
            covidCasesSum.Add(CovidCasesNumCalifornia);
            covidCasesSum.Add(CovidCasesNumMissouri);
            covidCasesSum.Add(CovidCasesNumAlabama);
            covidCasesSum.Add(CovidCasesNumOklahoma);
            covidCasesSum.Add(CovidCasesNumMaryland);
            covidCasesSum.Add(CovidCasesNumArizona);
            covidCasesSum.Add(CovidCasesNumColorado);
            covidCasesSum.Add(CovidCasesNumFlorida);
            covidCasesSum.Add(CovidCasesNumGeorgia);
            covidCasesSum.Add(CovidCasesNumIndiana);
            covidCasesSum.Add(CovidCasesNumKentucky);
            covidCasesSum.Add(CovidCasesNumLouisiana);
            covidCasesSum.Add(CovidCasesNumMassachusetts);
            covidCasesSum.Add(CovidCasesNumMichigan);
            covidCasesSum.Add(CovidCasesNumMinnesota);
            covidCasesSum.Add(CovidCasesNumMissouri);
            covidCasesSum.Add(CovidCasesNumNewJersey);
            covidCasesSum.Add(CovidCasesNumNorthCarolina);
            covidCasesSum.Add(CovidCasesNumTennessee);
            covidCasesSum.Add(CovidCasesNumTexas);
            covidCasesSum.Add(CovidCasesNumVirginia);
            covidCasesSum.Add(CovidCasesNumWashington);
            covidCasesSum.Add(CovidCasesNumWisconsin);

            for (int i = 0; i < covidCasesSum.Count; i++)
            {
                Console.WriteLine(covidCasesSum[i]);
            }
            Console.ReadKey();
















        }
    }
}