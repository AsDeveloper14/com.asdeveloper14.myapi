using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public static class MyLinq
{

    public static void SelectSomeItems(this IList ils, IList itemsList, int count)
    {
        IList backupList = new List<object>();
        backupList.Casting(itemsList);
        ils.Clear();

        for (int i = 0; i < count; i++)
        {
            int r = UnityEngine.Random.Range(0, backupList.Count);
            ils.Add(backupList[r]);
            backupList.RemoveAt(r);
        }
    }

    public static List<int> CreateNumericList(int min, int max)
    {
        List<int> ls = new List<int>();

        for (int i = min; i < max; i++)
        {
            ls.Add(i);
        }
        return ls;
    }

    public static bool EqualInRow(this IList ils1, IList ils2)
    {

        if (ils1.Count != ils2.Count)
            return false;

        else
        {
            for (int i = 0; i < ils1.Count; i++)
            {
                if (!ils1[i].Equals(ils2[i]))
                    return false;

            }
        }

        return true;
    }

    public static bool Equal(this IList ils1, IList ils2)
    {
        bool isEqual = true;
        bool b = false;

        IList backupList = new List<object>();
        backupList.Casting(ils2);

        if (ils1.Count != backupList.Count) isEqual = false;



        for (int i = 0; i < ils1.Count; i++)
        {
            b = false;
            for (int j = 0; j < backupList.Count; j++)
            {
                if (ils1[i].ToString()==backupList[j].ToString())
                {
                    backupList.RemoveAt(j);
                    b = true;
                    break;
                }
            }

            if (!b)
                break;
        }

        if (!b) isEqual = false;


        return isEqual;
    }

    public static bool AreAllItemsEqual(this IList ils)
    {
        bool b = true;

        var item = ils[0];

        foreach (var o in ils)
        {
            if (!o.Equals(item))
            {
                b = false;
                break;
            }
        }

        return b;
    }

    public static IList Unsort(this IList ils)
    {
        IList backupList = new List<object>();
        backupList.Casting(ils);
        ils.Clear();

        int count = backupList.Count;

        for (int i = 0; i < count; i++)
        {
            int r = UnityEngine.Random.Range(0, backupList.Count);
            ils.Add(backupList[r]);
            backupList.RemoveAt(r);
        }

        return ils;
    }

    public static void RemoveDuplicates<T>(this IList<T> list)
    {
        HashSet<T> hashset = new HashSet<T>(list);
        list.Clear();
        foreach (var item in hashset)
        {
            list.Add(item);
        }
    }

    public static IList Casting(this IList ils, IList targetIls)
    {
        ils.Clear();

        foreach (object i in targetIls)
        {
            ils.Add(i);
        }
        return ils;
    }

    public static double DoOperation(this IList ils, string operation)
    {
        double d = Convert.ToDouble(ils[0]);

        for (int i = 1; i < ils.Count; i++)
        {
            double dd = Convert.ToDouble(ils[i]);
            if (operation == "+") d += dd;
            else if (operation == "-") d -= dd;
            else if (operation == "*") d *= dd;
            else if (operation == "/") d /= dd;

        }

        return d;
    }

    public static void AddItems(this IList ils, int count, object value)
    {
        ils.Clear();

        for (int i = 0; i < count; i++)
        {
            ils.Add(value);
        }

    }

    public static void RepeatedItemsCount(this IList ils, ref List<double> values, object obj, double value)
    {
        int j = ils.IndexOf(obj);

        if (j > -1)
            values[j] += value;
        else
        {
            ils.Add(obj);
            values.Add(value);
        }
    }

    public static int CountSpecialValue(this IList ils, object obj)
    {
        int x = 0;

        for(int i = 0; i < ils.Count; i++)
            if (ils[i] == obj) x++;
        return x;
    }


    public static int GetBiggestIndex (this IList ils)
    {

        IList list = new List<object>();
        list.Casting(ils);
        ils.Clear();

        int index = 0;
        double value = double.Parse(list[0].ToString());

        for (int i = 1; i < list.Count; i++)
        {
            double d = double.Parse(list[i].ToString());
            if (d > value)
            {
                index = i;
                value = d;
            }          
        }

        return index;
    }

    public static int GetSmallestIndex(this IList ils)
    {

        IList list = new List<double>();
        list.Casting(ils);
        ils.Clear();

        int index = 0;
        double value = (double)list[0];

        for (int i = 1; i < list.Count; i++)
        {
            double d = (double)list[i];
            if (d < value)
            {
                index = i;
                value = d;
            }
        }

        return index;
    }

    


    #region
    /*
       public static IList RemoveDuplicateItems(this IList ils)
       {
           IList newList = new List<object>();

           for (int i = 0; i < ils.Count; i++)
           {
               if (!newList.Contains(ils[i]))
               {
                   newList.Add(ils[i]);
               }
           }

           ils.Casting(newList);
           return ils;
       }
       */



    #endregion
}





