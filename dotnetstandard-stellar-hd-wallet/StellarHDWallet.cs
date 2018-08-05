using System;
using dotnetstandard_bip32;
using dotnetstandard_bip39;

namespace dotnetstandard_stellar_hd_wallet
{
    public class StellarHDWallet
    {
        static BIP39 Bip39 = new BIP39();
        static BIP32 Bip32 = new BIP32();
        private string _seedHex;

        private StellarHDWallet(string seedHex)
        {
            _seedHex = seedHex;
        }

        public static StellarHDWallet FromMnemonic(string mnemonic)
        {
            return new StellarHDWallet(Bip39.MnemonicToSeedHex(mnemonic, ""));
        }

        public string GetPrivateKey(int index)
        {
            return GetKeyPair(index).PrivateKey;
        }

        public string Derive(string path)
        {
            var data = Bip32.DerivePath(path, _seedHex);
            return data.Key.ToStringHex();
        }

        public (string PublicKey, string PrivateKey) GetKeyPair(int index)
        {
            var keyPairBytes = GetKeyPairBytes(index);

            return (StrKey.EncodeStellarAccountId(keyPairBytes.PublicKey), StrKey.EncodeStellarSecretSeed(keyPairBytes.PrivateKey));
        }

        public static StellarHDWallet FromSeed(byte[] seed)
        {
            return new StellarHDWallet(seed.ToStringHex());
        }

        public static StellarHDWallet FromSeed(string seed)
        {
            return new StellarHDWallet(seed);
        }

        public static bool ValidateMnemonic(string mnemonic, BIP39Wordlist wordlist)
        {
            return Bip39.ValidateMnemonic(mnemonic, wordlist);
        }

        private (byte[] PublicKey, byte[] PrivateKey) GetKeyPairBytes(int index)
        {
            var privateKey = DerivePathByIndex(index);
            var publicKey = Bip32.GetPublicKey(privateKey, false);

            return (publicKey, privateKey);
        }

        public string GetPublicKey(int index)
        {
            return GetKeyPair(index).PublicKey;
        }

        private byte[] DerivePathByIndex(int index)
        {
            var derivePath = Bip32.DerivePath($"m/44'/148'/{index}'", _seedHex);

            return derivePath.Key;
        }

        public static string GenerateMnemonic(BIP39Wordlist wordlistType, int entropyStrength = 256)
        {
            return Bip39.GenerateMnemonic(entropyStrength, wordlistType);
        }
    }
}
