using System.Collections.Generic;

namespace Cities.Comparers
{
    public class CompoundComparer : IComparer<City>
    {
        public IList<IComparer<City>> Comparers = new List<IComparer<City>>();

        public int Compare(City x, City y)
        {
            int c = 0;
            IComparer<City> comparer = Comparers[c];

            while (comparer.Compare(x,y)==0 && c<Comparers.Count-1)
            {
                c++;
                comparer = Comparers[c];
            }

            return comparer.Compare(x, y);
        }
    }
}
