# Mindbus.Constants.Time
A Set of commonly used Time constants

== Constants

This project allows you to use the defined contants like this `Time.InSeconds.OneHour`.
This is particularly usefull to set up values on Attributes.

    [CacheOutput(ServerTimeSpan = Time.InSeconds.OneHour)]

Or where a constant value is neded, like in default paramters

	public void AddSeconds(int value = Time.InSeconds.OneHour)

== Extensions

This project also extends the core type `int` to allow a Fluent usage, for exemple:

    5.Hours().InMinutes();

It is also possible to convert to the opposite and specify a approximation method

	Assert.Equal(2, (int)120.Minutes().InHours());
    Assert.Equal(2, (int)125.Minutes().InHours(ApproximationType.Floor));
