using System;

namespace NguyenLe_QuizProject
{
    public class Game
    {
        private int gameID;
        private int score;
        private int userID;
        private DateTime date;

        public Game(int score, int userID, DateTime date)
        {
            this.Score = score;
            this.UserID = userID;
            this.Date = date;
        }

        public int GameID { get => gameID; set => gameID = value; }
        public int Score { get => score; set => score = value; }
        public int UserID { get => userID; set => userID = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
