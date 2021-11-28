namespace ExchangeRateApi.Models
{
    public class HistoricalRateResponse
    {
        public Motd motd { get; set; }
        public bool success { get; set; }
        public bool historical { get; set; }
        public string _base { get; set; }
        public string date { get; set; }
        public Rates rates { get; set; }
    }

    public class Motd
    {
        public string msg { get; set; }
        public string url { get; set; }
    }

    public class Rates
    {
        public decimal USD { get; set; }
        public decimal JPY { get; set; }
        public decimal BGN { get; set; }
        public decimal CZK { get; set; }
        public decimal DKK { get; set; }
        public decimal GBP { get; set; }
        public decimal HUF { get; set; }
        public decimal PLN { get; set; }
        public decimal RON { get; set; }
        public decimal SEK { get; set; }
        public decimal CHF { get; set; }
        public decimal ISK { get; set; }
        public decimal NOK { get; set; }
        public decimal HRK { get; set; }
        public decimal RUB { get; set; }
        public decimal TRY { get; set; }
        public decimal AUD { get; set; }
        public decimal BRL { get; set; }
        public decimal CAD { get; set; }
        public decimal CNY { get; set; }
        public decimal HKD { get; set; }
        public decimal IDR { get; set; }
        public decimal ILS { get; set; }
        public decimal INR { get; set; }
        public decimal KRW { get; set; }
        public decimal MXN { get; set; }
        public decimal MYR { get; set; }
        public decimal NZD { get; set; }
        public decimal PHP { get; set; }
        public decimal SGD { get; set; }
        public decimal THB { get; set; }
        public decimal ZAR { get; set; }
        public decimal EUR { get; set; }
        public decimal AED { get; set; }
        public decimal AFN { get; set; }
        public decimal ALL { get; set; }
        public decimal ARS { get; set; }
        public decimal BAM { get; set; }
        public decimal BBD { get; set; }
        public decimal BDT { get; set; }
        public decimal BHD { get; set; }
        public decimal BIF { get; set; }
        public decimal BMD { get; set; }
        public decimal BND { get; set; }
        public decimal BOB { get; set; }
        public decimal BSD { get; set; }
        public decimal BWP { get; set; }
        public decimal BZD { get; set; }
        public decimal CLP { get; set; }
        public decimal COP { get; set; }
        public decimal CRC { get; set; }
        public decimal CUP { get; set; }
        public decimal CVE { get; set; }
        public decimal DJF { get; set; }
        public decimal DOP { get; set; }
        public decimal DZD { get; set; }
        public decimal EGP { get; set; }
        public decimal ETB { get; set; }
        public decimal FJD { get; set; }
        public decimal GHS { get; set; }
        public decimal GNF { get; set; }
        public decimal GTQ { get; set; }
        public decimal HNL { get; set; }
        public decimal HTG { get; set; }
        public decimal IQD { get; set; }
        public decimal JMD { get; set; }
        public decimal JOD { get; set; }
        public decimal KES { get; set; }
        public decimal KHR { get; set; }
        public decimal KWD { get; set; }
        public decimal KYD { get; set; }
        public decimal KZT { get; set; }
        public decimal LAK { get; set; }
        public decimal LBP { get; set; }
        public decimal LKR { get; set; }
        public decimal LSL { get; set; }
        public decimal LYD { get; set; }
        public decimal MAD { get; set; }
        public decimal MDL { get; set; }
        public decimal MGA { get; set; }
        public decimal MKD { get; set; }
        public decimal MMK { get; set; }
        public decimal MOP { get; set; }
        public decimal MUR { get; set; }
        public decimal MVR { get; set; }
        public decimal MWK { get; set; }
        public decimal NAD { get; set; }
        public decimal NGN { get; set; }
        public decimal NIO { get; set; }
        public decimal NPR { get; set; }
        public decimal OMR { get; set; }
        public decimal PAB { get; set; }
        public decimal PEN { get; set; }
        public decimal PGK { get; set; }
        public decimal PKR { get; set; }
        public decimal PYG { get; set; }
        public decimal QAR { get; set; }
        public decimal RSD { get; set; }
        public decimal RWF { get; set; }
        public decimal SAR { get; set; }
        public decimal SCR { get; set; }
        public decimal SOS { get; set; }
        public decimal SVC { get; set; }
        public decimal SZL { get; set; }
        public decimal TND { get; set; }
        public decimal TTD { get; set; }
        public decimal TWD { get; set; }
        public decimal TZS { get; set; }
        public decimal UAH { get; set; }
        public decimal UGX { get; set; }
        public decimal UYU { get; set; }
        public decimal UZS { get; set; }
        public decimal VND { get; set; }
        public decimal XAF { get; set; }
        public decimal XOF { get; set; }
        public decimal XPF { get; set; }
        public decimal ZMW { get; set; }
    }

}
