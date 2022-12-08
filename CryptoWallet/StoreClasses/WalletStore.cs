using System;
using System.Collections.Generic;
using CryptoWallet.Wallets;

namespace CryptoWallet
{
    public class WalletStore
    {
        public List<Wallet> ListOfWallets = new List<Wallet>();

        public void Add(Wallet wallet)
        {
            ListOfWallets.Add(wallet);
        }

        public void Print()
        {
            foreach (var wallet in ListOfWallets)
            {
                Console.WriteLine(wallet.Adress);
            }
        }

        public Wallet ContainsAdress(string adress)
        {
            foreach (var wallet in ListOfWallets)
            {
                if (wallet.Adress.Equals(adress))
                    return wallet;
            }

            return null;
        }
    }
}