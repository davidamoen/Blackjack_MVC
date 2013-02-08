using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackLibrary
{
    public static class Extensions
    {

        public static T Pop<T>(this List<T> theList)
        {
            var local = theList[0];

            theList.RemoveAt(0);

            return local;

        }

    }
}
