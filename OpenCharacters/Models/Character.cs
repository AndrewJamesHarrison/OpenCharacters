using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenCharacters.Models.enums;

namespace OpenCharacters.Models
{
    public class Character
    {
        public string CharacterName { get; set; }
        public Dictionary<string, string> Notes { get; set; }
        public List<CharacterAttribute> Attributes { get; }
        
        public Character(string name)
        {
            CharacterName = name;
            Attributes = new List<CharacterAttribute>();
        }

        public void AddDnDAttribute(string Displayname)
        {
            Attributes.Add(new CharacterAttribute(Displayname, AttributeType.DnD));
        }

        public void RemoveAttribute(CharacterAttribute att)
        {
            Attributes.Remove(att);
        }
    }
}