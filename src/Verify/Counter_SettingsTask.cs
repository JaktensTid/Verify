﻿namespace VerifyTests;

public partial class SettingsTask
{
#if NET6_0_OR_GREATER

    [Pure]
    public SettingsTask AddNamedDate(Date value, string name)
    {
        CurrentSettings.AddNamedDate(value, name);
        return this;
    }

    [Pure]
    public SettingsTask AddNamedTime(Time value, string name)
    {
        CurrentSettings.AddNamedTime(value, name);
        return this;
    }

    [Pure]
    public SettingsTask ReplaceDateComparer(IEqualityComparer<Date> comparer)
    {
        CurrentSettings.ReplaceScrubberDateComparer(comparer);
        return this;
    }

    [Pure]
    public SettingsTask ReplaceTimeComparer(IEqualityComparer<Time> comparer)
    {
        CurrentSettings.ReplaceScrubberTimeComparer(comparer);
        return this;
    }

#endif

    [Pure]
    public SettingsTask AddNamedDateTime(DateTime value, string name)
    {
        CurrentSettings.AddNamedDateTime(value, name);
        return this;
    }

    [Pure]
    public SettingsTask AddNamedDateTimeOffset(DateTimeOffset value, string name)
    {
        CurrentSettings.AddNamedDateTimeOffset(value, name);
        return this;
    }

    [Pure]
    public SettingsTask AddNamedGuid(Guid value, string name)
    {
        CurrentSettings.AddNamedGuid(value, name);
        return this;
    }

    [Pure]
    public SettingsTask ReplaceDateTimeComparer(IEqualityComparer<DateTime> comparer)
    {
        CurrentSettings.ReplaceScrubberDateTimeComparer(comparer);
        return this;
    }

    [Pure]
    public SettingsTask ReplaceGuidComparer(IEqualityComparer<Guid> comparer)
    {
        CurrentSettings.ReplaceScrubberGuidComparer(comparer);
        return this;
    }

    [Pure]
    public SettingsTask ReplaceDateTimeOffsetComparer(IEqualityComparer<DateTimeOffset> comparer)
    {
        CurrentSettings.ReplaceScrubberDateTimeOffsetComparer(comparer);
        return this;
    }
}