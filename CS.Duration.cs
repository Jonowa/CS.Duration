using System;
using System.Xml;

/// <summary>
/// This class contains some helpful funktions to convert
/// an ISO 8601 duration pattern into a timespan. Optionally
/// the timespan can added to a date value.
/// </summary>
public class Duration : XmlConvert
{
    /// <summary>
    /// Date value of this instance.
    /// </summary>
    public DateTime Value {
        get => _value;
    }
    private DateTime _value = DateTime.Now;

    /// <summary>
    /// Creates a new instance with the current date.
    /// </summary>
    public Duration() : this(DateTime.Now)
    {
    }

    /// <summary>
    /// Creates a new instance with a given date.
    /// </summary>
    /// <param name="date">DateTime object</param>
    public Duration(DateTime date)
    {
        _value = date;
    }

    /// <summary>
    /// Converts the duration pattern into a timespan and add it to
    /// the date value of this instance.
    /// </summary>
    /// <param name="pattern">ISO 8601 duration pattern</param>
    /// <returns>DateTime object</returns>
    public DateTime Add(string pattern)
    {
        return _value.Add(Parse(pattern));
    }

    /// <summary>
    /// Converts the duration pattern into a timespan and returns it.
    /// </summary>
    /// <param name="pattern">ISO 8601 duration pattern</param>
    /// <returns>TimeSpan object</returns>
    public static TimeSpan Parse(string pattern)
    {
        return ToTimeSpan(pattern);
    }
}
