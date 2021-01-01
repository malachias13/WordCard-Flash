using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
namespace WordGUI_Frameworks_
{
    public class DataAccess
    {
        public List<Card> GetData()
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WordGUI_Frameworks_.Properties.Settings.DataCardsConnectionString")))
            {
                return connection.Query<Card>($"select * from CardTable").ToList();
            }
        }
        public void AddData(string word,string def)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WordGUI_Frameworks_.Properties.Settings.DataCardsConnectionString")))
            {
                // connection.Query<Card>($"Insert Into CardTables (word,definition) Values('{word}','{def}');");
                List<Card> Deck = new List<Card>();

                Deck.Add(new Card { word = word, definition = def });
                connection.Execute("AddData @word, @definition", Deck);
            }
        }
        public void RemoveData(int Id) // I may have to add the Id as praimter
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WordGUI_Frameworks_.Properties.Settings.DataCardsConnectionString")))
            {
                List<Card> Deck = new List<Card>();
                Deck.Add(new Card { Id = Id });
                connection.Execute("RemoveData @Id", Deck);
            }
            
        }
    }
}
