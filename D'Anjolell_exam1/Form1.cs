using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_exam1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the program when clicked
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Richard D'Anjolell
            //Try catch statement if there is an error accessing the file
            try
            {
                //Declare variables
                int occuranceNumber = 0;
                const int ARRAY_SIZE = 16;
                string[] fileLines = new string[ARRAY_SIZE];
                char[] charLines = new char[62];
                List<char> tempList;
                List<char> charList;
                string userInput = txtCh.Text;
                StreamReader inputFile;

                //Open the file
                inputFile = File.OpenText("..\\..\\hhlyrics.txt");

                //Declare the index for the arrays
                int indexNum = 0;

                //Sends lines from the file into an array
                while (indexNum < fileLines.Length && !inputFile.EndOfStream)
                {
                    //Set array number to line in the file
                    fileLines[indexNum] = inputFile.ReadLine();

                    //Increment index counter
                    indexNum++;
                }

                //Has a list of characters of the first line in the array
                charList = fileLines[0].ToCharArray().ToList();

                //Resets index to one for next while loop since 0 has already been done
                indexNum = 1;

                //While loop to have all characters in charList
                while (indexNum < fileLines.Length)
                {
                    //Find all characters, send to temp variable to be added to final list
                    charLines = fileLines[indexNum].ToCharArray();
                    tempList = charLines.ToList();
                    charList.AddRange(tempList);

                    //Increment index counter
                    indexNum++;
                }

                //Resets index for next while loop
                indexNum = 0;

                //While loop to find all the times the user character occurs
                while (indexNum < charList.Count())
                {
                    //If statement when the character from the list equals the user's
                    if (charList[indexNum] == userInput[0])
                    {
                        //Increment the number of times the character appears
                        occuranceNumber++;
                    }

                //Increment index counter
                indexNum++;
                }

                //Outputs the results found from the program
                lblChResult.Text = "This character shows up " + occuranceNumber.ToString() + " times.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEcrypt_Click(object sender, EventArgs e)
        {
            //Try catch statement if there is an error accessing the file
            try
            {
                //Declare variables
                const int ARRAY_SIZE = 16;
                string[] fileLines = new string[ARRAY_SIZE];
                char[] charLines = new char[62];
                List<char> tempList;
                List<char> charList;
                var finalTranscript = new StringBuilder();
                StreamReader inputFile;

                //Open the file
                inputFile = File.OpenText("..\\..\\hhlyrics.txt");

                //Declare the index for the arrays
                int indexNum = 0;

                //Sends lines from the file into an array
                while (indexNum < fileLines.Length && !inputFile.EndOfStream)
                {
                    //Set array number to line in the file
                    fileLines[indexNum] = inputFile.ReadLine();

                    //Increment index counter
                    indexNum++;
                }

                //Has a list of characters of the first line in the array
                charList = fileLines[0].ToCharArray().ToList();

                //Resets index to one for next while loop since 0 has already been done
                indexNum = 1;

                //While loop to have all characters in charList
                while (indexNum < fileLines.Length)
                {
                    //Find all characters, send to temp variable to be added to final list
                    charLines = fileLines[indexNum].ToCharArray();
                    tempList = charLines.ToList();
                    charList.AddRange(tempList);

                    //Increment index counter
                    indexNum++;
                }

                //Resets index for next while loop
                indexNum = 0;

                //While loop to encrypt certain characters
                while (indexNum < charList.Count())
                {
                    //A set of if statements to encrypt certain characters
                    if (charList[indexNum] == "A".ToCharArray()[0])
                    {
                        charList[indexNum] = "Z".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "a".ToCharArray()[0])
                    {
                        charList[indexNum] = "z".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "D".ToCharArray()[0])
                    {
                        charList[indexNum] = "W".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "d".ToCharArray()[0])
                    {
                        charList[indexNum] = "w".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "H".ToCharArray()[0])
                    {
                        charList[indexNum] = "T".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "h".ToCharArray()[0])
                    {
                        charList[indexNum] = "t".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "K".ToCharArray()[0])
                    {
                        charList[indexNum] = "R".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "k".ToCharArray()[0])
                    {
                        charList[indexNum] = "r".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "M".ToCharArray()[0])
                    {
                        charList[indexNum] = "P".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "m".ToCharArray()[0])
                    {
                        charList[indexNum] = "p".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "O".ToCharArray()[0])
                    {
                        charList[indexNum] = "N".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "o".ToCharArray()[0])
                    {
                        charList[indexNum] = "n".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "S".ToCharArray()[0])
                    {
                        charList[indexNum] = "J".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "s".ToCharArray()[0])
                    {
                        charList[indexNum] = "j".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "X".ToCharArray()[0])
                    {
                        charList[indexNum] = "E".ToCharArray()[0];
                    }
                    else if (charList[indexNum] == "x".ToCharArray()[0])
                    {
                        charList[indexNum] = "e".ToCharArray()[0];
                    }

                    //Increment index counter
                    indexNum++;
                }

                //Resets index for next while loop
                indexNum = 0;

                //Combine all the characters into one cohesive stringbuilder to be outputed
                while (indexNum < charList.Count())
                {
                    finalTranscript.Append(charList[indexNum]);

                    //If statement to add a newline, so the stringbuilder fits on the form
                    if (finalTranscript.Length % 45 == 0)
                    {
                        finalTranscript.Append("\n");
                    }

                    //Increment index counter
                    indexNum++;
                }
                
                //Outputs stringbuilder that was made in the while loop
                lblEncryptResult.Text = finalTranscript.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
