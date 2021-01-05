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

        bool HasSelected = false;
        bool  HasData = true;

        public Form1()
        {
            InitializeComponent();

        }

        private void previou_Btn_Click(object sender, EventArgs e)
        {
            // Stops the user from beaking the program.
            if (HasData == false)
                return; 

            HasSelected = false;
            padpreviou();
        }

        private void next_Btn_Click(object sender, EventArgs e)
        {
            // Stops the user from beaking the program. Dose nothing when there is no data
            if (HasData == false)
                return;

            HasSelected = false;
            padNext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataAccess db = new DataAccess();
            cardDeck = db.GetData();
            /* This is a cheak to make sure there is data in the database. 
             * If there is no data in the database do nothing. 
             * It prvents the user from beaking the application and program.
             * 
             */
            if(cardDeck.Count != 0)
            {
                HasData = true;
                card = cardDeck[0];
            }
            else
            {
                HasData = false;
                
            }
                RefreshData();
                RefreshList();

                

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
                
                HasData = true;
            }
            RefreshData();
            RefreshList();



        }

        private void remove_Btn_Click(object sender, EventArgs e)
        {
            if (HasData == false)
                return;

            DataAccess db = new DataAccess();
            cardDeck = db.GetData();


            db.RemoveData(card.Id);
            
            cardDeck = db.GetData();

            if (cardDeck.Count == 0)
            {
                HasData = false;
                RefreshList();
                ClearCard();
                return;
            }
            else
            {
                padNext();
                RefreshList();
            }


        }

        private void Read_Btn_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

            speechSynthesizer.Rate = 2;

            speechSynthesizer.Speak(WordText.Text + ". " + DefineDox.Text);
        }
        private void WordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HasData == false)
                return;

            DataAccess db = new DataAccess();
            int selectedIndex;
            int IndexCount;
            string word;

            HasSelected = true;

            cardDeck = db.GetData();

            selectedIndex = WordList.SelectedIndex;
            card = cardDeck[selectedIndex];
            // debug (word)
            word = card.word;

            IndexCount = selectedIndex + 1;

            if(HasSelected == true)
            {
                WordText.Text = card.word;
                DefineDox.Text = card.definition;
                CardCount.Text = IndexCount.ToString();

            }

        }


        public void padNext()
        {
            DataAccess db = new DataAccess();
            int numItems;

            string words;
            string wordsB;

            cardDeck = db.GetData();
            numItems = cardDeck.Count;
            currentIndex = Convert.ToInt32(CardCount.Text)-1; // This is the problem Fix

            // Debug Word
            wordsB = card.word;

            
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
            // Debug (word)
            words = card.word;
            
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
            DataAccess db = new DataAccess();
            cardDeck = db.GetData();


            WordText.Text = card.word;
            DefineDox.Text = card.definition;
            CardCount.Text = id.ToString();

        }
        private void RefreshList()
        {
            DataAccess db = new DataAccess();
            cardDeck = db.GetData();

            // Update ListBox Home page 
            WordList.DataSource = cardDeck;
            WordList.DisplayMember = "FullInfo";
            WordList.Refresh();

            // Update ListBox Addwords page
            WordList2.DataSource = cardDeck;
            WordList2.DisplayMember = "FullInfo";
            WordList2.Refresh();
        }

        // Clear the Card
        private void ClearCard()
        {
            WordText.Text = string.Empty;
            DefineDox.Text = string.Empty;
            CardCount.Text = string.Empty;
        }

    }
}
