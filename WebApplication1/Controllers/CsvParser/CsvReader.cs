using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplication1.Controllers.CsvParser
{
    public class CsvReader
    {
        public List<string> LeadTimes = new List<string>(new string[] { "2d", "4d", "6d", "8d"});
        public CsvReader() { }
        public Models.Issue ParseReadLine(string line)
        {
            var data = line.Split(',');
            Models.Issue newIssue = new Models.Issue();

            newIssue.IssueType = data[0];
            newIssue.Key = data[1];
            newIssue.Sumary = data[2];
            newIssue.Assignee = data[3];
            newIssue.Owner = data[4];
            newIssue.Priority = data[5];
            newIssue.Status = data[6];
            newIssue.Created = data[7];
            newIssue.Updated = data[8];
            newIssue.Remaining_Estimate = data[9];
            newIssue.TimeSpent = data[10];
            newIssue.OriginalEstimate = data[11];
            newIssue.WorkRatio = data[12];
            newIssue.FixVersion = data[13];
            newIssue.Developer = data[14];
            newIssue.EpicName = data[15];
            newIssue.EpicLink = data[16];

            return newIssue;
        }

        //method for reading the file
        public List<Models.Issue> ReadAllIssuesFromFile(string filePath)
        {
            var issuesList = new List<Models.Issue>();
            using (var reader = new StreamReader(filePath))
                //get file from filepath
                //read or skip headers
                while (!reader.EndOfStream)
                {
                    //List<string> readRow = new List<string>(); // ex: data[]
                    //add.issueList (ParseReadLine(string readRow));

                    var line = reader.ReadLine();
                    issuesList.Add(ParseReadLine(line));

                }
                //while not end of file

                //read one row at a time

            return issuesList;
        }

        /*public void setLeadTime(Models.Issue issue)
        {
            if (int.Parse(issue.OriginalEstimate) / 3600 == 8 ) { issue.LeadTime = ""; }  //1day 8h -> lead time = 2day
            if (int.Parse(issue.OriginalEstimate) / 3600 == 12) { issue.LeadTime = ""; }   //1day 4h or 1.5 day 12h lead time = 3day
            if (int.Parse(issue.OriginalEstimate) / 3600 == 24) { issue.LeadTime = ""; }   //3day 24h lead time = 6 day
            if (int.Parse(issue.OriginalEstimate) / 3600 == 32) { issue.LeadTime = ""; }   //4day 32h lead time = 8 day
        }*/
    }
}