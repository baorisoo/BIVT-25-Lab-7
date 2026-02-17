using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charaters
{
    internal class Program
    {
        public struct Charater
        {
            private string _name;
            private string _hat_type;
            private string _clothes_type;
            private string _weapon_type;
            private string _hairstyle;
            
            public string Name => _name;
            public string HatType => _hat_type;
            public string ClothesType => _clothes_type;
            public string WeaponType => _weapon_type;
            public string Hairstyle => _hairstyle;

            public Charater(string name, string hat_type, string clothes_type, string weapon_type, string hairstyle)
            {
                _name = name;
                _hat_type = hat_type;
                _clothes_type = clothes_type;
                _weapon_type = weapon_type;
                _hairstyle = hairstyle;
            }
        }

        public struct Village
        {
            private Charater[] _charaters;
            
            public Charater[] Charaters => (_charaters == null || _charaters.Length == 0) ? null : _charaters;

            public Village()
            {
                _charaters = new Charater[]
                {
                    new Charater("Bran", "beret", "doublet", "spear", "curly"),
                    new Charater("Edric", "cap", "tunic", "bag", "short"),
                    new Charater("Liora", "none", "dress", "book", "braid"),
                    new Charater("Morwen", "hat", "apron", "none", "messy"),
                    new Charater("Torvald", "hood", "robe", "bucket", "beard"),
                    new Charater("Joren", "cap", "cloak", "none", "long"),
                    new Charater("Kael", "wreath", "vest", "dagger", "curly"),
                    new Charater("Elira", "hood", "layered dress", "none", "wavy")
                };
            }
        }
    }
}