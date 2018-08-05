using dotnetstandard_bip32;
using dotnetstandard_bip39;
using dotnetstandard_stellar_hd_wallet;
using System;
using System.IO;

namespace dotnetstandard_stellar_hd_wallet_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Wallet from Mnemonic --");
            var mnemonic = StellarHDWallet.GenerateMnemonic(dotnetstandard_bip39.BIP39Wordlist.English);
            var wallet = StellarHDWallet.FromMnemonic(mnemonic);

            Console.WriteLine("Public/Private Key");
            var publicKey = wallet.GetPublicKey(0);
            var privateKey = wallet.GetPrivateKey(0);
            Console.WriteLine($"PublicKey: {publicKey},\nPrivateKey: {privateKey}");
            Console.WriteLine();

            Console.WriteLine("KeyPair");
            var keyPair = wallet.GetKeyPair(0);
            Console.WriteLine($"Pair: \n{keyPair.PublicKey},\n{keyPair.PrivateKey}");
            Console.WriteLine();

            Console.WriteLine("Key Derivation");
            var rawKey = wallet.Derive("m/44'/148'/0'");
            Console.WriteLine($"Raw Key: {rawKey}");
            Console.WriteLine();

            Console.WriteLine("-- Wallet from Seed Hex Bytes--");
            var seedHex = "794fc27373add3ac7676358e868a787bcbf1edfac83edcecdb34d7f1068c645dbadba563f3f3a4287d273ac4f052d2fc650ba953e7af1a016d7b91f4d273378f";
            var seedHexBytes = seedHex.HexToByteArray();

            var walletFromHexBytes = StellarHDWallet.FromSeed(seedHexBytes);
            var keyPairFromHexBytesWallet = walletFromHexBytes.GetKeyPair(0);
            Console.WriteLine($"Pair: \n{keyPairFromHexBytesWallet.PublicKey},\n{keyPairFromHexBytesWallet.PrivateKey}");
            Console.WriteLine();

            Console.WriteLine("-- Wallet from Seed Hex String--");
            var walletFromHexString = StellarHDWallet.FromSeed(seedHex);
            var keyPairFromHexStringWallet = walletFromHexBytes.GetKeyPair(0);
            Console.WriteLine($"Pair: \n{keyPairFromHexStringWallet.PublicKey},\n{keyPairFromHexStringWallet.PrivateKey}");
            Console.WriteLine();

            Console.WriteLine("-- Mnemonic Lengths --");
            Console.WriteLine($"21 Word:\n{StellarHDWallet.GenerateMnemonic(BIP39Wordlist.English, 224)}");
            Console.WriteLine();
            Console.WriteLine($"18 Word:\n{StellarHDWallet.GenerateMnemonic(BIP39Wordlist.English, 160)}");
            Console.WriteLine();
            Console.WriteLine($"12 Word:\n{StellarHDWallet.GenerateMnemonic(BIP39Wordlist.English, 128)}");

            var chinese = StellarHDWallet.GenerateMnemonic(BIP39Wordlist.French);

            Console.ReadLine();
        }
    }
}
