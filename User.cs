namespace NguyenLe_QuizProject
{
    public class User
    {
        private int userID;
        private string name;
        private string password;

        public User(string name) // Einache method um neu User zu generieren
        {
            this.name = name;
        }

        public User(int userID, string name) //Overload method, um ID und username von DB zu ziehen
        {
            this.userID = userID;
            this.name = name;
        }


        public int UserID { get => userID; set => userID = value; }
        public string Name { get => name; set => name = value; }
    }
}
