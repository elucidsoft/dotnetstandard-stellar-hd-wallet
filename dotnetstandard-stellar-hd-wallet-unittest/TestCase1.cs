using dotnetstandard_stellar_hd_wallet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnetstandard_bip39;

namespace dotnetstandard_stellar_hd_wallet_unittest
{
    [TestClass]
    public class TestCase1
    {
        string mnemonic = "illness spike retreat truth genius clock brain pass fit cave bargain toe";

        [TestMethod]
        public void TestParentKey()
        {
            string expectedParentKey = "e0eec84fe165cd427cb7bc9b6cfdef0555aa1cb6f9043ff1fe986c3c8ddd22e3";

            var wallet = StellarHDWallet.FromMnemonic(mnemonic);
            var parentKey = wallet.Derive("m/44'/148'");

            Assert.AreEqual(expectedParentKey, parentKey);
        }

        [TestMethod]
        public void TestIndex0()
        {
            string expectedPublicKey = "GDRXE2BQUC3AZNPVFSCEZ76NJ3WWL25FYFK6RGZGIEKWE4SOOHSUJUJ6";
            string expectedPrivateKey = "SBGWSG6BTNCKCOB3DIFBGCVMUPQFYPA2G4O34RMTB343OYPXU5DJDVMN";

            var wallet = StellarHDWallet.FromMnemonic(mnemonic);
            var keyPair = wallet.GetKeyPair(0);

            Assert.AreEqual(expectedPublicKey, keyPair.PublicKey);
            Assert.AreEqual(expectedPrivateKey, keyPair.PrivateKey);
        }

        [TestMethod]
        public void TestIndex1()
        {
            string expectedPublicKey = "GBAW5XGWORWVFE2XTJYDTLDHXTY2Q2MO73HYCGB3XMFMQ562Q2W2GJQX";
            string expectedPrivateKey = "SCEPFFWGAG5P2VX5DHIYK3XEMZYLTYWIPWYEKXFHSK25RVMIUNJ7CTIS";

            var wallet = StellarHDWallet.FromMnemonic(mnemonic);
            var keyPair = wallet.GetKeyPair(1);

            Assert.AreEqual(expectedPublicKey, keyPair.PublicKey);
            Assert.AreEqual(expectedPrivateKey, keyPair.PrivateKey);
        }

        [TestMethod]
        public void TestIndex2()
        {
            string expectedPublicKey = "GAY5PRAHJ2HIYBYCLZXTHID6SPVELOOYH2LBPH3LD4RUMXUW3DOYTLXW";
            string expectedPrivateKey = "SDAILLEZCSA67DUEP3XUPZJ7NYG7KGVRM46XA7K5QWWUIGADUZCZWTJP";

            var wallet = StellarHDWallet.FromMnemonic(mnemonic);
            var keyPair = wallet.GetKeyPair(2);

            Assert.AreEqual(expectedPublicKey, keyPair.PublicKey);
            Assert.AreEqual(expectedPrivateKey, keyPair.PrivateKey);
        }

        [TestMethod]
        public void TestIndex3()
        {
            string expectedPublicKey = "GAOD5NRAEORFE34G5D4EOSKIJB6V4Z2FGPBCJNQI6MNICVITE6CSYIAE";
            string expectedPrivateKey = "SBMWLNV75BPI2VB4G27RWOMABVRTSSF7352CCYGVELZDSHCXWCYFKXIX";

            var wallet = StellarHDWallet.FromMnemonic(mnemonic);
            var keyPair = wallet.GetKeyPair(3);

            Assert.AreEqual(expectedPublicKey, keyPair.PublicKey);
            Assert.AreEqual(expectedPrivateKey, keyPair.PrivateKey);
        }

