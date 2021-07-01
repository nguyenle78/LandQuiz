using System.Drawing;

namespace NguyenLe_QuizProject
{
    public class Land
    {
        private int landID;
        private string name;
        private string capital;
        private string continent;
        private Bitmap flag;

        public Land(string name, string capital, string continent)
        {
            this.Name = name;
            this.Capital = capital;
            this.Continent = continent;
        }

        public Land(int landID, string name, string capital, string continent)
        {
            this.landID = landID;
            this.name = name;
            this.capital = capital;
            this.continent = continent;
        }

        public string Name { get => name; set => name = value; }
        public string Capital { get => capital; set => capital = value; }
        public string Continent { get => continent; set => continent = value; }
        public Bitmap Flag { get => flag; set => flag = value; }
    }
}
