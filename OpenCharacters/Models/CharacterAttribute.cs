using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenCharacters.Models.enums;

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

        public int AttributeValue { get; set; }

        public Func<int> AttributeModifier { get; }

        public Func<int> IncreaseCost { get; }

        public CharacterAttribute(string displayname, AttributeType attType, int value)
        {
            DisplayName = displayname;
            AttributeValue = value;
            switch (attType)
            {
                case (AttributeType.DnD):
                    {
                        AttributeModifier = AttributeModifierDNDStyle;
                        IncreaseCost = () =>{ return 1; };
                    }
                    break;
                case (AttributeType.Simple):
                    {
                        AttributeModifier = AttributeModifierSimpleStyle;
                        IncreaseCost = () => { return 1; };
                    }
                    break;
                case (AttributeType.DF):
                    {
                        AttributeModifier = AttributeModifierSimpleStyle;
                        IncreaseCost = IncreaseCostDFStyle;
                    }
                    break;
            }
            
        }



        private int AttributeModifierDNDStyle()
        {
            return (AttributeValue / 2) - 5;
        }

        private int AttributeModifierSimpleStyle()
        {
            return AttributeValue;
        }

        private int IncreaseCostDFStyle()
        {
            return AttributeValue;
        }

    }
}