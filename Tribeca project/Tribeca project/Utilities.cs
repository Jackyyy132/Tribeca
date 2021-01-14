using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Tribeca_project
{
    class Utilities
    {
        private static BindingFlags _privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;
        public static T GetPersonsName<O, T>(Person p, string name)
        {
            return (T)typeof(Person).GetField(p.Name, _privateFlags)?.GetValue(p);
        }

        //https://www.youtube.com/watch?v=qXDzDEffbZk - Video reference
    }
}
