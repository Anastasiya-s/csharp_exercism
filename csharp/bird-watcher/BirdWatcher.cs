using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        bool hasDayWithoutBirds = false;
        foreach (var count in birdsPerDay)
        {
            if (count == 0)
            {
                hasDayWithoutBirds = true;
                break;
            }
        }
        return hasDayWithoutBirds;

    }

    public int CountForFirstDays(int numberOfDays)
    {
        int counter = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            counter += birdsPerDay[i];
        }
        return counter;
    }

    public int BusyDays()
    {
        int count = 0;
        foreach (var birds in birdsPerDay)
        {
            if (birds >= 5)
            count++;
        }
        return count;
    }
}
