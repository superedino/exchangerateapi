﻿namespace ExchangeRateApi.Models
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
        public float USD { get; set; }
        public float JPY { get; set; }
        public float BGN { get; set; }
        public float CZK { get; set; }
        public float DKK { get; set; }
        public float GBP { get; set; }
        public float HUF { get; set; }
        public float PLN { get; set; }
        public float RON { get; set; }
        public float SEK { get; set; }
        public float CHF { get; set; }
        public float ISK { get; set; }
        public float NOK { get; set; }
        public float HRK { get; set; }
        public float RUB { get; set; }
        public float TRY { get; set; }
        public float AUD { get; set; }
        public float BRL { get; set; }
        public float CAD { get; set; }
        public float CNY { get; set; }
        public float HKD { get; set; }
        public int IDR { get; set; }
        public float ILS { get; set; }
        public float INR { get; set; }
        public float KRW { get; set; }
        public float MXN { get; set; }
        public float MYR { get; set; }
        public float NZD { get; set; }
        public float PHP { get; set; }
        public float SGD { get; set; }
        public float THB { get; set; }
        public float ZAR { get; set; }
        public int EUR { get; set; }
        public float AED { get; set; }
        public float AFN { get; set; }
        public float ALL { get; set; }
        public float ARS { get; set; }
        public float BAM { get; set; }
        public float BBD { get; set; }
        public float BDT { get; set; }
        public float BHD { get; set; }
        public float BIF { get; set; }
        public float BMD { get; set; }
        public float BND { get; set; }
        public float BOB { get; set; }
        public float BSD { get; set; }
        public float BWP { get; set; }
        public float BZD { get; set; }
        public float CLP { get; set; }
        public float COP { get; set; }
        public float CRC { get; set; }
        public float CUP { get; set; }
        public float CVE { get; set; }
        public float DJF { get; set; }
        public float DOP { get; set; }
        public float DZD { get; set; }
        public float EGP { get; set; }
        public float ETB { get; set; }
        public float FJD { get; set; }
        public float GHS { get; set; }
        public float GNF { get; set; }
        public float GTQ { get; set; }
        public float HNL { get; set; }
        public float HTG { get; set; }
        public float IQD { get; set; }
        public float JMD { get; set; }
        public float JOD { get; set; }
        public float KES { get; set; }
        public float KHR { get; set; }
        public float KWD { get; set; }
        public float KYD { get; set; }
        public float KZT { get; set; }
        public float LAK { get; set; }
        public int LBP { get; set; }
        public float LKR { get; set; }
        public float LSL { get; set; }
        public float LYD { get; set; }
        public float MAD { get; set; }
        public float MDL { get; set; }
        public float MGA { get; set; }
        public float MKD { get; set; }
        public float MMK { get; set; }
        public float MOP { get; set; }
        public float MUR { get; set; }
        public float MVR { get; set; }
        public float MWK { get; set; }
        public float NAD { get; set; }
        public float NGN { get; set; }
        public float NIO { get; set; }
        public float NPR { get; set; }
        public float OMR { get; set; }
        public float PAB { get; set; }
        public float PEN { get; set; }
        public float PGK { get; set; }
        public float PKR { get; set; }
        public float PYG { get; set; }
        public float QAR { get; set; }
        public float RSD { get; set; }
        public float RWF { get; set; }
        public float SAR { get; set; }
        public float SCR { get; set; }
        public float SOS { get; set; }
        public float SVC { get; set; }
        public float SZL { get; set; }
        public float TND { get; set; }
        public float TTD { get; set; }
        public float TWD { get; set; }
        public float TZS { get; set; }
        public float UAH { get; set; }
        public float UGX { get; set; }
        public float UYU { get; set; }
        public float UZS { get; set; }
        public int VND { get; set; }
        public float XAF { get; set; }
        public float XOF { get; set; }
        public float XPF { get; set; }
        public float ZMW { get; set; }
    }

}
