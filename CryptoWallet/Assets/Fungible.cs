using System;

namespace CryptoWallet.Assets
{
    public class Fungible : Assets
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public decimal ValueInUSD { get; set; }

        public Fungible(string name, string label, decimal value) : base()
        {
            Name = name;
            Label = label;
            ValueInUSD = value;
            IsFungible = true;
        }
    }
}