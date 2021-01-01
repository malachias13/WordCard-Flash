using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Speech.Synthesis;

namespace WordGUI_Frameworks_
{
    public partial class Form1 : Form
    {  
        Card card = new Card();
        List<Card> cardDeck = new List<Card>();

        int currentIndex = 1;
        int id = 1;
        int Index = 0;

        string word;
        string definition;

        public Form1()
        {
            InitializeComponent();

        }

        private void previou_Btn_Click(object sender, EventArgs e)
        {
            padpreviou();
        }

        private void next_Btn_Click(object sender, EventArgs e)
        {
            padNext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataAccess db = new DataAccess();
            cardDeck = db.GetData();

            card = cardDeck[0];

            RefreshData();
        }

        private void addWord_Btn_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            addWordPanel.Show();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            addWordPanel.Hide();
            HomePanel.Show();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            
            DataAccess db = new DataAccess();
            word = addWord.Text;
            definition = addDefinition.Text;
            if(word != string.Empty)
            {
                db.AddData(word,definition);
                addWord.Text = string.Empty;
                addDefinition.Text = string.Empty;
            }
            

        }

        private void remove_Btn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            cardDeck = db.GetData();


            db.RemoveData(card.Id);
            padNext();
        }

        private void Read_Btn_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

            speechSynthesizer.Rate = 3;

            speechSynthesizer.Speak(WordText.Text + ". " + DefineDox.Text);
        }
        public void padNext()
        {
            DataAccess db = new DataAccess();
            int numItems;

            cardDeck = db.GetData();
            numItems = cardDeck.Count;
            currentIndex = Convert.ToInt32(CardCount.Text)-1; // This is the problem Fix

            currentIndex++;

            if(currentIndex < numItems)
            {
                
                card = cardDeck[currentIndex];
                id = currentIndex + 1;
            }

            if(currentIndex>= numItems)
            {
                
                currentIndex = 0;
                card = cardDeck[currentIndex];
                id = currentIndex + 1;
            }
                RefreshData();
        }

        private void padpreviou()
        {
            DataAccess db = new DataAccess();
            int numItems;
            int Max;
            cardDeck = db.GetData();
            numItems = Convert.ToInt32(CardCount.Text);
            Max = cardDeck.Count;

            Index = numItems -1;

            if(Index <= 0)
            {
                Index = Max;
            }

            if(Index > 0)
            {
               
                Index--;
                card = cardDeck[Index];
                id = Index + 1;
                
            }

            RefreshData();
        }

        private void RefreshData()
        {
            WordText.Text = card.word;
            DefineDox.Text = card.definition;
            CardCount.Text = id.ToString();
        }

    }
}
