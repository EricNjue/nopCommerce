using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Plugin.Payments.Mpesa.Models;
using Nop.Services.Configuration;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;

namespace Nop.Plugin.Payments.Mpesa.Controllers;

[Area(AreaNames.Admin)]
[AutoValidateAntiforgeryToken]
[AuthorizeAdmin]
public class PaymentMpesaConfigurationControlller : BasePluginController
{
    private readonly ISettingService _settingService;
    private readonly IStoreContext _storeContext;


    public PaymentMpesaConfigurationControlller(ISettingService settingService, IStoreContext storeContext)
    {
        _settingService = settingService;
        _storeContext = storeContext;
    }

    // GET
    public async Task<IActionResult> Configure()
    {
        var storeId = await _storeContext.GetActiveStoreScopeConfigurationAsync();
        var settings = await _settingService.LoadSettingAsync<MpesaSettings>(storeId);

        if (storeId > 0)
        {
            settings.ConsumerKey = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.ConsumerKey)}", storeId: storeId);
            settings.ConsumerSecret = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.ConsumerSecret)}", storeId: storeId);
            settings.CallbackUrl = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.CallbackUrl)}", storeId: storeId);
            settings.ValidationUrl = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.ValidationUrl)}", storeId: storeId);
            settings.ConfirmationUrl = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.ConfirmationUrl)}", storeId: storeId);
            settings.PassKey = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.PassKey)}", storeId: storeId);
            settings.MerchantId = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.MerchantId)}", storeId: storeId);
            settings.CallBackMethod = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.CallBackMethod)}", storeId: storeId);
            settings.PayBillShortCode = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.PayBillShortCode)}", storeId: storeId);
            settings.StkBusinessShortCode = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.StkBusinessShortCode)}", storeId: storeId);
            settings.PartyA = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.PartyA)}", storeId: storeId);
            settings.RegisterUrlEndpoint = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.RegisterUrlEndpoint)}", storeId: storeId);
            settings.CertificateContent = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.CertificateContent)}", storeId: storeId);
            settings.DarajaBaseUrl = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.DarajaBaseUrl)}", storeId: storeId);
            settings.OauthTokenEndpoint = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.OauthTokenEndpoint)}", storeId: storeId);
            settings.StkExpressEndpoint = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.StkExpressEndpoint)}", storeId: storeId);
            settings.QueryStkExpressEndpoint = await _settingService
                .GetSettingByKeyAsync<string>(
                    $"{nameof(MpesaSettings)}.{nameof(MpesaSettings.QueryStkExpressEndpoint)}", storeId: storeId);
        }

        var model = new ConfigurationModel
        {
            ConsumerKey = settings.ConsumerKey,
            ConsumerSecret = settings.ConsumerSecret,
            CallbackUrl = settings.CallbackUrl,
            ValidationUrl = settings.ValidationUrl,
            ConfirmationUrl = settings.ConfirmationUrl,
            PassKey = settings.PassKey,
            MerchantId = settings.MerchantId,
            CallBackMethod = settings.CallBackMethod,
            PayBillShortCode = settings.PayBillShortCode,
            StkBusinessShortCode = settings.StkBusinessShortCode,
            PartyA = settings.PartyA,
            RegisterUrlEndpoint = settings.RegisterUrlEndpoint,
            CertificateContent = settings.CertificateContent,
            StoreId = storeId,
            DarajaBaseUrl = settings.DarajaBaseUrl,
            OauthTokenEndpoint = settings.OauthTokenEndpoint,
            StkExpressEndpoint = settings.StkExpressEndpoint,
            QueryStkExpressEndpoint = settings.QueryStkExpressEndpoint
        };

        return View("~/Plugins/Payments.Mpesa/Views/Configure.cshtml", model);
    }
}