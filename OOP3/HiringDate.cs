namespace OOP3
{
    public class HirringDate
    {
      
        #region Attributes
        private int day;
        private int month;
        private int year;

        #endregion

        #region Constructor

        public HirringDate()
        {

        }
        public HirringDate(int _day, int _month, int _year)
        {
            Day = _day;
            Month = _month;
            Year = _year;
        }

        #endregion

        #region Properties
        public int Year
        {
            get { return year; }
            set { year = value >= 2000 && value <= DateTime.Now.Year ? value : 2015; }
        }


        public int Month
        {
            get { return month; }
            set { month = value > 0 && value <= 12 ? value : 1; }
        }


        public int Day
        {
            get { return day; }
            set { day = value > 0 && value <= 31 ? value : 1; }
        }
        #endregion

        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
