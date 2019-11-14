using Laboratorio_8_OOP_201920.Cards;
using Laboratorio_8_OOP_201920.Enums;
using System.Collections.Generic;

namespace Laboratorio_8_OOP_201920
{
    public static class Effect
    {
        private static Dictionary<EnumEffect, string> effectDescriptions = new Dictionary<EnumEffect, string>()
        {
            { EnumEffect.bitingFrost, "Sets the strength of all melee cards to 1 for both players" },
            { EnumEffect.impenetrableFog, "Sets the strength of all range cards to 1 for both players" },
            { EnumEffect.torrentialRain, "Sets the strength of all longRange cards to 1 for both players" },
            { EnumEffect.clearWeather, "Removes all Weather Card (Biting Frost, Impenetrable Fog and Torrential Rain) effects" },
            { EnumEffect.moraleBoost, "Adds +1 to all units in the row (excluding itself)" },
            { EnumEffect.spy, "Place on your opponent's battlefield (counts towards opponent's total) and draw 2 cards from your deck" },
            { EnumEffect.tightBond, "Place next to a card with the same name to double the strength of both cards" },
            { EnumEffect.buff, "Doubles the strength of all unit cards in that row. Limited to 1 per row" },
            { EnumEffect.none, "None" },
        };

        public static string GetEffectDescription(EnumEffect e)
        {
            return effectDescriptions[e];
        }

        public static void ApplyEffect(Card playedCard, Player activePlayer, Player opponent,Board board)
        {
            if (playedCard.CardEffect == EnumEffect.bitingFrost)
            {
                foreach (CombatCard c in activePlayer.Hand.Cards)
                {
                    if (c.Type == EnumType.melee)
                    {
                        c.AttackPoints = 1;
                    }
                }
                foreach (CombatCard c in opponent.Hand.Cards)
                {
                    if (c.Type == EnumType.melee)
                    {
                        c.AttackPoints = 1;
                    }
                }
            }
            else if (playedCard.CardEffect == EnumEffect.impenetrableFog)
            {
                foreach (CombatCard c in activePlayer.Hand.Cards)
                {
                    if (c.Type == EnumType.range)
                    {
                        c.AttackPoints = 1;
                    }
                }
                foreach (CombatCard c in opponent.Hand.Cards)
                {
                    if (c.Type == EnumType.range)
                    {
                        c.AttackPoints = 1;
                    }
                }
            }
            else if (playedCard.CardEffect == EnumEffect.torrentialRain)
            {
                foreach (CombatCard c in activePlayer.Hand.Cards)
                {
                    if (c.Type == EnumType.longRange)
                    {
                        c.AttackPoints = 1;
                    }
                }
                foreach (CombatCard c in opponent.Hand.Cards)
                {
                    if (c.Type == EnumType.longRange)
                    {
                        c.AttackPoints = 1;
                    }
                }
            }
            else if (playedCard.CardEffect == EnumEffect.clearWeather)
            {
                board.WeatherCards = null;
            }
        }

        public void OnCardPlayed(object source, PlayerEventArgs e)
        {
            
        }
    }
}
