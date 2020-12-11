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
    List<Dictionary<string, string>> passports = GetPassports(input);
    int result = CheckPassports(passports, true);

    return result;
}

int CheckPassports(List<Dictionary<string, string>> passports, bool explicitly = false)
{
    int result = 0;

    foreach (Dictionary<string, string> passport in passports)
        result += CheckPassport(passport, explicitly);

    return result;
}

int CheckPassport(Dictionary<string, string> passport, bool explicitly = false)
{
    passport.Remove("cid");

    if (!explicitly)
        if (passport.Keys.Count == 7)
            return 1;
        else
            return 0;

    foreach (string key in passport.Keys)
        if(!IsValid(key, passport[key]))
            return 0;

    return 1;
}

bool IsValid(string field, string value)
{
    int parsedInt;
    switch (field)
    {
        case "byr":
            return (value.Length == 4 && int.TryParse(value, out parsedInt) && parsedInt >= 1920 && parsedInt <= 2002);
        case "iyr":
            return (value.Length == 4 && int.TryParse(value, out parsedInt) && parsedInt >= 2010 && parsedInt <= 2020);
        case "eyr":
            return (value.Length == 4 && int.TryParse(value, out parsedInt) && parsedInt >= 2020 && parsedInt <= 2030);
        case "hgt":
            return ((value.EndsWith("cm") && int.TryParse(value.Replace("cm", ""), out parsedInt) && parsedInt >= 150 && parsedInt <= 193) ||
                    (value.EndsWith("in") && int.TryParse(value.Replace("cm", ""), out parsedInt) && parsedInt >= 59 && parsedInt <= 76));
        case "hcl":
            return (System.Text.RegularExpressions.Regex.IsMatch(value, @"\A\b[0-9a-fA-F]+\b\Z"));
        case "ecl":
            return ("amb-blu-brn-gry-grn-hzl-oth".Contains(value));
        case "pid":
            return (value.Length == 9 && int.TryParse(value, out parsedInt));
        default:
            return false;
    }
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