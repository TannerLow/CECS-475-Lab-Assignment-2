using System;
using System.Collections.Generic;
using System.Text;

namespace LabAssignment2
{
    public class IntegerSet
    {
        private const int SETSIZE = 101;
        private bool[] set;

        // parameterless constructor, creates an empty set
        public IntegerSet()
        {
            set = new bool[SETSIZE];
        } // end parameterless constructor

        // constructor creates a set from array of integers
        public IntegerSet(int[] array)
        : this()
        {
            for (int i = 0; i < array.Length; i++)
                InsertElement(array[i]);
        } // end constructor

        // helper method to check if the given position is valid 
        private bool ValidEntry(int position)
        {
            return position < SETSIZE && position >= 0 ? true : false;
        } // end method ValidEntry

        public void InsertElement(int insertInteger)
        {
            if (ValidEntry(insertInteger))
                set[insertInteger] = true;
        } // end method InsertElement

        public void DeleteElement(int deleteInteger)
        {
            if (ValidEntry(deleteInteger))
                set[deleteInteger] = false;
        } // end method DeleteEelement

        public IntegerSet Intersection(IntegerSet integerSet)
        {
            IntegerSet temp = new IntegerSet();

            for (int count = 0; count < SETSIZE; count++)
                temp.set[count] = (set[count] && integerSet.set[count]);

            return temp;
        } // end method Intersection

        public IntegerSet Union(IntegerSet integerSet)
        {
            IntegerSet temp = new IntegerSet();

            for (int count = 0; count < SETSIZE; count++)
                temp.set[count] = (set[count] || integerSet.set[count]);

            return temp;
        } // end method Intersection

        // String of all numbers in the set or "---" or an empty set
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < SETSIZE; i++)
                if (set[i])
                    result += i + " ";

            if (result.Length < 1)
                return "---";

            return result;
        } // end method toString

        public bool IsEqualTo(IntegerSet integerSet)
        {
            for (int i = 0; i < SETSIZE; i++)
                if (set[i] != integerSet.set[i])
                    return false;

            return true;
        } // end method IsEqualTo
    }
}
