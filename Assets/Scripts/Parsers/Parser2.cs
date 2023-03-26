using System;

public class Parser2 : TimeParser
{
    public override DateTime GetTime()
    {
        return Parse("https://bilet.pp.ru/calculator/exact_current_local_moscow_time_and_date_time_zone.php", '(', ')');
    }
}