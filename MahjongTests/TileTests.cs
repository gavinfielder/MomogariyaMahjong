using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mahjong;

namespace Mahjong.Tests
{
    [TestClass]
    public class TileCreationTests
    {
        [TestMethod]
        public void Sanman_is_manzu()
        {
            Tile tile = new Tile(Tile.Suits.Man, 3);
            Assert.AreEqual(Tile.Suits.Man, tile.Suit);
        }

        [TestMethod]
        public void Sanman_is_san()
        {
            Tile tile = new Tile(Tile.Suits.Man, 3);
            Assert.AreEqual(3, tile.Number);
        }

        [TestMethod]
        public void Ton_is_kaze()
        {
            Tile tile = new Tile(Tile.Suits.Kaze, Tile.TON);
            Assert.AreEqual(Tile.Suits.Kaze, tile.Suit);
        }

        [TestMethod]
        public void Ton_is_TonNumber()
        {
            Tile tile = new Tile(Tile.Suits.Kaze, Tile.TON);
            Assert.AreEqual(Tile.TON, tile.Number);
        }

        [TestMethod]
        public void Haku_is_Sangen()
        {
            Tile tile = new Tile(Tile.Suits.Sangen, Tile.HAKU);
            Assert.AreEqual(Tile.Suits.Sangen, tile.Suit);
        }

        [TestMethod]
        public void Haku_is_HakuNumber()
        {
            Tile tile = new Tile(Tile.Suits.Sangen, Tile.HAKU);
            Assert.AreEqual(Tile.HAKU, tile.Number);
        }

        [TestMethod]
        public void Above_9_is_invalid_man()
        {
            Tile tile = new Tile(Tile.Suits.Man, 10);
            Assert.IsTrue(tile == Tile.Invalid);
        }

    }

    [TestClass]
    public class TileClassificationTests
    {
        [TestMethod]
        public void Nipin_is_not_routou()
        {
            Tile tile = new Tile(Tile.Suits.Pin, 2);
            Assert.IsFalse(tile.Routou);
        }

        [TestMethod]
        public void Nipin_is_not_jihai()
        {
            Tile tile = new Tile(Tile.Suits.Pin, 2);
            Assert.IsFalse(tile.Jihai);
        }

        [TestMethod]
        public void Paapin_is_not_routou()
        {
            Tile tile = new Tile(Tile.Suits.Pin, 8);
            Assert.IsFalse(tile.Routou);
        }

        [TestMethod]
        public void Paapin_is_not_jihai()
        {
            Tile tile = new Tile(Tile.Suits.Pin, 8);
            Assert.IsFalse(tile.Jihai);
        }

        [TestMethod]
        public void Iipin_is_routou()
        {
            Tile tile = new Tile(Tile.Suits.Pin, 1);
            Assert.IsTrue(tile.Routou);
        }

        [TestMethod]
        public void Iipin_is_not_jihai()
        {
            Tile tile = new Tile(Tile.Suits.Pin, 1);
            Assert.IsFalse(tile.Jihai);
        }

        [TestMethod]
        public void Chuupin_is_routou()
        {
            Tile tile = new Tile(Tile.Suits.Pin, 9);
            Assert.IsTrue(tile.Routou);
        }

        [TestMethod]
        public void Chuupin_is_not_jihai()
        {
            Tile tile = new Tile(Tile.Suits.Pin, 9);
            Assert.IsFalse(tile.Jihai);
        }

        [TestMethod]
        public void Shaa_is_not_routou()
        {
            Tile tile = new Tile(Tile.Suits.Kaze, Tile.SHAA);
            Assert.IsFalse(tile.Routou);
        }

        [TestMethod]
        public void Shaa_is_jihai()
        {
            Tile tile = new Tile(Tile.Suits.Kaze, Tile.SHAA);
            Assert.IsTrue(tile.Jihai);
        }

        [TestMethod]
        public void Pei_is_not_routou()
        {
            Tile tile = new Tile(Tile.Suits.Kaze, Tile.PEI);
            Assert.IsFalse(tile.Routou);
        }

        [TestMethod]
        public void Pei_is_jihai()
        {
            Tile tile = new Tile(Tile.Suits.Kaze, Tile.PEI);
            Assert.IsTrue(tile.Jihai);
        }

