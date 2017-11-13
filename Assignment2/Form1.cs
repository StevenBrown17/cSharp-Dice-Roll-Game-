using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {

        public Form1(){
            InitializeComponent();
            printStats();
        }

        #region vars

        /// <summary>
        /// dieRoll is the random number generated.
        /// </summary>
        public int dieRoll;
        /// <summary>
        /// played is a counter, counting number of games played
        /// </summary>
        public int played;
        /// <summary>
        /// won is a counter, counting the number of games won
        /// </summary>
        public int won;
        /// <summary>
        /// lost is a counter, counting the number of games lost
        /// </summary>
        public int lost;
        /// <summary>
        /// input holds the value of the user input box. This variable is set in the validateInput(String ...) method
        /// and should not be hard coded. This variable is only assigned a value if the user input is valid
        /// </summary>
        public int input;
        /// <summary>
        /// this variable keeps track of the win percentage
        /// </summary>
        double winpercent;

        /// <summary>
        /// headers is an array that will set in the statsBox 
        /// </summary>
        String[] headers = { "Face", "Frequency", "Percent", "Number of times guessed" };
        /// <summary>
        /// face1 array will hold the stats data [0] - Face, [1] - Frequency, [2] - Percent, [3] - Num times guessed
        /// </summary>
        public decimal[] face1 = { 1, 0, 0 , 0 };
        /// <summary>
        /// face2 array will hold the stats data [0] - Face, [1] - Frequency, [2] - Percent, [3] - Num times guessed
        /// </summary>
        public decimal[] face2 = { 2, 0, 0 , 0 };
        /// <summary>
        /// face3 array will hold the stats data [0] - Face, [1] - Frequency, [2] - Percent, [3] - Num times guessed
        /// </summary>
        public decimal[] face3 = { 3, 0, 0 , 0 };
        /// <summary>
        /// face4 array will hold the stats data [0] - Face, [1] - Frequency, [2] - Percent, [3] - Num times guessed
        /// </summary>
        public decimal[] face4 = { 4, 0, 0 , 0 };
        /// <summary>
        /// face5 array will hold the stats data [0] - Face, [1] - Frequency, [2] - Percent, [3] - Num times guessed
        /// </summary>
        public decimal[] face5 = { 5, 0, 0 , 0 };
        /// <summary>
        /// face6 array will hold the stats data [0] - Face, [1] - Frequency, [2] - Percent, [3] - Num times guessed
        /// </summary>
        public decimal[] face6 = { 6, 0, 0 , 0 };

        #endregion

        #region click actions

        /// <summary>
        /// rollBtn_Click contains instructions to be performed upon clicking rollBtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollBtn_Click(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            if (!validateInput(inputBox.Text))
            {//if validateInput() returns false, will run

                for (int i = 0; i < 7; i++){
                    Random rnd = new Random();
                    int dice = rnd.Next(1, 7);

                    pictureBox.Image = Image.FromFile("die" + dice.ToString() + ".gif");
                    pictureBox.Refresh();
                    Thread.Sleep(200);

                    //if statement contains methods that determine statistics
                    if (i == 6){
                        dieRoll = dice;
                        determineOutcome(input, dieRoll);
                        setStats(input, dieRoll);
                        printStats();
                    }

                }//end for
            }//end if
        }//end rollBtn_click()

        /// <summary>
        /// resetBtn_Click contains instructions to be performed upon  clicking resetBtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetBtn_Click(object sender, EventArgs e){
            reset();
        }

        #endregion

        #region methods

        /// <summary>
        /// validateInput(String ...) gets the value from the user input, attempts to parse and check 1-6 conditions. 
        /// If parse fails or conditions not met, message box informs user that their input was in an invalid format.
        /// Returns true if parse/conditions fail.
        /// Returns false if passed.
        /// bool variable is used to capture method output.
        /// </summary>
        /// <param name="inputBoxValue">This is the user input value from the text box</param>
        /// <returns></returns>
        private bool validateInput(String inputBoxValue){
            DialogResult MyResult;

            try{
                input = Int32.Parse(inputBoxValue);

                if (input != 1 && input != 2 && input != 3 && input != 4 && input != 5 && input != 6){
                    MyResult = MessageBox.Show("Please enter a number between 1 and 6", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }

                return false;
            }
            catch(Exception e) {
                MyResult = MessageBox.Show("Please enter a number between 1 and 6", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }//end try catch
        }//end validateInput()

        /// <summary>
        /// Increments number of games played, and sets playedLbl
        /// Compares user input to random number generated, if they are equal, return true and increment won and sets wonLbl.
        /// if not equal, return false and increment lost and sets lostLbl
        /// </summary>
        /// <param name="numberGuessed"></param>
        /// <param name="numberRolled"></param>
        /// <returns></returns>
        private void determineOutcome(int numberGuessed, int numberRolled){

            played++;
            playedLbl.Text = played.ToString();

            if (numberGuessed == numberRolled){
                won++;
                wonLbl.Text = won.ToString();
            }
            else{
                lost++;
                lostLbl.Text = lost.ToString();
            }

            winpercent = ((double)won / (double)played) *100;
            winpercent = Math.Round(winpercent, 2);
            winPercentage.Text = winpercent +"%";

        }//end determineOutcome()

        /// <summary>
        /// resets all vars and labels to default vales
        /// </summary>
        public void reset(){
            played = 0;
            won = 0;
            lost = 0;
            winpercent = 0;
            playedLbl.Text = "0";
            wonLbl.Text = "0";
            lostLbl.Text = "0";
            winPercentage.Text = "0%";
            inputBox.Clear();
            face1[1] = 0; face1[2] = 0; face1[3] = 0;
            face2[1] = 0; face2[2] = 0; face2[3] = 0;
            face3[1] = 0; face3[2] = 0; face3[3] = 0;
            face4[1] = 0; face4[2] = 0; face4[3] = 0;
            face5[1] = 0; face5[2] = 0; face5[3] = 0;
            face6[1] = 0; face6[2] = 0; face6[3] = 0;

            printStats();
        }
        

        /// <summary>
        /// printStats() concats headers and face arrays together, then sets the statsBox textarea.
        /// </summary>
        public void printStats(){

            //sets tab spacing
            statsBox.SelectionTabs = new int[] { 90, 180, 270, 360 };
            
            String stats="";//initial string

            #region for loops

            for (int i = 0; i < headers.Length; i++){
                stats += headers[i] + "\t";
            }

            stats += "\n";
            for (int i = 0; i < face1.Length; i++){
                if(i==2) stats += face1[i] + "%\t";
                else stats += face1[i] + "\t";
            }

            stats += "\n";
            for (int i = 0; i < face2.Length; i++){
                if(i==2) stats += face2[i] + "%\t";
                else stats += face2[i] + "\t";
            }

            stats += "\n";
            for (int i = 0; i < face3.Length; i++){
                if (i == 2) stats += face3[i] + "%\t";
                else stats += face3[i] + "\t";
            }

            stats += "\n";
            for (int i = 0; i < face4.Length; i++){
                if (i == 2) stats += face4[i] + "%\t";
                else stats += face4[i] + "\t";
            }

            stats += "\n";
            for (int i = 0; i < face5.Length; i++){
                if (i == 2) stats += face5[i] + "%\t";
                else stats += face5[i] + "\t";
            }

            stats += "\n";
            for (int i = 0; i < face6.Length; i++){
                if (i == 2) stats += face6[i] + "%\t";
                else stats += face6[i] + "\t";
            }

            #endregion

            statsBox.Text = stats; //sets textbox

        }

        /// <summary>
        /// setStats(int ..., int ...) calculates the information needed to display in the statsBox textbox
        /// </summary>
        /// <param name="numGuessed"></param>
        /// <param name="numRolled"></param>
        public void setStats(int numGuessed, int numRolled){
            //double[] face1 = { 1, 0, 0.00, 0 };

            switch (numGuessed){
                            case 1:
                                face1[3]++;
                                break;
                            case 2:
                                face2[3]++;
                                break;
                            case 3:
                                face3[3]++;
                                break;
                            case 4:
                                face4[3]++;
                                break;
                            case 5:
                                face5[3]++;
                                break;
                            case 6:
                                face6[3]++;
                                break;
                            default:
                                break;

                        }//end switch

            switch (numRolled){
                case 1:
                    face1[1]++;
                    break;
                case 2:
                    face2[1]++;
                    break;
                case 3:
                    face3[1]++;
                    break;
                case 4:
                    face4[1]++;
                    break;
                case 5:
                    face5[1]++;
                    break;
                case 6:
                    face6[1]++;
                    break;
                default:
                    break;

            }//end switch

            for (int i = 0; i < face1.Length; i++){
                face1[2] = face1[1] / played * 100;
                face2[2] = face2[1] / played * 100;
                face3[2] = face3[1] / played * 100;
                face4[2] = face4[1] / played * 100;
                face5[2] = face5[1] / played * 100;
                face6[2] = face6[1] / played * 100;
            }
            face1[2]=Math.Round(face1[2], 2);
            face2[2]=Math.Round(face2[2], 2);
            face3[2]=Math.Round(face3[2], 2);
            face4[2]=Math.Round(face4[2], 2);
            face5[2]=Math.Round(face5[2], 2);
            face6[2]=Math.Round(face6[2], 2);


        }//end setStats

        #endregion


    }//end class
}//end name space
