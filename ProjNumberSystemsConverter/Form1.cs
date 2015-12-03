using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjNumberSystemsConverter
{
    public partial class frmNSC : Form
    {
        //These arrays store lists of Binary and Hexadecimal values, They can be used by any method.
        string [] hexBin = {"0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"};
        string [] hexValues = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A (10)", "B (11)", "C (12)", "D (13)", "E (14)", "F (15)"};
        public string checkRef = " ";//a reference that Method form uses to see which conversion is checked.

        public frmNSC()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtOutput.BackColor = System.Drawing.SystemColors.Window;//Sets txtOutput background to white.
            rtbWorking.BackColor = System.Drawing.SystemColors.Window;//Sets rtbWorking background to white.
            this.MaximizeBox = false;//diables the maximise button.
        }

        private void txtOuput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)//Close Button
        {
            this.Close();//Closes the application.
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConvert_Click(object sender, EventArgs e)//Convert Button... Starts the conversion.
        {
            //Cleard output and working areas of an previous conversion info.
            txtOutput.Clear();
            rtbWorking.Clear();
            
            
            String input = txtInput.Text;  //Stores the value in the input textbox

           
            if (rdoBtH.Checked)             //These if else's identify which convesion 
            {                               //radio button is selected. Input is then sent
                if (binValidate(input))     //to the appropriate validation method to make sure 
                {                           //it is a covertable value.
                    btnMethod.Enabled = true;//Method button is enabled and a reference is noted so
                    checkRef = "BtH";       //that the method form knows which method to show.
                    binToHex(input);        //Finally input is sent to the appropriate conversion
                }                           //method to be converted and diaplayed.
            }
            else if (rdoHtB.Checked)        
            {
                if (hexValidate(input))
                {
                    btnMethod.Enabled = true;
                    checkRef = "HtB";
                    hexToBin(input);
                }
            }
            else if (rdoHtD.Checked)
            {
                if (hexValidate(input))
                {
                    btnMethod.Enabled = true;
                    checkRef = "HtD";
                    hexToDen(input);
                }
            }
            else if (rdoDtB.Checked)
            {
                if (denValidat(input))
                {
                    btnMethod.Enabled = true;
                    checkRef = "DtB";
                    denToBin(input);
                }
            }
            else if (rdoDtH.Checked)
            {
                if (denValidat(input))
                {
                    btnMethod.Enabled = true;
                    checkRef = "DtH";
                    denToHex(input);
                }
            }
            else if (rdoBtD.Checked)
            {
                if (binValidate(input))
                {
                    btnMethod.Enabled = true;
                    checkRef = "BtD";
                    binToDen(input);
                }
            }
            else      //if no conversion is selected an error is shown.
                MessageBox.Show("Please select a conversion",   
                    "Error - No Conversion Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool binValidate(String input)//Binary Validation
        {
            //Checks that an input string is a binary number.


            if (input == "")//checks a value has been entered.
            {
                MessageBox.Show("Please enter a value.",
                        "Error-Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            for (int i = 0; i<= input.Length -1; i++)//Runs through each charcter off input string.
            {
                int testInt = (int)char.GetNumericValue(input[i]);//turns the current char into an integer.
                if (testInt < 0 || testInt > 1)//tests if current char is a 1 or 0
                {
                    MessageBox.Show("Binary numbers can only be made up of 1's or 0's.", 
                        "Error-Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool hexValidate(String input)//Hexadecimal Validation
        {
            //Checks that the input string is a valid Hexadecimal number.

            input = input.ToUpper();// Changes all character in input to upper class character.

           int char16 = 0;//stores the first character of input as an int.


            if (input.Length > 15) //checks if the input is 16 or more characters long.
            {
                char16 = (int)char.GetNumericValue(input[0]);//stores the first charater as an int

                if (input.Length > 16 || (input.Length > 15 && (char16 > 7 || char16 < 0 )))
                    //Displays an error message if the input is longer than 16 characters or
                    //Displays an error if the first charater is larger than 7 or less than 0
                    //(Characters are converted to -1)
                {
                    MessageBox.Show("Hex number must be smaller then 7fffffffffffffff",
                        "Error-Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (input == "")//checks a value has been entered
            {
                MessageBox.Show("Please enter a value.",
                        "Error-Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for(int i = 0; i<= input.Length -1; i++)//Runs through each character of input string/
            {
                switch (input[i])//checks that each character is 0-9 or A-E. 
                {
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                        break;
                           
                    default://shows an error if a non hex value is entered.
                        MessageBox.Show("Hexadecimal numbers can only be made up of 0-9 and A-E.", 
                            "Error-Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                        
                }
            }
            return true;
        }

        private bool denValidat(String input)//Denary Validation
        {
            if (input == "")//checks a value has been entered.
            {
                MessageBox.Show("Please enter a value.",
                        "Error-Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (input.Length > 18)//displays the maximum value.
            {
                MessageBox.Show("The maximum value that can be converted is 999999999999999999.",
                        "Error-Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 0; i <= input.Length - 1; i++)//Runs through each charcter off input string.
            {
                int testInt = (int)char.GetNumericValue(input[i]);//turns the current char into an integer.

                if (testInt < 0 || testInt > 9)//tests if current char is a 0 -9
                {
                    MessageBox.Show("Denary numbers can only be made up of 0 - 9 values. There must be no symbols or letters",
                        "Error-Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;

        }


        private void binToHex(String input)//Binary to Hexadecimal Conversion
        {
            while (input.Length % 4 != 0)//Adds zeros to the start on input until its length is a multiple of 4
            {
                input = "0" + input;
            }


           
            string[] binSep = new string[input.Length / 4];// An array that will store 4 didgets of input in each position.

            binSep[0] = input.Substring(0, 4);


            for (int i = 1; i <= input.Length / 4 - 1; i++)//Separates input into 4's and stores them in binSep Array.
            {
                binSep[i] = input.Substring(i*4, 4);
            }

            
            rtbWorking.AppendText("THE FOLLOWING ARE BINARY NUMBERES WITH THEIR HEXADECIMAL VALUE; \n\n"); 
            
            for (int i = 0; i <= hexBin.Length-1 ; i++)//Displays a list of 4 digit binary numbers with                                  
            {                                         //their hexadecimal value.
                rtbWorking.AppendText(hexBin[i] + " = " + hexValues[i] + "\n");
            } 

            rtbWorking.AppendText("\nMAKE YOUR INPUT'S LENGTH A MULTIPLE OF 4 BY ADDING ZEROS TO START \n\n");
            rtbWorking.AppendText("YOUR INPUT = " + input + "\n\nSEPARATED = " );
            
            
            for (int i = 0; i<= binSep.Length -1; i++)//Prints each element of binSep array separated.
            {
                rtbWorking.AppendText(binSep[i]);

                if (i <= binSep.Length -2 )//Adds a separation  between each element of array.
                {
                    rtbWorking.AppendText("  -  ");
                }
            }


            rtbWorking.AppendText("\n\n");

            txtOutput.Text = binaryHexFinder(binSep);//sends the  binsep array to be converted, result 
                                                     //is returned and displayed in output textbox.
        }


        private string binaryHexFinder(string [] binSep)//Finds the Headecimal value of a 4 digit binary number.
        {
            string output = "";

            for (int j = 0; j <= binSep.Length - 1; j++)    //runs through each each element of binSep array(each 4 part of input)
            {
                for (int i = 0; i <= hexBin.Length - 1; i++)//runs through hexBin array (contains binary values)
                {
                    if (binSep[j] == hexBin[i])         //if the separated value matches a binary value, that binarys index
                    {                                   //is used to match it to its hex value.
                        rtbWorking.AppendText(binSep[j] + " = " + hexValues[i] + "\n");
                        string hexVal1Dig = hexValues[i];
                        output = output + hexVal1Dig[0];
                    }
                }


            }
            return output;//returns output to binToHex method, where is is displayed in output textbox
        }


        private void hexToBin(String input)//Hexadecimal to Binary Conversion
        {
            rtbWorking.AppendText("THE FOLLOWING ARE HEXADECIMAL NUMBERS WITH THEIR BINARY VALUES;\n\n");

            for (int i = 0; i <= hexValues.Length - 1; i++) // prints hex values with their binary values
            {
                rtbWorking.AppendText(hexValues[i] + " = " + hexBin[i] + "\n");
            }
            rtbWorking.AppendText("\nEACH CHARACTER'S BINARY VALUE MAKES UP THE BINARY NUMBER \n\nINPUT = ");
            
            input = input.ToUpper();//makes input uppercase

            for (int i = 0; i <= input.Length - 1; i++)
            {                                           // separates and prints the characters
                rtbWorking.AppendText(input[i] + "");   //of input. the lase value does not have a dash.
                if (i <= input.Length - 2)
                {
                    rtbWorking.AppendText("  -  ");
                }
            }

            rtbWorking.AppendText("\n\n");//outputs separation

            string output = "";

            for (int i = 0; i <= input.Length -1; i++) //runs through each char of input         
            {
                for (int j = 0; j <= hexValues.Length - 1; j++) // runs through hex values array
                {
                    string firstChar = hexValues[j];//Gets the first character of the value stored in hexvalues (Gets rid of the (10) (11) etc)
                    
                    if (input[i] == firstChar[0])//compares char with hexvalues and prints the appropriate binary.
                    {
                        rtbWorking.AppendText(input[i] + " = " + hexBin[j] + "\n");
                        output = output + hexBin[j];//concatinates the found binarys
                    }
                }
            }

            txtOutput.Text = output;//outputs the full binary.
        }


        private void hexToDen(String input)//Hexadecimal to Denary Conversion
        {
            int[] reversedInput = new int[input.Length];//an array to store each character of input in reverse
            int count = 0;//used to count up the array positions
            long output = 0;
            input = input.ToUpper();

            for (int i = input.Length - 1; i>= 0; i--)
            {
                switch (input[i])//checks through each character of the array backwards and stores the 
                {                //appropriate value in the array.
                    case 'A':
                        reversedInput[count] = 10;
                        break;
                    case 'B':
                        reversedInput[count] = 11;
                        break;
                    case 'C':
                        reversedInput[count] = 12;
                        break;
                    case 'D':
                        reversedInput[count] = 13;
                        break;
                    case 'E':
                        reversedInput[count] = 14;
                        break;
                    case 'F':
                        reversedInput[count] = 15;
                        break;
                    default:
                        reversedInput[count] = (int)char.GetNumericValue(input[i]);
                        break;
                }
                count++;//move up an array position
            }

            for (int i = input.Length - 1; i >= 0; i--)//runs through reversed input backwards
            {
                long result = reversedInput[i] * ((long) Math.Pow(16, i));//multiplys the value in the array by 16 to the power of its index.
                output += result;//totals the results

                rtbWorking.AppendText(reversedInput[i] + "  x  16^" + i + "  = " + result +"\n");//displays working
                if (i >= 1)
                {
                    rtbWorking.AppendText("\n    +\n\n");//separation
                }

            }

            rtbWorking.AppendText("\n = " + output);

            txtOutput.Text = output.ToString();//output the decimal number.

        }


        private void denToBin(String input)//Denary to Binary conversion
        {
            long inputToLong = Convert.ToInt64(input);//converts input to long.
            string output = "";
            string outputReversed = "";

            while (inputToLong != 0)  //runs while the input is more than zero
            {
                long remainder = inputToLong % 2; //loops to divide input by 2 storing its outputting the result and remainder
                output += remainder.ToString();   //changes remainder to string and concatinates it onto output  
                rtbWorking.AppendText(inputToLong + "  ÷ 2   =" + (inputToLong / 2) + "     R " + remainder + "\n\n");
                inputToLong = inputToLong / 2;
            }

            for (int i = output.Length - 1; i >= 0; i--)//reverses output as it currently stored the binary backwards.
            {
                outputReversed += output[i];
            }

                txtOutput.Text = outputReversed;//outputs the reversed output.
            
        }


        private void denToHex(String input)//Denary to Hexadecimal conversion
        {
            long Input = Convert.ToInt64(input); //converts input to long
            string output = "";

            while (Input != 0)//works while long input is more than zero
            {
                long remainder = Input % 16; //stores the remainder of input divided by 16

                switch (remainder)//changes any remander above 10 to its appropriate hex value. and 
                {                 //concatinates it onto output  
                    case 10:
                            output += "A";
                        break;
                    case 11:
                            output += "B";
                        break;
                    case 12:
                            output += "C";
                        break;
                    case 13:
                            output += "D";
                        break;
                    case 14:
                            output += "E";
                        break;
                    case 15:
                            output += "F";                      
                        break;
                    default:
                        output += remainder.ToString();//any value less than 10 is converted to string and concatinated 
                        break;                         //onto output.
                }

                rtbWorking.AppendText(Input + "÷16=   " + (Input / 16) + "   R " + remainder + "\n\n");//displays working

                Input /= 16;// up dates input after each cycle
            }

            string outputReversed = "";

            for (int i = output.Length -1; i >= 0; i-- )
            {
                outputReversed += output[i]; //reverses output as is currently the hex value backwards.
            }


                txtOutput.Text = outputReversed;//outputs hex value.
        }


        private void binToDen(String input)//Binary to Denary conversion
        {

                int[] reversedInput = new int[input.Length];//stores each char of input reversed.
                int count = 0;
                long output = 0;


                for (int i = input.Length - 1; i >= 0; i--)//runs through each character of input backwards
                {
                    reversedInput[count] = (int)char.GetNumericValue(input[i]);//stores the numeric value of each character in array
                    long result = reversedInput[count] * ((long)Math.Pow(2, count));//multiplys each binary number in the array by 2 to the power of its index position.
                    output += result;//totals the results 

                    rtbWorking.AppendText(reversedInput[count] + "  x  2^" + count + "  = " + result + "\n");//displays working
                    if (i >= 1)
                    {
                        rtbWorking.AppendText("\n    +\n\n");//spacing
                    }

                    count++;//moves up an array position.
                }

  

                rtbWorking.AppendText("\n = " + output);//displays output in working textbox

            txtOutput.Text = output.ToString();// converts output to string and displays it in output textbox.
        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)//Help Button
        {
            
            HelpForm helpForm = new HelpForm(this);
            helpForm.Show(); //shows the help form.
            btnHelp.Enabled = false;//disables help button so multiple help windows can not be opened.
        }

        private void rdoHtD_CheckedChanged(object sender, EventArgs e)
        {
        }//unused

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//unused

        private void rdoDtB_CheckedChanged(object sender, EventArgs e)
        {
        }//unused


        private void btnMethod_Click(object sender, EventArgs e)//Method Button
        {
            frmMethod methodForm = new frmMethod(this);//Send a reference of this form to method form.
            methodForm.Show();//shows the method form
            btnMethod.Enabled = false;//disables method button to stop it being opened multiple times.
        }
    }
}
 