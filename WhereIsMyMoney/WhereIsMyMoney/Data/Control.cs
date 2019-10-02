using System;
using System.Collections.Generic;

namespace WhereIsMyMoney.Data
{
    public static class Control
    {
        private static List<Person> people;

        public static List<Person> GetPeople()
        {
            if (people == null)
            {
                people = new List<Person>();
            }
            return people;
        }
    }
}