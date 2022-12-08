
using System;

namespace CryptoWallet.Assets
{
    public class NonFungible : Assets
    {
        public string Name;
        public decimal Value;
        public Guid ValueAdress;
        public NonFungible() : base(){}
        
    }
}