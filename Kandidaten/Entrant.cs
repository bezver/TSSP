using System;
using System.Collections.Generic;
using System.Text;

namespace Kandidaten
{
    public class Entrant
    {
        public string firstName   { get; private set; }
        public string secondName  { get; private set; }
        public double averageMark { get; private set; }
        public uint school        { get; private set; }

        public Entrant(string firstName_, string secondName_, double averageMark_, uint school_) {
            firstName   = firstName_;
            secondName  = secondName_;
            averageMark = averageMark_;
            school      = school_;
        }

        public override string ToString()
        {
            return String.Format($"{firstName} {secondName}, середній бал: {averageMark}, школа: {school}");
        }

    }
}
