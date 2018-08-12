using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MTG_Card_Scanner
{
    class MagicDB_Parse_xml
    {
        /// <summary>
        /// The raw xml file
        /// </summary>
        private XmlDocument xmlDatabase;

        /// <summary>
        /// The card list.
        /// </summary>
        private List<Card> cardList;
        
        /// <summary>
        /// No arg constructor
        /// </summary>
        public MagicDB_Parse_xml()
        {
            xmlDatabase = new XmlDocument();
            cardList = new List<Card>();
        }

        /// <summary>
        /// Loads the card database from the xml file
        /// </summary>
        /// <returns>A List<Card> of the cards loaded.</Card></returns>
        public List<Card> LoadDB()
        {
            xmlDatabase.Load("../../Resources/Database/MagicTG_DB_Main.xml");
            XmlNodeList cards = xmlDatabase.GetElementsByTagName("card");
            for (int i = 0; i < cards.Count; i++)
            {
                XmlNode currentCard = cards[i];
                Card newCard = new Card(currentCard["name"].InnerText, currentCard["set"].InnerText, currentCard["number"].InnerText);
                cardList.Add(newCard);
            }
            Debug.WriteLine("Loaded Cards Successfully");
            return cardList;

            
        }

    }
}
