
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int countString = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < countString; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string sentenceMy;

    while(periodLocation != -1)
    {
        sentenceMy = myString.Remove(periodLocation);
        myString = myString.Substring(periodLocation +1);
        myString = myString.TrimStart();
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(sentenceMy);
    }
    sentenceMy = myString.Trim();
    Console.WriteLine(sentenceMy);
}
