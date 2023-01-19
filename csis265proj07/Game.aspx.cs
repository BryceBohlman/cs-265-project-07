using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace csis265proj07
{
    public partial class Game : System.Web.UI.Page
    {
        private Random generator;
        private int guessCount;
        private int winningNumber;

        protected void Page_Load(object sender, EventArgs e)
        {
            generator = new Random();
 
            if(!Page.IsPostBack)
            {
                guessCount = 0;
                Session["guessCount"] = guessCount;
                winningNumber = generator.Next(100);
                Session["winningNumber"] = winningNumber;
            }
        }

        protected void btnNewGame_Click(object sender, EventArgs e)
        {
            guessCount = 0;
            Session["guessCount"] = guessCount;

            winningNumber = generator.Next(100);
            Session["winningNumber"] = winningNumber;

            lblInputResponse.Text = string.Empty;
        }

        protected void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            guessCount = (int)Session["guessCount"];
            guessCount++;
            Session["guessCount"] = guessCount;

            winningNumber = (int)Session["winningNumber"];

            if(Convert.ToInt32(txtGuessInput.Text) == winningNumber)
            {
                lblInputResponse.Text = $"Your guess is correct! ({guessCount} tries)";
            }
            else if (guessCount < 7)
            {
                if(Convert.ToInt32(txtGuessInput.Text) > winningNumber)
                {
                    lblInputResponse.Text = $"({guessCount} tries) Your guess is too high";
                }
                else 
                {
                    lblInputResponse.Text = $"({guessCount} tries) Your guess is too low";
                }
            }
            else
            {
                lblInputResponse.Text = $"You did not guess {winningNumber} within 7 tries";
            }

            txtGuessInput.Text = string.Empty;
        }
    }
}