using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NguyenLe_QuizProject
{
    public partial class HauptStad_Land : Form
    {
        Random random = new Random();
        //Game Data
        private Game game;
        private int questionNr = 0;
        private Einstellung parentForm;
        private User user;
        private Database db = new Database();
        private List<Land> lands;
        private RadioButton[] answersButtons = new RadioButton[4];

        private Bitmap[] flags = {Properties.Resources.Belgium, Properties.Resources.Brazil, Properties.Resources.Cameroon, Properties.Resources.China,
                                Properties.Resources.France,Properties.Resources.Germany,Properties.Resources.India,Properties.Resources.Iraq,
                                Properties.Resources.Japan,Properties.Resources.Libya,Properties.Resources.Nigeria,Properties.Resources.North_Korea,
                                Properties.Resources.Portugal,Properties.Resources.United_Kingdom,Properties.Resources.United_States_of_America,
                                Properties.Resources.Vietnam};

        // Game Setting
        private int gameMode;
        private int continent;

        public HauptStad_Land(User user, Einstellung parentForm, int gameMode, int continent)
        {

            this.gameMode = gameMode;
            this.parentForm = parentForm;
            this.user = user;
            this.game = new Game(0, user.UserID, System.DateTime.Now);
            this.continent = continent;

            InitializeComponent();

            labelUser.Text = string.Format("Wilkommen, {0}, bitte folgende Fragen beanworten.", user.Name);
            labelFrageNr.Text = "Frage Nr." + (questionNr + 1);
            //Assign each radioButton to the coresponding index in Array
            answersButtons[0] = radioButton1;
            answersButtons[1] = radioButton2;
            answersButtons[2] = radioButton3;
            answersButtons[3] = radioButton4;
            // Get listLand from DB
            getLands();
            // assign flag
            for (int i = 0; i < lands.Count(); i++)
            {
                lands[i].Flag = flags[i];
            }
            shuffleLand(lands);
            // Achtung, DB has not enough entry for other continent to be selected beside 0
            if (continent != 0)
            {

            lands.RemoveAll(s => s.Continent != continent);
            }
            

            // Show question/answer based on game mode selected from parent form
            switch (gameMode)
            {
                case 1:
                    generateQuestionAndAnswerMode1(questionNr);
                    break;
                case 2:
                    generateQuestionAndAnswerMode2(questionNr);
                    break;
                case 3:
                    generateQuestionAndAnswerMode3(questionNr);
                    break;
                case 4:
                    generateQuestionAndAnswerMode4(questionNr);
                    break;
                case 5:
                    generateQuestionAndAnswerMode5(questionNr);
                    break;
                case 6:
                    generateQuestionAndAnswerMode6(questionNr);
                    break;
            }
        }

        #region Internal Function
        private void getLands()
        {
            lands = db.getListLand();
        }
        //Shuffle function, shuffle posstion of the radioButton
        private void shuffleAnswer(RadioButton[] answers)
        {

            Point temp = new Point();

            for (int i = 0; i < 4; i++)
            {
                temp = answers[i].Location;
                int randomIndex = random.Next(4);
                answers[i].Location = answers[randomIndex].Location;
                answers[randomIndex].Location = temp;
            }
        }
        // Shuffle funcntion for randomness
        private void shuffleLand(List<Land> lands)
        {
            Land temp = new Land("temp", "temp", 1);
            for (int i = 0; i < lands.Count(); i++)
            {
                temp = lands[i];
                int randomIndex = random.Next(lands.Count());
                lands[i] = lands[randomIndex];
                lands[randomIndex] = temp;
            }
        }

        private void generateQuestionAndAnswerMode1(int questionNr)
        {
            questionNr = this.questionNr;
            if (questionNr < 10)
            {
                {
                    labelFrage.Text = string.Format("{0} ist die Hauptstadt von:", lands[questionNr].Capital);

                    radioButton1.Text = lands[questionNr].Name;
                    // Hide pictureBox
                    pictureBoxFrage.Visible = false;
                    // Randomize possible answer from list Land, using another List of index
                    List<int> listIndex = new List<int>();
                    listIndex.Add(questionNr);

                    int index;
                    // Add random unique index from lands.Count to listIndex
                    for (int i = 0; i < 4; i++)
                    {
                        do
                        {
                            index = random.Next(lands.Count);
                        } while (listIndex.Contains(index));
                        listIndex.Add(index);
                    }
                    // Assign Text to radioButton2 to 4
                    for (int i = 1; i < answersButtons.Length; i++)
                    {
                        answersButtons[i].Text = lands[listIndex[i]].Name;
                    }
                }
            }
            shuffleAnswer(answersButtons);
        }
        private void generateQuestionAndAnswerMode2(int questionNr)
        {
            questionNr = this.questionNr;
            if (questionNr < 10)
            {
                {
                    labelFrage.Text = string.Format("Die Hauptstadt von {0} ist:", lands[questionNr].Name);
                    radioButton1.Text = lands[questionNr].Capital;
                    // Hide pictureBox
                    pictureBoxFrage.Visible = false;

                    // Randomize possible answer from list Land, using another List of index
                    List<int> listIndex = new List<int>();
                    listIndex.Add(questionNr);

                    int index;
                    // Add random unique index from lands.Count to listIndex
                    for (int i = 0; i < 4; i++)
                    {
                        do
                        {
                            index = random.Next(lands.Count);
                        } while (listIndex.Contains(index));
                        listIndex.Add(index);
                    }

                    // Assign Text to radioButton2 to 4
                    for (int i = 1; i < answersButtons.Length; i++)
                    {
                        answersButtons[i].Text = lands[listIndex[i]].Capital;
                    }
                }
            }
            shuffleAnswer(answersButtons);
        }

        private void generateQuestionAndAnswerMode3(int questionNr)
        {
            questionNr = this.questionNr;
            if (questionNr < 10)
            {
                {
                    labelFrage.Text = string.Format("ist die Flag von: ");
                    // Move labelFrage to new Location to display pictureBoxFrage
                    labelFrage.Location = new Point(170, 92);
                    radioButton1.Text = lands[questionNr].Name;
                    pictureBoxFrage.Image = lands[questionNr].Flag;

                    // Randomize possible answer from list Land, using another List of index
                    List<int> listIndex = new List<int>();
                    listIndex.Add(questionNr);

                    int index;
                    // Add random unique index from lands.Count to listIndex
                    for (int i = 0; i < 4; i++)
                    {
                        do
                        {
                            index = random.Next(lands.Count);
                        } while (listIndex.Contains(index));
                        listIndex.Add(index);
                    }

                    // Assign Text to radioButton2 to 4
                    for (int i = 1; i < answersButtons.Length; i++)
                    {
                        answersButtons[i].Text = lands[listIndex[i]].Name;
                    }
                }
            }
            shuffleAnswer(answersButtons);
        }
        private void generateQuestionAndAnswerMode4(int questionNr)
        {
            questionNr = this.questionNr;
            if (questionNr < 10)
            {
                {
                    labelFrage.Text = string.Format("Die Flag von {0} ist: ", lands[questionNr].Name);
                    pictureBoxFrage.Visible = false;
                    radioButton1.Image = lands[questionNr].Flag;

                    // Randomize possible answer from list Land, using another List of index
                    List<int> listIndex = new List<int>();
                    listIndex.Add(questionNr);

                    int index;
                    // Add random unique index from lands.Count to listIndex
                    for (int i = 0; i < 4; i++)
                    {
                        do
                        {
                            index = random.Next(lands.Count);
                        } while (listIndex.Contains(index));
                        listIndex.Add(index);
                    }

                    // Assign Text to radioButton2 to 4
                    for (int i = 1; i < answersButtons.Length; i++)
                    {
                        answersButtons[i].Image = lands[listIndex[i]].Flag;
                    }
                }
            }
            shuffleAnswer(answersButtons);
        }
        private void generateQuestionAndAnswerMode5(int questionNr)
        {
            questionNr = this.questionNr;
            if (questionNr < 10)
            {
                {
                    labelFrage.Text = string.Format("ist die Flagge des Landes, das die \nHauptstadt ist: ");

                    labelFrage.Location = new Point(170, 92);
                    pictureBoxFrage.Visible = true;
                    pictureBoxFrage.Image = lands[questionNr].Flag;
                    radioButton1.Text = lands[questionNr].Capital;

                    // Randomize possible answer from list Land, using another List of index
                    List<int> listIndex = new List<int>();
                    listIndex.Add(questionNr);

                    int index;
                    // Add random unique index from lands.Count to listIndex
                    for (int i = 0; i < 4; i++)
                    {
                        do
                        {
                            index = random.Next(lands.Count);
                        } while (listIndex.Contains(index));
                        listIndex.Add(index);
                    }
                    // Assign Text to radioButton2 to 4
                    for (int i = 1; i < answersButtons.Length; i++)
                    {
                        answersButtons[i].Text = lands[listIndex[i]].Capital;
                    }
                }
            }
            shuffleAnswer(answersButtons);
        }
        private void generateQuestionAndAnswerMode6(int questionNr)
        {
            questionNr = this.questionNr;
            if (questionNr < 10)
            {
                {
                    labelFrage.Text = string.Format("Das Land, dessen Hauptstadt {0} heißt, \nhat die Flagge:: ", lands[questionNr].Capital);
                    pictureBoxFrage.Visible = false;
                    radioButton1.Image = lands[questionNr].Flag;

                    // Randomize possible answer from list Land, using another List of index
                    List<int> listIndex = new List<int>();
                    listIndex.Add(questionNr);

                    int index;
                    // Add random unique index from lands.Count to listIndex
                    for (int i = 0; i < 4; i++)
                    {
                        do
                        {
                            index = random.Next(lands.Count);
                        } while (listIndex.Contains(index));
                        listIndex.Add(index);
                    }
                    // Assign Text to radioButton2 to 4
                    for (int i = 1; i < answersButtons.Length; i++)
                    {
                        answersButtons[i].Image = lands[listIndex[i]].Flag;
                    }
                }
            }
            shuffleAnswer(answersButtons);
        }
        #endregion


        #region Event Handler
        private void buttonZumEinstellung_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // radioButton1 is always the right answwer
            if (radioButton1.Checked)
            {
                MessageBox.Show("richtig", "Gut", MessageBoxButtons.OK);
                game.Score++;
            }
            // Reset radioButton.Checked 
            foreach (var item in answersButtons)
            {
                item.TabStop = false;
                item.Checked = false;
            }

            labelFrageNr.Text = "Frage Nr." + (questionNr + 1);
            // Change buttonNext.Text 
            if (questionNr == 9)
            {
                buttonNext.Text = "Ende";
            }
            // Ende der Quiz 
            if (questionNr == 10)
            {
                if (radioButton1.Checked)
                {
                    MessageBox.Show("richtig", "Gut", MessageBoxButtons.OK);
                    game.Score++;
                }
                // MesseageBox at the end of game, with User and Score
                MessageBox.Show(string.Format("Benutzer: {0}, Punkte {1}", user.Name, game.Score), "Fertig!", MessageBoxButtons.OK);
                // Save game to DB and close Form
                db.addGame(game);
                this.Close();

                parentForm.Show();
            }
            questionNr++;
            // Change question and answer display based on gameMode
            switch (gameMode)
            {
                case 1:
                    generateQuestionAndAnswerMode1(questionNr);
                    break;
                case 2:
                    generateQuestionAndAnswerMode2(questionNr);
                    break;
                case 3:
                    generateQuestionAndAnswerMode3(questionNr);
                    break;
                case 4:
                    generateQuestionAndAnswerMode4(questionNr);
                    break;
                case 5:
                    generateQuestionAndAnswerMode5(questionNr);
                    break;
                case 6:
                    generateQuestionAndAnswerMode6(questionNr);
                    break;
            }

            
        }
        #endregion
    }
}
