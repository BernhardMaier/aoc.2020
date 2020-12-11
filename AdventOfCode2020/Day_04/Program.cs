using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using static System.Console;

string[] input = GetInput();
string output = $"## The answers for {Assembly.GetCallingAssembly().GetName().Name.Replace('_', ' ')} are {GetAnswer1(input)} and {GetAnswer2(input)} ##";
WriteLine(new string('#', output.Length));
WriteLine(output);
WriteLine(new string('#', output.Length));

/// <summary>
/// Gets the answer for the first question of a day
/// </summary>
/// <returns></returns>
int GetAnswer1(string[] input)
{
    List<Dictionary<string, string>> passports = GetPassports(input);
    int result = CheckPassports(passports);

    return result;
}

/// <summary>
/// Gets the answer for the second question of a day
/// </summary>
/// <returns></returns>
int GetAnswer2(string[] input)
{
    int result = 0;

    //TODO

    return result;
}

void GetAllKeys(List<Dictionary<string, string>> passports)
{
    Dictionary<string, int> keys = new Dictionary<string, int>();
    foreach (Dictionary<string, string> passport in passports)
    {
        foreach (string key in passport.Keys)
        {
            if (keys.ContainsKey(key))
                keys[key] += 1;
            else
                keys[key] = 0;
        }
    }
}

int CheckPassports(List<Dictionary<string, string>> passports)
{
    int result = 0;

    foreach (Dictionary<string, string> passport in passports)
        result += CheckPassport(passport);

    return result;
}

int CheckPassport(Dictionary<string, string> passport)
{
    passport.Remove("cid");
    if (passport.Keys.Count == 7)
        return 1;
    else
        return 0;

    //string[] reqFields = new string[] { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };
    //foreach (string reqField in reqFields)
    //    if (!passport.ContainsKey(reqField))
    //        return 0;

    //return 1;
}

List<Dictionary<string, string>> GetPassports(string[] input)
{
    List<Dictionary<string, string>> passports = new List<Dictionary<string, string>>();
    List<string> passportRelatedLines = new List<string>();

    foreach (string line in input)
        if (string.IsNullOrEmpty(line))
            passports.Add(CreatePassport(passportRelatedLines));
        else
            passportRelatedLines.Add(line);

    if (passportRelatedLines.Count > 0)
        passports.Add(CreatePassport(passportRelatedLines));

    return passports;
}

Dictionary<string, string> CreatePassport(List<string> passportRelatedLines)
{
    Dictionary<string, string> passport = new Dictionary<string, string>();

    foreach (string pair in passportRelatedLines.Aggregate((i, j) => i + " " + j).Split(' '))
    {
        string[] splitted = pair.Split(':');
        passport[splitted[0]] = splitted[1];
    }

    passportRelatedLines.Clear();

    return passport;
}

/// <summary>
/// Provides the input for the current day
/// </summary>
string[] GetInput()
{
    string[] input = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "input.txt"));

    return input;
}