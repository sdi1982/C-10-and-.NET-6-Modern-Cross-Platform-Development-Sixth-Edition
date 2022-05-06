﻿namespace Packt.Shared;

public class PersonComparer : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        if (x is null || y is null)
        {
            return 0;
        }
        // Compare the Name Lengths
        int result = x.Name.Length.CompareTo(y.Name.Length);
        // if they are equal
        if (result == 0)
        {
            return x.Name.CompareTo(y.Name);
        }
        else
        {
            return result;
        }
    }
}