using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using CryptoWallet.Assets;

namespace CryptoWallet
{
    public class AssetStore
    {
        public List<Assets.Assets> ListOfAssets = new List<Assets.Assets>() { };

        public void Add(Assets.Assets asset)
        {
            ListOfAssets.Add(asset);
        }

        public void Print()
        {
            foreach (var asset in ListOfAssets)  
            {
                Console.WriteLine(asset.Adress);
            }
        }
    }
}