        [TestMethod]
        public void TestIndex4()
        {
            string expectedPublicKey = "GBCUXLFLSL2JE3NWLHAWXQZN6SQC6577YMAU3M3BEMWKYPFWXBSRCWV4";
            string expectedPrivateKey = "SCPCY3CEHMOP2TADSV2ERNNZBNHBGP4V32VGOORIEV6QJLXD5NMCJUXI";

            var wallet = StellarHDWallet.FromMnemonic(mnemonic);
            var keyPair = wallet.GetKeyPair(4);

            Assert.AreEqual(expectedPublicKey, keyPair.PublicKey);
            Assert.AreEqual(expectedPrivateKey, keyPair.PrivateKey);
        }

        [TestMethod]
        public void TestIndex5()
        {
            string expectedPublicKey = "GBRQY5JFN5UBG5PGOSUOL4M6D7VRMAYU6WW2ZWXBMCKB7GPT3YCBU2XZ";
            string expectedPrivateKey = "SCK27SFHI3WUDOEMJREV7ZJQG34SCBR6YWCE6OLEXUS2VVYTSNGCRS6X";

            var wallet = StellarHDWallet.FromMnemonic(mnemonic);
            var keyPair = wallet.GetKeyPair(5);

            Assert.AreEqual(expectedPublicKey, keyPair.PublicKey);
            Assert.AreEqual(expectedPrivateKey, keyPair.PrivateKey);
        }

        [TestMethod]
        public void TestIndex6()
        {
            string expectedPublicKey = "GBY27SJVFEWR3DUACNBSMJB6T4ZPR4C7ZXSTHT6GMZUDL23LAM5S2PQX";
            string expectedPrivateKey = "SDJ4WDPOQAJYR3YIAJOJP3E6E4BMRB7VZ4QAEGCP7EYVDW6NQD3LRJMZ";

            var wallet = StellarHDWallet.FromMnemonic(mnemonic);
            var keyPair = wallet.GetKeyPair(6);

            Assert.AreEqual(expectedPublicKey, keyPair.PublicKey);
            Assert.AreEqual(expectedPrivateKey, keyPair.PrivateKey);
        }

        [TestMethod]
        public void TestIndex7()
        {
            string expectedPublicKey = "GAY7T23Z34DWLSTEAUKVBPHHBUE4E3EMZBAQSLV6ZHS764U3TKUSNJOF";
            string expectedPrivateKey = "SA3HXJUCE2N27TBIZ5JRBLEBF3TLPQEBINP47E6BTMIWW2RJ5UKR2B3L";

            var wallet = StellarHDWallet.FromMnemonic(mnemonic);
            var keyPair = wallet.GetKeyPair(7);

            Assert.AreEqual(expectedPublicKey, keyPair.PublicKey);
            Assert.AreEqual(expectedPrivateKey, keyPair.PrivateKey);
        }

        [TestMethod]
        public void TestIndex8()
        {
            string expectedPublicKey = "GDJTCF62UUYSAFAVIXHPRBR4AUZV6NYJR75INVDXLLRZLZQ62S44443R";
            string expectedPrivateKey = "SCD5OSHUUC75MSJG44BAT3HFZL2HZMMQ5M4GPDL7KA6HJHV3FLMUJAME";

            var wallet = StellarHDWallet.FromMnemonic(mnemonic);
            var keyPair = wallet.GetKeyPair(8);

            Assert.AreEqual(expectedPublicKey, keyPair.PublicKey);
            Assert.AreEqual(expectedPrivateKey, keyPair.PrivateKey);
        }

        [TestMethod]
        public void TestIndex9()
        {
            string expectedPublicKey = "GBTVYYDIYWGUQUTKX6ZMLGSZGMTESJYJKJWAATGZGITA25ZB6T5REF44";
            string expectedPrivateKey = "SCJGVMJ66WAUHQHNLMWDFGY2E72QKSI3XGSBYV6BANDFUFE7VY4XNXXR";

            var wallet = StellarHDWallet.FromMnemonic(mnemonic);
            var keyPair = wallet.GetKeyPair(9);

            Assert.AreEqual(expectedPublicKey, keyPair.PublicKey);
            Assert.AreEqual(expectedPrivateKey, keyPair.PrivateKey);
        }
    }
}
