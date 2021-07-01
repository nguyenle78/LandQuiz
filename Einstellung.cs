using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NguyenLe_QuizProject
{
    public partial class Einstellung : Form
    {
        private Database database = new Database();
        private List<User> users;
        private List<Land> lands;
        private List<Statistic> statistics;

        public Einstellung()
        {
            InitializeComponent();
            showUser();
            showStatistic();
        }

        private void showStatistic()
        {
            statistics = database.getStatistic();
            foreach (Statistic statistic in statistics)
            {
                dataGridView1.Rows.Add(statistic.User, statistic.Score, statistic.Datum);

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
            {
                gameMode = 6;
            }

            User user = users[comboBoxUser.SelectedIndex];
            HauptStad_Land newGame = new HauptStad_Land(user, this, gameMode);
            // hier werden später mit Spiel Modus wahlbar
            this.Hide();
            newGame.Show();
        }
    }
}