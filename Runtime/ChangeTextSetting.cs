using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTextSetting
{
    public static string Color(string color, string text) // "#ff0000" or red
    {
        text = Color(0, text.Length, color, text);
        return text;
    }
    public static string Color(int startIndex, int endIndex, string color, string text)
    {
        string newText = "";
        color = color.ToLower();
        List<char> chars = new List<char>();

        foreach (char c in text)
            chars.Add(c);


        for (int i = 0; i < chars.Count; i++)
        {
            if (i == startIndex)
                newText += "<color=" + color + ">";

            newText += chars[i].ToString();

            if (i == endIndex-1)
                newText += "</color>";
        }

        return newText;
    }

    public static string Underline(string text)
    {
        text = "<u>" + text + "</u>";
        return text;
    }

}
