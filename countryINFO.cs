using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // دیکشنری کشور و پایتخت
        Dictionary<string, string> capitals = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"Iran", "Tehran"},
            {"United States", "Washington, D.C."},
            {"France", "Paris"},
            {"Germany", "Berlin"},
            {"Italy", "Rome"},
            {"Spain", "Madrid"},
            {"Canada", "Ottawa"},
            {"Australia", "Canberra"},
            {"Brazil", "Brasília"},
            {"Argentina", "Buenos Aires"},
            {"Russia", "Moscow"},
            {"China", "Beijing"},
            {"Japan", "Tokyo"},
            {"South Korea", "Seoul"},
            {"India", "New Delhi"},
            {"Mexico", "Mexico City"},
            {"Egypt", "Cairo"},
            {"Turkey", "Ankara"},
            {"Saudi Arabia", "Riyadh"},
            {"South Africa", "Pretoria"},
            {"United Kingdom", "London"},
            {"Netherlands", "Amsterdam"},
            {"Sweden", "Stockholm"},
            {"Norway", "Oslo"},
            {"Denmark", "Copenhagen"},
            {"Finland", "Helsinki"},
            {"Belgium", "Brussels"},
            {"Portugal", "Lisbon"},
            {"Greece", "Athens"},
            {"Poland", "Warsaw"},
            {"Czech Republic", "Prague"},
            {"Hungary", "Budapest"},
            {"New Zealand", "Wellington"},
            {"Chile", "Santiago"},
            {"Colombia", "Bogotá"},
            {"Peru", "Lima"},
            {"Venezuela", "Caracas"},
            {"Thailand", "Bangkok"},
            {"Vietnam", "Hanoi"},
            {"Malaysia", "Kuala Lumpur"},
            {"Singapore", "Singapore"},
            {"Indonesia", "Jakarta"},
            {"Philippines", "Manila"},
            {"Ukraine", "Kyiv"},
            {"Ireland", "Dublin"},
            {"Switzerland", "Bern"},
            {"Austria", "Vienna"},
            {"Israel", "Jerusalem"},
            {"Jordan", "Amman"},
            {"Morocco", "Rabat"},
            {"Iraq", "Baghdad"},
            {"Libya", "Tripoli"}
        };

        Console.WriteLine("نام کشور را وارد کنید تا پایتخت آن را دریافت کنید:");
        string country = Console.ReadLine();

        if (capitals.TryGetValue(country, out string capital))
        {
            Console.WriteLine($"پایتخت {country}، {capital} است.");
        }
        else
        {
            Console.WriteLine("کشور یافت نشد.");
        }
    }
}