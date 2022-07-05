using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NguyenLe_QuizProject
{
    public partial class Einstellung : Form
    {
        private Database database = new Database();
        private List<User> users;
        private List<Statistic> statistics;

        public Einstellung()
        {
            InitializeComponent();
            showUser();
            // Default selection user. 
            comboBoxContinent.SelectedIndex = 0;
            // Default selection mode is all Continent
            comboBoxUser.SelectedIndex = 0;
        }

        private void showStatistic()
        {
            dataGridView1.Rows.Clear();
            statistics = database.getStatistic();
            foreach (Statistic statistic in statistics)
            {
                if (statistic.User == comboBoxUser.Text || radioButton7.Checked)
                {

                    dataGridView1.Rows.Add(statistic.User, statistic.Score, statistic.Datum);
                }
            }
        }

        private void showUser()
        {

            users = database.getUser();
            comboBoxUser.Items.Clear();
            foreach (User user in users)
            {
                comboBoxUser.Items.Add(user.Name);
            }
        }

        private void buttonNeuUser_Click(object sender, EventArgs e)
        {
            // Prevent enter empty name User
            if (textBoxNewUser.Text != "")
            {
                try
                {
                    User newUser = new User(textBoxNewUser.Text);
                    database.addNewUser(newUser);
                    MessageBox.Show("Neu Spieler hinzugefügt", "Neu Spieler", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    showUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int gameMode;
            if (radioButton1.Checked)
            {
                gameMode = 1;
            }
            else if (radioButton2.Checked)
            {
                gameMode = 2;
            }
            else if (radioButton3.Checked)
            {
                gameMode = 3;
            }
            else if (radioButton4.Checked)
            {
                gameMode = 4;
            }
            else if (radioButton5.Checked)
            {
                gameMode = 5;
            }
            else
                gameMode = 6;
            int continent;

            continent = comboBoxContinent.SelectedIndex;

            User user = users[comboBoxUser.SelectedIndex];
            HauptStad_Land newGame = new HauptStad_Land(user, this, gameMode, continent);

            this.Hide();
            newGame.Show();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            showStatistic();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            showStatistic();
        }
    }
}