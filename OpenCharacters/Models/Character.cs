using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenCharacters.Models
{
    public class Character
    {
        public string CharacterName { get; set; }
        public Dictionary<string, string> Notes { get; set; }
        
        public Character(string name)
        {
            CharacterName = name;
        }
    }
}