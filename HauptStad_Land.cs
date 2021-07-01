using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NguyenLe_QuizProject
{
    public partial class HauptStad_Land : Form
    {
        private int questionNr = 0;

        private Einstellung parentForm;
        private Game game;
        private User user;
        private Database db = new Database();
        private List<Land> lands;
        private Dictionary<string, string> correctAnswer = new Dictionary<string, string>();
        private RadioButton[] answers = new RadioButton[4];

        private int numberOfQuestion;

        public HauptStad_Land(User user, Einstellung parentForm, int numberOfQuestion)
        {
            this.numberOfQuestion = numberOfQuestion;
            this.parentForm = parentForm;
            this.user = user;
            this.game = new Game(0, user.UserID, System.DateTime.Now);
            InitializeComponent();

            labelUser.Text = string.Format("Wilkommen, {0}, bitte folgende Fragen beanworten.", user.Name);

            //Assign each radioButton to the coresponding index in Array
            answers[0] = radioButton1;
            answers[1] = radioButton2;
            answers[2] = radioButton3;
            answers[3] = radioButton4;
            getLands();
            generateQuestionAndAnswer(correctAnswer);
        }
        private void getLands()
        {
            lands = db.getListLand();
            for (int i = 0; i < numberOfQuestion; i++)
            {
                correctAnswer.Add(lands[i].Name, lands[i].Capital);
            }
        }
        private void generateQuestionAndAnswer(Dictionary<string, string> correctAnswer)
        {
            // Nur wen es gibt noch was zum fragen bzw. antworten
            if (questionNr <= numberOfQuestion)
            {
                if (numberOfQuestion - questionNr == 1)
                {
                    buttonNext.Text = "Ende";
                }
                Random random = new Random();
                // Random type der Frage: Haupstadt -> Land oder Land -> Haupstadt

                int landOrCapital = random.Next(2);
                if (landOrCapital == 0)
                {
                    labelFrage.Text = string.Format("Das Land mit der Hauptstadt {0} ist:", correctAnswer.ElementAt(questionNr).Value); //Import System.Linq
                                                                                                                                        // assign correct answer to radioButton1
                    radioButton1.Text = correctAnswer.ElementAt(questionNr).Key;

                    List<int> listIndex = new List<int>();
                    listIndex.Add(questionNr);

                    int index;


                    for (int i = 1; i < 4; i++)
                    {
                        do
                        {
                            index = random.Next(lands.Count);
                        } while (listIndex.Contains(index));
                        listIndex.Add(index);
                    }


                    for (int i = 1; i < answers.Length; i++)
                    {
                        answers[i].Text = lands[listIndex[i]].Name;
                    }

                }
                else
                {
                    labelFrage.Text = string.Format("Die Haupstadt von {0} ist:", correctAnswer.ElementAt(questionNr).Key);
                    // antwort generiert, in radiobutton
                    radioButton1.Text = correctAnswer.ElementAt(questionNr).Value;

                    List<int> listIndex = new List<int>();
                    listIndex.Add(questionNr);

                    int index;

                    for (int i = 1; i < 4; i++)
                    {
                        do
                        {
                            index = random.Next(lands.Count);
                        } while (listIndex.Contains(index));
                        listIndex.Add(index);
                    }


                    for (int i = 1; i < answers.Length; i++)
                    {
                        answers[i].Text = lands[listIndex[i]].Capital;
                    }

                }
            }


            shuffleAnswer(answers);  // antwort generiert, in radi
        }

        private bool isRepeat(int[] index)
        {
            bool result = false;
            for (int i = 0; i < index.Length; i++)
            {
                for (int j = 1 + 1; j < index.Length; j++)
                {
                    if (index[i] == index[j])
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        private void shuffleAnswer(RadioButton[] answers)
        {
            Random random = new Random();
            Point temp = new Point();

            for (int i = 0; i < 4; i++)
            {
                temp = answers[i].Location;
                int randomIndex = random.Next(4);
                answers[i].Location = answers[randomIndex].Location;
                answers[randomIndex].Location = temp;
            }
        }

        private void buttonZumEinstellung_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // reset radioButton text
            if (radioButton1.Checked)
                MessageBox.Show("richtig", "Gut", MessageBoxButtons.OK);
            foreach (RadioButton button in answers)
            {
                button.Text = "";
            }
            Array.Clear(answers, 0, answers.Length);
            answers[0] = radioButton1;
            answers[1] = radioButton2;
            answers[2] = radioButton3;
            answers[3] = radioButton4;
            foreach (var item in answers)
            {
                item.TabStop = false;
                item.Checked = false;

            }
            generateQuestionAndAnswer(correctAnswer);
            questionNr++;
        }
    }
}


