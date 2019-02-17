using System;
using System.Collections.Generic;
using System.Linq;

public class SprintTraining
{
    public int GetMostVisited(int markerCount, int[] sprints)
    {
        int[] totalVisits = new int[n];

        for (int j = 0; j < sprints.Count - 1; j++)
        {
            if (sprints[j] < sprints[j + 1])
                for (int k = sprints[j]; k <= sprints[j + 1]; k++)
                    totalVisits[k - 1] += 1;

            else if (sprints[j] > sprints[j + 1])
                for (int k = sprints[j]; k >= sprints[j + 1]; k--)
                    totalVisits[k - 1] += 1;
        }

        return Array.IndexOf(totalVisits, totalVisits.Max()) + 1;
    }
}
