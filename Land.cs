namespace NguyenLe_QuizProject
{
    public class Land
    {
        private int landID;
        private string name;
        private string capital;
        private string continent;
        private string flag;

        public Land(string name, string capital, string continent, string flag)
        {
            this.Name = name;
            this.Capital = capital;
            this.Continent = continent;
            this.Flag = flag;
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
        public string Flag { get => flag; set => flag = value; }
    }
}