        [TestMethod]
        public void Ton_is_not_routou()
        {
            Tile tile = new Tile(Tile.Suits.Kaze, Tile.TON);
            Assert.IsFalse(tile.Routou);
        }

        [TestMethod]
        public void Ton_is_jihai()
        {
            Tile tile = new Tile(Tile.Suits.Kaze, Tile.TON);
            Assert.IsTrue(tile.Jihai);
        }

        [TestMethod]
        public void Hatsu_is_not_routou()
        {
            Tile tile = new Tile(Tile.Suits.Sangen, Tile.HATSU);
            Assert.IsFalse(tile.Routou);
        }

        [TestMethod]
        public void Hatsu_is_jihai()
        {
            Tile tile = new Tile(Tile.Suits.Sangen, Tile.HATSU);
            Assert.IsTrue(tile.Jihai);
        }

        [TestMethod]
        public void Chun_is_not_routou()
        {
            Tile tile = new Tile(Tile.Suits.Sangen, Tile.CHUN);
            Assert.IsFalse(tile.Routou);
        }

        [TestMethod]
        public void Chun_is_jihai()
        {
            Tile tile = new Tile(Tile.Suits.Sangen, Tile.CHUN);
            Assert.IsTrue(tile.Jihai);
        }

        [TestMethod]
        public void Uuman_is_not_routou()
        {
            Tile tile = new Tile(Tile.Suits.Man, 5);
            Assert.IsFalse(tile.Routou);
        }

        [TestMethod]
        public void Uuman_is_not_jihai()
        {
            Tile tile = new Tile(Tile.Suits.Man, 5);
            Assert.IsFalse(tile.Jihai);
        }

        [TestMethod]
        public void Chuusou_is_routou()
        {
            Tile tile = new Tile(Tile.Suits.Sou, 9);
            Assert.IsTrue(tile.Routou);
        }

        [TestMethod]
        public void Chuusou_is_not_jihai()
        {
            Tile tile = new Tile(Tile.Suits.Sou, 9);
            Assert.IsFalse(tile.Jihai);
        }

    }

    [TestClass]
    public class TileComparisonTests
    {
        [TestMethod]
        public void Uuman_Uupin_notequal()
        {
            Tile t1 = new Tile(Tile.Suits.Man, 5);
            Tile t2 = new Tile(Tile.Suits.Pin, 5);
            Assert.IsFalse(t1 == t2);
        }

        [TestMethod]
        public void Uuman_Ryuuman_notequal()
        {
            Tile t1 = new Tile(Tile.Suits.Man, 5);
            Tile t2 = new Tile(Tile.Suits.Man, 6);
            Assert.IsFalse(t1 == t2);
        }

        [TestMethod]
        public void Uuman_Uuman_equal()
        {
            Tile t1 = new Tile(Tile.Suits.Man, 5);
            Tile t2 = new Tile(Tile.Suits.Man, 5);
            Assert.IsTrue(t1 == t2);
        }

        [TestMethod]
        public void Ton_Nan_notequal()
        {
            Tile t1 = new Tile(Tile.Suits.Kaze, Tile.TON);
            Tile t2 = new Tile(Tile.Suits.Kaze, Tile.NAN);
            Assert.IsFalse(t1 == t2);
        }

        [TestMethod]
        public void Ton_Ton_equal()
        {
            Tile t1 = new Tile(Tile.Suits.Kaze, Tile.TON);
            Tile t2 = new Tile(Tile.Suits.Kaze, Tile.TON);
            Assert.IsTrue(t1 == t2);
        }

        [TestMethod]
        public void Ton_Chun_notequal()
        {
            Tile t1 = new Tile(Tile.Suits.Kaze, Tile.TON);
            Tile t2 = new Tile(Tile.Suits.Sangen, Tile.CHUN);
            Assert.IsFalse(t1 == t2);
        }

        [TestMethod]
        public void Chun_Chun_equal()
        {
            Tile t1 = new Tile(Tile.Suits.Sangen, Tile.CHUN);
            Tile t2 = new Tile(Tile.Suits.Sangen, Tile.CHUN);
            Assert.IsTrue(t1 == t2);
        }

