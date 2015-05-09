using System;
using DataAnnotationsExtensions.ClientValidation;

[assembly: WebActivator.PreApplicationStartMethod(typeof(SBWebsites.App_Start.RegisterClientValidationExtensions), "Start")]
 
namespace SBWebsites.App_Start {
    public static class RegisterClientValidationExtensions {
        public static void Start() {
            DataAnnotationsModelValidatorProviderExtensions.RegisterValidationExtensions();
            Boolean check = true;
        }
    }
}