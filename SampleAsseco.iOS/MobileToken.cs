using System;
using MobileTokenBinding;
using SampleAsseco.iOS;
using Xamarin.Forms;

[assembly:Dependency(typeof(MobileToken))]
namespace SampleAsseco.iOS
{
    public class MobileToken:IMobileToken
    {
       
        public string GetMobileTokenVersion()
        {
            string tokenVersion = TokenFacade.Version;
            return tokenVersion;

        }
    }
}
