# CS.Duration

This class contains some helpful funktions to convert an ISO 8601 duration pattern into a timespan. Optionally the timespan can added to a date value.

## Eamples

The basic usage is similar to `System.Xml.XmlConvert.ToTimeSpan(string s)`:
```
TimeSpan ts = Duration.Parse("PT2H30M");
// ts = {02:30:00}

TimeSpan ts = Duration.Parse("-PT2H30M");
// ts = {-02:30:00}
```

You can also add a pattern to a datetime value. Try this:
```
DateTime dt = new Duration(new DateTime(2022, 09, 07)).Add("PT2H30M");
// dt = {2022-09-07 02:30:00}

DateTime dt = new Duration(new DateTime(2022, 09, 07)).Add("-PT2H30M");
// dt = {2022-09-06 21:30:00}
```