        [TestMethod]
        public void Uuman_Uupin_notequal_negativelogic()
        {
            Tile t1 = new Tile(Tile.Suits.Man, 5);
            Tile t2 = new Tile(Tile.Suits.Pin, 5);
            Assert.IsTrue(t1 != t2);
        }

        [TestMethod]
        public void Uuman_Ryuuman_notequal_negativelogic()
        {
            Tile t1 = new Tile(Tile.Suits.Man, 5);
            Tile t2 = new Tile(Tile.Suits.Man, 6);
            Assert.IsTrue(t1 != t2);
        }

        [TestMethod]
        public void Uuman_Uuman_equal_negativelogic()
        {
            Tile t1 = new Tile(Tile.Suits.Man, 5);
            Tile t2 = new Tile(Tile.Suits.Man, 5);
            Assert.IsFalse(t1 != t2);
        }
    }

    [TestClass]
    public class TileDoraTests
    {
        [TestMethod]
        public void Can_set_dora()
        {
            Tile tile = new Tile(Tile.Suits.Man, 7);
            tile.Dora = true;
            Assert.IsTrue(tile.Dora);
        }

        [TestMethod]
        public void Can_construct_as_dora()
        {
            Tile tile = new Tile(Tile.Suits.Man, 7, true);
            Assert.IsTrue(tile.Dora);
        }

        [TestMethod]
        public void Cannot_remove_dora()
        {
            Tile tile = new Tile(Tile.Suits.Man, 7, true);
            tile.Dora = false;
            Assert.IsTrue(tile.Dora);
        }

        [TestMethod]
        public void Get_dora_simple()
        {
            Tile tile = new Tile(Tile.Suits.Man, 4);
            Assert.AreEqual(new Tile(Tile.Suits.Man, 5), tile.GetDoraFromIndicator());
        }

        [TestMethod]
        public void Get_dora_wrap()
        {
            Tile tile = new Tile(Tile.Suits.Man, 9);
            Assert.AreEqual(new Tile(Tile.Suits.Man, 1), tile.GetDoraFromIndicator());
        }

        [TestMethod]
        public void Get_dora_ton()
        {
            Tile tile = new Tile(Tile.Suits.Kaze, Tile.TON);
            Assert.AreEqual(new Tile(Tile.Suits.Kaze, Tile.NAN), tile.GetDoraFromIndicator());
        }

        [TestMethod]
        public void Get_dora_nan()
        {
            Tile tile = new Tile(Tile.Suits.Kaze, Tile.NAN);
            Assert.AreEqual(new Tile(Tile.Suits.Kaze, Tile.SHAA), tile.GetDoraFromIndicator());
        }

        [TestMethod]
        public void Get_dora_shaa()
        {
            Tile tile = new Tile(Tile.Suits.Kaze, Tile.SHAA);
            Assert.AreEqual(new Tile(Tile.Suits.Kaze, Tile.PEI), tile.GetDoraFromIndicator());
        }

        [TestMethod]
        public void Get_dora_pei()
        {
            Tile tile = new Tile(Tile.Suits.Kaze, Tile.PEI);
            Assert.AreEqual(new Tile(Tile.Suits.Kaze, Tile.TON), tile.GetDoraFromIndicator());
        }

        [TestMethod]
        public void Get_dora_chun()
        {
            Tile tile = new Tile(Tile.Suits.Sangen, Tile.CHUN);
            Assert.AreEqual(new Tile(Tile.Suits.Sangen, Tile.HAKU), tile.GetDoraFromIndicator());
        }

        [TestMethod]
        public void Get_dora_haku()
        {
            Tile tile = new Tile(Tile.Suits.Sangen, Tile.HAKU);
            Assert.AreEqual(new Tile(Tile.Suits.Sangen, Tile.HATSU), tile.GetDoraFromIndicator());
        }

        [TestMethod]
        public void Get_dora_hatsu()
        {
            Tile tile = new Tile(Tile.Suits.Sangen, Tile.HATSU);
            Assert.AreEqual(new Tile(Tile.Suits.Sangen, Tile.CHUN), tile.GetDoraFromIndicator());
        }
    }

}
