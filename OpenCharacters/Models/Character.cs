using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenCharacters.Models
{
    public class Character
    {
        string CharacterName { get; set; }
        Dictionary<string, string> Notes { get; set; }
        
    }
}