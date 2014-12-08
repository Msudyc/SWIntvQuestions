/*
Given an array of jobs where every job has a deadline and 
associated profit if the job is finished before the deadline. 
It is also given that every job takes single unit of time, so 
the minimum possible deadline for any job is 1. How to maximize
total profit if only one job can be scheduled at a time.

Examples:
Input: Four Jobs with following deadlines and profits
  JobID    Deadline      Profit
    a        4            20   
    b        1            10
    c        1            40  
    d        1            30
Output: Following is maximum profit sequence of jobs
        c, a   

Input:  Five Jobs with following deadlines and profits
   JobID     Deadline     Profit
     a         2           100
     b         1           19
     c         2           27
     d         1           25
     e         3           15
Output: Following is maximum profit sequence of jobs
        c, a, e

A Simple Solution is to generate all subsets of given set of 
jobs and check individual subset for feasibility of jobs in that
subset. Keep track of maximum profit among all feasible subsets. 
The time complexity of this solution is exponential. 

This is a standard Greedy Algorithm problem. Following is algorithm. 
1) Sort all jobs in decreasing order of profit.
2) Initialize the result sequence as first job in sorted jobs.
3) Do following for remaining n-1 jobs
.......a) If the current job can fit in the current result sequence 
          without missing the deadline, add current job to the result.
          Else ignore the current job.
*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public partial class Greedy
    {
        public static List<char> MaxProfit(List<Job> jobs)
        {
            jobs.Sort(Job.Compare);
            int[] sequence = new int[jobs.Count];
            bool[] slot = new bool[jobs.Count];

            for (int i = 0; i < jobs.Count; i++)
            {
                for (int j = Math.Min(jobs.Count, jobs[i].Deadline) - 1; j >= 0; j--)
                {
                    if (slot[j] == false)
                    {
                        sequence[j] = i;
                        slot[j] = true;
                        break;
                    }
                }
            }

            List<char> result = new List<char>();
            for (int i = 0; i < jobs.Count; i++)
                if (slot[i] == true)
                    result.Add(jobs[sequence[i]].JobId);

            return result;
        }
    }

    public class Job
    {
        public Job(char jobid, int deadline, int profit)
        {
            this.JobId = jobid;
            this.Deadline = deadline;
            this.Profit = profit;
        }

        public char JobId { get; set; }
        public int Deadline { get; set; }
        public int Profit { get; set; }
        public static int Compare(Job x, Job y)
        {
            return -(x.Profit - y.Profit);
        }
    }
}