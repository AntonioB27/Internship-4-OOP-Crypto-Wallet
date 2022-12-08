using System;

namespace CryptoWallet.Assets
{
    public class Assets
    {
        public Guid Adress { get; }
        public bool IsFungible;
        public Assets()
        {
            Adress = Guid.NewGuid();
        }
    }
}