using System;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.Payments.Mpesa.Models;

public class ConfigurationModel
{
    public string ConsumerKey { get; set; }
    public string ConsumerSecret { get; set; }
    public string CallbackUrl { get; set; }
    public string ValidationUrl { get; set; }
    public string ConfirmationUrl { get; set; }
    public string PassKey { get; set; }
    public string MerchantId { get; set; }
    public string CallBackMethod { get; set; }
    public string PayBillShortCode { get; set; }
    public string StkBusinessShortCode { get; set; }
    public string PartyA { get; set; }
    public string RegisterUrlEndpoint { get; set; }
    public string CertificateContent { get; set; }
    public string DarajaBaseUrl { get; set; }
    public string OauthTokenEndpoint { get; set; }
    public string StkExpressEndpoint { get; set; }
    public string QueryStkExpressEndpoint { get; set; }
    public int StoreId { get; set; }
}