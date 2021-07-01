using System.Drawing;

namespace NguyenLe_QuizProject
{
    public class Land
    {
        private int landID;
        private string name;
        private string capital;
        private int continent;
        private Bitmap flag;

        public Land(string name, string capital, int continent)
        {
            this.name = name;
            this.capital = capital;
            this.Continent = continent;
        }

        public Land(int landID, string name, string capital, int continent)
        {
            this.landID = landID;
            this.name = name;
            this.capital = capital;
            this.Continent = continent;
        }

        public string Name { get => name; set => name = value; }
        public string Capital { get => capital; set => capital = value; }

        public Bitmap Flag { get => flag; set => flag = value; }
        public int Continent { get => continent; set => continent = value; }
    }
}
