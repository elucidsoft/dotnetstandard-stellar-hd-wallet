using System;
using dotnetstandard_bip32;
using dotnetstandard_bip39;

namespace dotnetstandard_stellar_hd_wallet
{
    public class StellarHDWallet
    {
        const int EntropyStrength = 256;

        static BIP39 Bip39 = new BIP39();
        static BIP32 Bip32 = new BIP32();
        private string _seedHex;

        public StellarHDWallet(string seedHex)
        {
            _seedHex = seedHex;
        }

        public static StellarHDWallet FromMnemonic(string mnemonic)
        {
            return new StellarHDWallet(Bip39.MnemonicToSeedHex(mnemonic, ""));
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

        public static string GenerateMnemonic(BIP39Wordlist wordlistType)
        {
            return Bip39.GenerateMnemonic(EntropyStrength, wordlistType);
        }
    }
}
