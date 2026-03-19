using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.IO.Pipelines;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        string Party = AnnounceParty("Beach", 5, "Hossam", "Jackson", "Ibrahim", "Philip");
        Console.WriteLine(Party);

    }
    static string AnnounceParty(string location, int hours, params string[] guests)
    {
       string guestList = "";
       foreach(string guest in guests)
        {
            guestList += guest + ",";
        }
        return $"The party is at {location} at {hours}PM. Guests: {guestList}";
    }
}