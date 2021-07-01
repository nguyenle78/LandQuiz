﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NguyenLe_QuizProject
{
    public partial class Einstellung : Form
    {
        private Database database = new Database();
        private List<User> users;
        private List<Land> lands;
        public Einstellung()
        {
            InitializeComponent();
            showUser();
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
            int numberOfQuestion = Convert.ToInt32(textBoxNumberOfQuestion.Text);
            User user = users[comboBoxUser.SelectedIndex];
            HauptStad_Land newGame = new HauptStad_Land(user, this, numberOfQuestion);
            // hier werden später mit Spiel Modus wahlbar
            this.Hide();
            newGame.Show();
        }
    }
}