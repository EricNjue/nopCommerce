using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Nop.Core.Domain.Orders;
using Nop.Services.Payments;
using Nop.Services.Plugins;

namespace Nop.Plugin.Payments.Mpesa;

public class MpesaStkPayment : IPaymentMethod
{
    public Task<ProcessPaymentResult> ProcessPaymentAsync(ProcessPaymentRequest processPaymentRequest)
    {
        throw new NotImplementedException();
    }

    public Task PostProcessPaymentAsync(PostProcessPaymentRequest postProcessPaymentRequest)
    {
        throw new NotImplementedException();
    }

    public Task<bool> HidePaymentMethodAsync(IList<ShoppingCartItem> cart)
    {
        throw new NotImplementedException();
    }

    public Task<decimal> GetAdditionalHandlingFeeAsync(IList<ShoppingCartItem> cart)
    {
        throw new NotImplementedException();
    }

    public Task<CapturePaymentResult> CaptureAsync(CapturePaymentRequest capturePaymentRequest)
    {
        throw new NotImplementedException();
    }

    public Task<RefundPaymentResult> RefundAsync(RefundPaymentRequest refundPaymentRequest)
    {
        throw new NotImplementedException();
    }

    public Task<VoidPaymentResult> VoidAsync(VoidPaymentRequest voidPaymentRequest)
    {
        throw new NotImplementedException();
    }

    public Task<ProcessPaymentResult> ProcessRecurringPaymentAsync(ProcessPaymentRequest processPaymentRequest)
    {
        throw new NotImplementedException();
    }

    public Task<CancelRecurringPaymentResult> CancelRecurringPaymentAsync(CancelRecurringPaymentRequest cancelPaymentRequest)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CanRePostProcessPaymentAsync(Order order)
    {
        throw new NotImplementedException();
    }

    public Task<IList<string>> ValidatePaymentFormAsync(IFormCollection form)
    {
        throw new NotImplementedException();
    }

    public Task<ProcessPaymentRequest> GetPaymentInfoAsync(IFormCollection form)
    {
        throw new NotImplementedException();
    }

    public Type GetPublicViewComponent()
    {
        throw new NotImplementedException();
    }

    public Task<string> GetPaymentMethodDescriptionAsync()
    {
        throw new NotImplementedException();
    }

    public bool SupportCapture { get; }
    public bool SupportPartiallyRefund { get; }
    public bool SupportRefund { get; }
    public bool SupportVoid { get; }
    public RecurringPaymentType RecurringPaymentType { get; }
    public PaymentMethodType PaymentMethodType { get; }
    public bool SkipPaymentInfo { get; }


    public string GetConfigurationPageUrl()
    {
        throw new NotImplementedException();
    }

    public PluginDescriptor PluginDescriptor { get; set; }
    public Task InstallAsync()
    {
        throw new NotImplementedException();
    }

    public Task UninstallAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(string currentVersion, string targetVersion)
    {
        throw new NotImplementedException();
    }

    public Task PreparePluginToUninstallAsync()
    {
        throw new NotImplementedException();
    }
}