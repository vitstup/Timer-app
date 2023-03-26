using System;
using System.Net;

public abstract class TimeParser 
{
    public abstract DateTime GetTime();

    protected DateTime Parse(string path, char startChar, char endChar)
    {
        WebClient client = new WebClient();
        string html = client.DownloadString(path);

        string[] parts = html.Split(startChar, endChar);

        foreach (string part in parts)
        {
            if (part.Length > 0 && Char.IsDigit(part[0]))
            {
                if (DateTime.TryParse(part, out DateTime dateTime)) return dateTime;
            }
        }
        throw new Exception("Parser not found time");
    }
}