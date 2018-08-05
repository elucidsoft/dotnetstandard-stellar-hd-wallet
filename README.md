# dotnetstandard-stellar-hd-wallet
.NET Standard 2.0 Key derivation for Stellar (SEP-0005)

## Usage

```csharp
 var mnemonic = StellarHDWallet.GenerateMnemonic(dotnetstandard_bip39.BIP39Wordlist.English);
var wallet = StellarHDWallet.FromMnemonic(mnemonic);

