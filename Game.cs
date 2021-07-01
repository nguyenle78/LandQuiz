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
            this.score = score;
            this.userID = userID;
            this.date = date;
        }
    }
}
