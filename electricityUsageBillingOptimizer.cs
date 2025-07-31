using System;
using System.Collections.Generic;

public class UsageRecord
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public double PowerKW { get; set; }
}

public class ElectricityUsageBillingOptimizer
{
    // Rates
    private const double OffPeakRate = 0.10;
    private const double PeakRate = 0.20;

    // Off-Peak: 10:00 PM - 6:00 AM
    private static readonly TimeSpan OffPeakStart = new TimeSpan(22, 0, 0); // 10:00 PM
    private static readonly TimeSpan OffPeakEnd = new TimeSpan(6, 0, 0);    // 6:00 AM

    private enum PeriodType { OffPeak, Peak }

    private static PeriodType GetPeriodType(TimeSpan time)
    {
        // Off-Peak: 10:00 PM - 6:00 AM
        if (time >= OffPeakStart || time < OffPeakEnd)
            return PeriodType.OffPeak;
        return PeriodType.Peak;
    }

    private static DateTime GetPeriodEnd(DateTime current, DateTime usageEnd, PeriodType periodType)
    {
        DateTime periodEnd;
        DateTime day = current.Date;

        // Determine the end of the current period based on the type
        if (periodType == PeriodType.OffPeak)
        {
            // If current time is in Off-Peak, find the next Off-Peak end by checking the next day
            DateTime nextOffPeakEnd = day.Add(OffPeakEnd); 
            if (current.TimeOfDay >= OffPeakStart)
                nextOffPeakEnd = nextOffPeakEnd.AddDays(1); //

            periodEnd = nextOffPeakEnd < usageEnd ? nextOffPeakEnd : usageEnd;
        }
        else
        {
            DateTime peakEnd = day.Add(OffPeakStart);
            periodEnd = peakEnd < usageEnd ? peakEnd : usageEnd;
        }
        return periodEnd;
    }
    
    private static double CalculateCostForRecord(UsageRecord record)
    {
        double cost = 0.0;
        DateTime current = record.StartTime;
        while (current < record.EndTime)
        {
            var periodType = GetPeriodType(current.TimeOfDay);
            DateTime periodEnd = GetPeriodEnd(current, record.EndTime, periodType);

            double hours = (periodEnd - current).TotalHours;
            double rate = periodType == PeriodType.OffPeak ? OffPeakRate : PeakRate;
            cost += hours * record.PowerKW * rate;

            current = periodEnd;
        }
        return cost;
    }

    public static double CalculateTotalCost(List<UsageRecord> records)
    {
        double totalCost = 0.0;
        foreach (var record in records)
        {
            totalCost += CalculateCostForRecord(record);
        }
        return totalCost;
    }
   
}