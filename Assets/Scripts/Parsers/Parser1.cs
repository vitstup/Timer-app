using System;

public class Parser1 : TimeParser
{
    public override DateTime GetTime()
    {
        return Parse("https://www.timeanddate.com/worldclock/russia/moscow", '>', '<');
    }
}