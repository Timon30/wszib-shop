using System;

namespace Shop.Web.Models
{
    internal class RequicedAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}