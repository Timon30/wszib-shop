using System;

namespace Shop.Web.Models
{
    internal class StringLenghtAttribute : Attribute
    {
        private int v;
        private int MinimumLenght;

        public StringLenghtAttribute(int v, int MinimumLenght)
        {
            this.v = v;
            this.MinimumLenght = MinimumLenght;
        }
    }
}