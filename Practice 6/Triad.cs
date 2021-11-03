using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    class Triad
    {
        public Triad(int first = 1, int second = 1, int third = 1)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public int First { get; private set; }
        public int Second { get; private set; }
        public int Third { get; private set; }

        public static Triad operator +(Triad triad, int summand = 1)
        {
            return new Triad(
                triad.First + summand,
                triad.Second + summand,
                triad.Third + summand);
        }

        public static Triad operator +(Triad firsttriad, Triad secondtriad)
        {
            return new Triad(
                firsttriad.First + secondtriad.First,
                firsttriad.Second + secondtriad.Second,
                firsttriad.Third + secondtriad.Third);

        }

        public Triad Multiply(int multiplier = 2)
        {
            return new Triad(First * multiplier, Second * multiplier, Third * multiplier);
        }

        public bool AreEqual() => First == Second && Second == Third;
    }
}
