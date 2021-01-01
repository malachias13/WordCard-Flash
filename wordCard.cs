using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace WordGUI_Frameworks_
{
    public class Card
    {
        public int Id { get; set; }
        public string word { get; set; }
        public string definition { get; set; }


    }
  
    class wordCard
    {

        public string[] wordArray = new string[10];
        public string [] definitionArray = new string[10];
        public string str;
        public string def;

        public int ArrayLocation;
        int current;
        public int Id;
        //public int cout;

        // move to the right of the array [Next] Function
        public void padNext()
        {
            int numberOfElemnts;

            numberOfElemnts = wordArray.Length -1;
            if(wordArray[ArrayLocation+1] == null)
            {
                ArrayLocation = 0;
            }
             else if (ArrayLocation < numberOfElemnts)
            {
                ArrayLocation += 1;
            } 
            else if (ArrayLocation >= numberOfElemnts)
            {
                ArrayLocation = 0;
            }
        }

        public void padpreviou()
        {
            int numberOfElemnts;

            numberOfElemnts = wordArray.Length-1;

            for(int i= 0;i < wordArray.Length; i++)
            {
                if(wordArray[i] == null)
                {
                    current = i-1;
                    break;
                }    
            }
            if(ArrayLocation <=0)
            {
                ArrayLocation = current;
            }
            else if (ArrayLocation >= numberOfElemnts || ArrayLocation < numberOfElemnts)
            {
                ArrayLocation -= 1;
            }

        }

        public string AddWordFunction(string word)
        {
            str = word;
            for (int i = 0; i < wordArray.Length; i++)
            {
                if(wordArray[i] == null)
                {
                    wordArray[i] = str;
                    Id = i;
                    break;
                }
            }

            return str;
          
        }
        public string AddDefFunction(string definition)
        {
            def = definition;
            for(int i = 0; i<definitionArray.Length;i++)
            {
                if(definitionArray[i]==null)
                {
                    definitionArray[i] = def;
                    break;
                }
                
                
            }

            return def;
        }

        public void RemoveWord()
        {
            int TimesToLoop = (wordArray.Length - 1) - ArrayLocation;
            int CLocation = ArrayLocation;

            for(int i = 0;i<TimesToLoop;i++)
            {
                
                wordArray[CLocation] = wordArray[CLocation + 1];
                definitionArray[CLocation] = definitionArray[CLocation + 1];
                CLocation++;
                
            }
            
        }

        public void test()
        {
            str = "Hell! It works Yay";
        }
    }
}
