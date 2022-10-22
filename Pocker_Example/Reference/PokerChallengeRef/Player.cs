using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerChallengeRef
{
    /// <summary>
    /// Abstract Class for the Player
    /// </summary>
    public abstract class Players
    {
        public abstract void ReceivePlayingCards(PlayingCard card);
        public abstract void Join(PokerGame pokerGameHost);
        public abstract PokerHand GetPokerHand();
        public abstract void ClearCards();
    }

    /// <summary>
    /// Poker Player
    /// </summary>
    public class PokerPlayer : Players
    {
        internal List<PlayingCard> CardsOnHand = new List<PlayingCard>();
        public string Name { get; set; }

        public PokerPlayer(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Receives poker card object from the Poker Game object
        /// </summary>
        /// <param name="card"></param>
        public override void ReceivePlayingCards(PlayingCard cards)
        {
            CardsOnHand.Add(cards);
        }

        public override void Join(PokerGame pokerGame)
        {
            pokerGame.AddPlayer(this);
        }

        /// <summary>
        /// Return Arranged/Strategized card
        /// </summary>
        /// <returns></returns>
        public override PokerHand GetPokerHand()
        {
            PokerHand _pokerHand = new PokerHand();

            _pokerHand.ArrangeCards(this);

            return _pokerHand;
        }

        /// <summary>
        /// Clear cards for the next game round
        /// </summary>
        public override void ClearCards()
        {
            CardsOnHand.Clear();
        }

    }
}
