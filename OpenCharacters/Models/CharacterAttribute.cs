using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenCharacters.Models
{
    public interface Attribute<T>
    {
        string DisplayName { get; set; }
        T AttributeValue { get; set; }
    }

    public class CharacterAttribute
    {
        public string DisplayName { get; set; }

    }
    //Not sure if these are necessary
    public class StringAttribute: Attribute<string>
    {
        public string DisplayName { get; set; }
        public string AttributeValue { get; set; }
    }

    public class IntAttribute : Attribute<int>
    {
        public string DisplayName { get; set; }
        public int AttributeValue { get; set; }
    }
}