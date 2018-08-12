using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static MTG_Card_Scanner.CodeContract;

namespace MTG_Card_Scanner
{
    /// <summary>
    /// Class related to parsing the xml MTG card databse.
    /// 
    /// Author: Branden Brown
    /// </summary>
    public class MagicDB_Parse_xml
    {
        /// <summary>
        /// The raw xml file
        /// </summary>
        public XmlDocument xmlDatabase { get; }

        /// <summary>
        /// The card list.
        /// </summary>
        public List<Card> cardList { get; }

        public string xmlDatabasePath { get; }

        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// No arg constructor
        /// </summary>
        public MagicDB_Parse_xml()
        {
            xmlDatabase = new XmlDocument();
            cardList = new List<Card>();
            xmlDatabasePath = "../../Main/Resources/Database/MagicTG_DB_Main.xml";
        }

        /// <summary>
        /// Paramaterized constructor to change the xml database path to something other than the default.
        /// </summary>
        /// <param name="xmlDatabasePath">string: The new path. Cannot be <code>null</code> or empty.</param>
        public MagicDB_Parse_xml(string xmlDatabasePath)
        {
            Requires<ArgumentNullException>(String.IsNullOrEmpty(xmlDatabasePath), @"The path to the xml database  
                file cannot be null or empty");
            xmlDatabase = new XmlDocument();
            cardList = new List<Card>();
            this.xmlDatabasePath = xmlDatabasePath;
        }

        /// <summary>
        /// Loads the card database from the xml file
        /// </summary>
        /// <returns>A List<Card> of the cards loaded.</Card></returns>
        public List<Card> LoadDB()
        {
            xmlDatabase.Load(xmlDatabasePath);
            XmlNodeList cards = xmlDatabase.GetElementsByTagName("card");
            for (int i = 0; i < cards.Count; i++)
            {
                XmlNode currentCard = cards[i];
                Card newCard = new Card(currentCard["name"].InnerText, currentCard["set"].InnerText, currentCard["number"].InnerText);
                cardList.Add(newCard);
            }
            _log.Info("Loaded Cards Successfully");
            return cardList;
            
        }

    }
}
