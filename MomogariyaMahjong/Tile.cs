
namespace Mahjong
{
    public class Tile
    {
        //Identifiers
        public enum Suits : byte
        {
            Man,
            Pin,
            Sou,
            Kaze,
            Sangen
        }
        public const byte TON = 2;
        public const byte NAN = 3;
        public const byte SHAA = 4;
        public const byte PEI = 5;
        public const byte CHUN = 2;
        public const byte HAKU = 3;
        public const byte HATSU = 4;

        public static readonly Tile Invalid = new Tile(Suits.Man, 0);
        

        //Fields
        public Suits Suit { get; }
        public byte Number { get; }
        public bool Routou { get; } //terminal?
        public bool Jihai { get; } //honor?
        public bool Aka { get; } //red?
        private bool _dora;
        public bool Dora
        {
            get
            {
                return _dora;
            }
            set //can never change from true to false
            {
                if (value == true) _dora = true;
            }
        }
        private bool _revealed;
        public bool Revealed
        {
            get
            {
                return _revealed;
            }
            set //can never change from true to false
            {
                if (value == true) _revealed = true;
            }
        }


        //Constructor
        public Tile(Suits suit, byte number, bool dora = false, bool aka = false)
        {
            Suit = suit;
            Number = number;
            if (Number > 9)
            {
                Number = Invalid.Number;
                Suit = Invalid.Suit;
            }
            else
            {
                if (Number == 1 || Number == 9) Routou = true;
                else Routou = false;
                if (Suit == Suits.Kaze || Suit == Suits.Sangen) Jihai = true;
                else Jihai = false;
                Dora = dora;
                Aka = aka;
            }
        }

        //Comparison operators
        public static bool operator ==(Tile t1, Tile t2)
        {
            if (t1.Suit != t2.Suit) return false;
            if (t1.Number != t2.Number) return false;
            return true;
        }
        public static bool operator !=(Tile t1, Tile t2)
        {
            return !(t1 == t2);
        }
        public override bool Equals(object other)
        {
            if (other == null) return false;
            return (this == (Tile)other);
        }
        public override int GetHashCode()
        {
            return (((byte)Suit << 1) | Number);
        }

        //Returns the dora if this tile is the indicator
        public Tile GetDoraFromIndicator()
        {
            byte number = (byte)(Number + 1);
            if (number == 10) number = 1;
            if (Suit == Suits.Kaze && Number == PEI) number = TON;
            if (Suit == Suits.Sangen && Number == HATSU) number = CHUN;
            return new Tile(Suit, number, true);            
        }

        //For ToString()
        private static string[] kazeStr = new string[4]
        {
            "Ton (east wind)",
            "Nan (south wind)",
            "Shaa (west wind)",
            "Pei (north wind)"
        };
        //For ToString()
        private static string[] sangenStr = new string[3]
        {
            "Chun (red dragon)",
            "Haku (white dragon)",
            "Hatsu (green dragon)"
        };
        //For ToString()
        private static string[] numberStr = new string[9]
        {
            "Ii",
            "Ni",
            "San",
            "Suu",
            "Uu",
            "Ryuu",
            "Chii",
            "Paa",
            "Chuu"
        };

        //Returns the representation of the tile as a string
        public override string ToString()
        {
            if (Number == 0) return "Invalid";
            string r = "";
            if (Suit == Suits.Kaze)
            {
                r = kazeStr[Number - 2];
            }
            else if (Suit == Suits.Sangen)
            {
                r = sangenStr[Number - 2];
            }
            else
            {
                r = numberStr[Number - 1];
                if (Suit == Suits.Man)
                    r += "man (" + Number + "-man)";
                else if (Suit == Suits.Pin)
                    r += "pin (" + Number + "-pin)";
                else if (Suit == Suits.Sou)
                    r += "sou (" + Number + "-sou)";
            }
            return r;
        }

    }
}
