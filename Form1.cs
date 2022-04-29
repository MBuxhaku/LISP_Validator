using System;
using System.Linq;

namespace LISP_Validator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearTextBtn_Click(object sender, EventArgs e)
        {
            inputTb.Clear();
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            string lispCode = inputTb.Text;
            int openPCount = 0;
            int closePCount = 0;
            int quoteCount = 0;
            int quoteBalance = 0;

            if(lispCode.Length > 0)
            {
                // Edge case if code is string literal
                if (lispCode.Count(f => (f == '"')) == 2 &&
                   lispCode[0] == '"' &&
                   lispCode[lispCode.Length - 1] == '"')
                {
                    MessageBox.Show("Input LISP code is string literal");
                }
                // Edge case if line is commented out
                else if (lispCode[0] == ';')
                {
                    MessageBox.Show("Input LISP code is a comment");
                }
                // Handle majority of string processing not covered by common
                // edge cases.
                else
                {
                    foreach (char c in lispCode)
                    {
                        // Anything following ; is a comment, dont process
                        if (c == ';') break;

                        // Check if opening/closing quotes
                        if (c == '"') quoteCount++;

                        // Only count paranthesis if quote is closed(even quotes) 
                        if (quoteCount % 2 == 0)
                        {
                            if (c == '(')
                            {
                                openPCount++;
                                quoteBalance++;
                            }
                            else if (c == ')')
                            {
                                closePCount++;
                                quoteBalance--;
                            }
                        }
                    }

                    if (openPCount != closePCount || quoteBalance > 0)
                    {
                        MessageBox.Show("Paranthesis not properly closed or nested");
                    }
                    else
                    {
                        // At this point the majority of cases are covered. There are more
                        // cases to be made for escape characters etc. 
                        MessageBox.Show("Paranthesis in LISP code are valid");
                    }
                }
            }
            else
            {
                // Edge case code string is empty
                MessageBox.Show("Input LISP string is empty");
            }



        }
    }
}