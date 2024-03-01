using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Extemsions
{
    public static class WebAddressExtensions
    {
        public static string ExtractDomain(
            this string webAddress)
        {
            var lastDotIndex = webAddress.LastIndexOf('.');
            return webAddress.Substring(lastDotIndex);
        }
    }
}
