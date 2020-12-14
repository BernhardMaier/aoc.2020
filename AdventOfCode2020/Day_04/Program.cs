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
    switch (field)
    {
        case "byr":
            return CheckYear(value, 1920, 2002);
        case "iyr":
            return CheckYear(value, 2010, 2020);
        case "eyr":
            return CheckYear(value, 2020, 2030);
        case "hgt":
            return CheckHeight(value);
        case "hcl":
            return CheckHairColor(value);
        case "ecl":
            return CheckEyeColor(value);
        case "pid":
            return CheckPid(value);
        default:
            return false;
    }
}

bool CheckYear(string value, int min, int max)
{
    bool valid;
    valid = value.Length == 4 && int.TryParse(value, out int parsedInt) && parsedInt >= min && parsedInt <= max;
    return valid;
}

bool CheckHeight(string value)
{
    bool valid = false;

    if (value.EndsWith("cm"))
        valid = int.TryParse(value.Replace("cm", ""), out int parsedInt) && parsedInt >= 150 && parsedInt <= 193;

    if (value.EndsWith("in"))
        valid = int.TryParse(value.Replace("in", ""), out int parsedInt) && parsedInt >= 59 && parsedInt <= 76;

    return valid;
}

bool CheckHairColor(string value)
{
    bool valid;
    valid = System.Text.RegularExpressions.Regex.IsMatch(value, @"#[0-9a-fA-F]{6}");
    return valid;
}

bool CheckEyeColor(string value)
{
    bool valid;
    valid = "|amb|blu|brn|gry|grn|hzl|oth|".Contains(value);
    return valid;
}

bool CheckPid(string value)
{
    bool valid;
    valid = value.Length == 9 && int.TryParse(value, out int parsedInt);
    return valid;
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