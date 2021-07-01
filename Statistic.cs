namespace NguyenLe_QuizProject
{
    public class Statistic
    {
        private string user;
        private int score;
        private string datum;

        public Statistic(string user, int score, string datum)
        {
            this.user = user;
            this.score = score;
            this.datum = datum;
        }

        public string User { get => user; set => user = value; }
        public int Score { get => score; set => score = value; }
        public string Datum { get => datum; set => datum = value; }
    }
}
