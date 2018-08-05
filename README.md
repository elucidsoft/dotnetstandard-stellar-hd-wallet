# dotnetstandard-stellar-hd-wallet
.NET Standard 2.0 Key derivation for Stellar (SEP-0005)

## Usage

```csharp

var mnemonic = StellarHDWallet.GenerateMnemonic(dotnetstandard_bip39.BIP39Wordlist.English);
var wallet = StellarHDWallet.FromMnemonic(mnemonic);

var publicKey = wallet.GetPublicKey(0);
var privateKey = wallet.GetPrivateKey(0);
var keyPair = wallet.GetKeyPair(0);
var rawKey = wallet.Derive("m/44'/148'/0'");

//Wallet instance from seeds
var seedHex =  "794fc27373add3ac7676358e868a787bcbf1edfac83edcecdb34d7f1068c645dbadba563f3f3a4287d273ac4f052d2fc650ba953e7af1a016d7b91f4d273378f";

var seedHexBytes = seedHex.HexToByteArray();
var walletFromHexBytes = StellarHDWallet.FromSeed(seedHexBytes);
var keyPairFromHexBytesWallet = walletFromHexBytes.GetKeyPair(0);

var walletFromHexString = StellarHDWallet.FromSeed(seedHex);
var keyPairFromHexStringWallet = walletFromHexBytes.GetKeyPair(0);

var mnemonic21word = StellarHDWallet.GenerateMnemonic(BIP39Wordlist.English, 224); // 21 words
var mnemonic18word = StellarHDWallet.GenerateMnemonic(BIP39Wordlist.English, 160); // 18 words
var mnemonic12word = StellarHDWallet.GenerateMnemonic(BIP39Wordlist.English, 128); // 12 words
```

## Mnemonic Language
Mnemonics can be generated in any language supported by the underlying [bip39](https://github.com/elucidsoft/dotnetstandard-bip39) nuget package.

The full list of language keys are under exports 'wordlists' [here](https://github.com/elucidsoft/dotnetstandard-bip39/tree/master/dotnetstandard-bip39/wordlists).

```csharp
var chineseMnemonic = StellarHDWallet.GenerateMnemonic(BIP39Wordlist.ChineseSimplified); //Default is 256 entropy
//楚 需 巡 傑 壤 耕 把 閒 擊 燒 丘 長 原 拖 脹 節 勾 筋 貼 掃 解 羅 齡 鈉

var frenchMnemonic = StellarHDWallet.GenerateMnemonic(BIP39Wordlist.French); //Default is 256 entropy
//linéaire caprice sculpter baignade sauvage extraire destrier visqueux matière nation dénicher blague vaillant viande édifier nectar faiblir axial marqueur endosser sanglier usine essorer créature

