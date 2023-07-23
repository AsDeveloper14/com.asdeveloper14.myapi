using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


 
 public static class DeltaTime
    {

    
    public static double CurrentTimeToMillisecond()
    {

     DateTime epochStart = new DateTime(1970, 1, 1);
     TimeSpan timeSpan = DateTime.UtcNow - epochStart;

     return timeSpan.TotalMilliseconds;
      
    }
      
    public static int CurrentTime(string mode)
    {

        DateTime current = DateTime.Now;
        int x = 0;

        if(mode=="second")   x = current.Second;
        else if (mode == "minute") x = current.Minute;
        else if (mode == "hour") x = current.Hour;
        else if (mode == "day") x = current.Day;
        else if (mode == "millisecond") x = current.Millisecond;

        return x;

    }

    public static double ElapsedTime(double millisecond,string mode)
    {
        TimeSpan time = TimeSpan.FromMilliseconds(millisecond);
        DateTime startDate = (new DateTime(1970, 1, 1) + time);
        DateTime endDate = DateTime.UtcNow;

        double elapsed = 0;


        if (mode == "second") elapsed = (endDate - startDate).TotalSeconds;
        else if (mode == "minute") elapsed = (endDate - startDate).TotalMinutes;
        else if (mode == "hour") elapsed = (endDate - startDate).TotalHours;
        else if (mode == "day") elapsed = (endDate - startDate).TotalDays;
        else if (mode == "millisecond") elapsed = (endDate - startDate).TotalMilliseconds;

        return elapsed;

    }


    public static double MillisecondToTime(double millisecond, string mode)
    {
        TimeSpan time = TimeSpan.FromMilliseconds(millisecond);
        DateTime startDate = (new DateTime(1970, 1, 1) + time);

        double converted = 0;

        if (mode == "second") converted = startDate.Second;
        else if (mode == "minute") converted = time.Minutes;
        else if (mode == "hour") converted = time.Hours;
        else if (mode == "day") converted = time.Days;

        return converted;

    }

}

