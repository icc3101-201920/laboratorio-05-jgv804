using Laboratorio_4_OOP_201902.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4_OOP_201902
{
    public class Deck
    {

        private List<Card> cards;

        public Deck()
        {
        
        }

        public List<Card> Cards { get => cards; set => cards = value; }

        public void AddCard(Card card)
        {
            //Agregue la carta card a la lista cards
            this.Cards.Add(card);
        }
        public void DestroyCard(int cardId)
        {
            /* Debe eliminar la carta segun el parametro cardId. Para esto
                1- Utilice el metodo RemoveAt de las listas para eliminar la carta en cards
            */
            this.Cards.RemoveAt(cardID);
        }
        public void Shuffle()
        {
            //Reordenar el mazo de manera aleatoria (barajar).
            int rand = new Random();
            List<Card> deku = new List<Card>();
            while (this.Cards.Length>0)
            {
                
                int rando = rand.Next(this.Cards.Length);
                if(this.Cards[rando].GetType().Name == nameof(CombatCard))
                {
                   CombatCard aux = new CombatCard(this.Cards[rando].Name, this.Cards[rando].Type, this.Cards[rando].Effect,this.Cards[rando].Attackpoints, this.Cards[rando].Hero);
                   deku.Add(aux);
                   this.DestroyCard(rando);
                }
                else
                {
                    SpecialCard aux = new SpecialCard(this.Cards[rando].Name, this.Cards[rando].Type, this.Cards[rando].Effect);
                    aux.BuffType = this.Cards[rando].BuffType;
                    deku.Add(aux);
                    this.DestroyCard(rando);
                }
                
                

            }
            this.Cards = deku;
        }
    }
}
