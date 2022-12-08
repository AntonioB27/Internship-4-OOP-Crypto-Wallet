using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using CryptoWallet.Assets;
using CryptoWallet.Wallets;



namespace CryptoWallet
{
    internal class Program
    {
        private static AssetStore _assetStore = new AssetStore();
        private static Fungible _usdt = new Fungible("Tether","USDT", 1m);
        private static Fungible _bnb = new Fungible("BNB", "BNB", 287.52m);
        private static Fungible _usdc = new Fungible("USD Coin", "USDT", 1m);
        private static Fungible _xrp = new Fungible("XRP", "XRP", 0.3887m);
        private static Fungible _doge = new Fungible("Dogecoin", "DOGE", 0.09709m);
        private static Fungible _ada = new Fungible("Cardano", "ADA", 0.3118m);
        private static Fungible _matic = new Fungible("Polygon", "MATIC", 0.9099m);
        private static Fungible _polkadot = new Fungible("Polkadot", "DOT", 5.32m);
        private static Fungible _ltc = new Fungible("Litecoin", "LTC", 76.23m);
        private static Fungible _trx = new Fungible("TRON", "TRX", 0.05335m);

        
        private static bool _btcw;
        private static bool _ethw;
        private static bool _slnw;
        private static WalletStore _walletStore = new WalletStore();

        public static void Main(string[] args)
        {
            _assetStore.Add(_usdt);
            _assetStore.Add(_bnb);
            _assetStore.Add(_usdc);
            _assetStore.Add(_xrp);
            _assetStore.Add(_doge);
            _assetStore.Add(_ada);
            _assetStore.Add(_matic);
            _assetStore.Add(_polkadot);
            _assetStore.Add(_ltc);
            _assetStore.Add(_trx);


            Console.Clear();
            Console.WriteLine("Crypto-DUMP\n\n" +
                              "Welcome to your Crypto fund managing application.\n" +
                              "This app let's you manage your wallets and make transactions between them.\n" +
                              "You can also but pictures of monkeys or as Crypto dudes like to call them - NFT-s.\n" +
                              "Be sure to read our terms of service.");
            Console.Write("\nPlease enter your name:");
            var name = Console.ReadLine();

            Console.WriteLine($"Welcome {name} your Crypto journey is about to begin...");
            
            Thread.Sleep(2000);

            int userInput;
            do
            {
                Console.Clear();
                Console.WriteLine("1-Create a wallet");
                Console.WriteLine("Access wallets");
                Int32.TryParse(Console.ReadLine(), out userInput);
                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1-Bitcoin Wallet");
                        Console.WriteLine("2-Ethereum Wallet");
                        Console.WriteLine("3-Solana Wallet");
                        Console.WriteLine("4-Back to previus menu");
                        Int32.TryParse(Console.ReadLine(), out userInput);
                        switch (userInput)
                        {
                            case 1:
                                Console.Clear();
                                if(CreateBtcWallet())
                                    Console.WriteLine("Bitcoin wallet created!");
                                else
                                    Console.WriteLine("Wallet not created!");
                                Thread.Sleep(2000);
                                break;
                            case 2:
                                Console.Clear();
                                if(CreateEthWallet())
                                    Console.WriteLine("Ethereum wallet created!");
                                else
                                    Console.WriteLine("Wallet not created!");
                                Thread.Sleep(2000);
                                break;
                            case 3:
                                Console.Clear();
                                if(CreateSlnWallet())
                                    Console.WriteLine("Solana wallet created!");
                                else
                                    Console.WriteLine("Wallet not created!");
                                Thread.Sleep(2000);
                                break;
                            case 4:
                                break;
                            default:
                                Console.WriteLine("Wrong input!!");
                                break;
                        }

                        break;
                }
            } while (userInput != 0);
        }
        
        public static bool AreYouSure()
        {
            string areYouSure;
            Console.WriteLine("Are you sure? [y]-yes [n]-no");
            areYouSure = Console.ReadLine().ToLower();
            if (areYouSure == "y")
            {
                return true;
            }

            if (areYouSure == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Wrong input!!!\n" +
                                  "(default set to no)");
                return false;
            }
        }

        public static bool CreateBtcWallet()
        {
            if (AreYouSure())
            {
                if (_btcw)
                {
                    Console.WriteLine("Bitcoin wallet already exists!");
                    return false;
                }

                var bitcoinWallet = new BitcoinWallet();
                _walletStore.Add(bitcoinWallet);
                _btcw = true;
                
                return true;
            }
            else return false;
        }

        public static bool CreateEthWallet()
        {
            if (AreYouSure())
            {
                if (_ethw)
                {
                    Console.WriteLine("Ethereum wallet already exists!");
                    return false;
                }

                var ethereumWallet = new EtheriumWallet();
                _walletStore.Add(ethereumWallet);
                _ethw = true;
                
                return true;
            }
            else return false;
        }
        
        public static bool CreateSlnWallet()
        {
            if (AreYouSure())
            {
                if (_slnw)
                {
                    Console.WriteLine("Solana wallet already exists!");
                    return false;
                }

                var solanaWallet = new SolanaWallet();
                _walletStore.Add(solanaWallet);
                _slnw = true;
                
                return true;
            }
            else return false;
        }
    }
}