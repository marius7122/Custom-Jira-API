using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Issue
    {
        public string IssueType { get; set; }
        public string Key { get; set; }
        public string Sumary { get; set; }
        public string Assignee { get; set; }
        public string Owner { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public string Remaining_Estimate { get; set; }
        public string TimeSpent { get; set; }
        public string OriginalEstimate { get; set; }
        public string WorkRatio { get; set; }
        public string FixVersion { get; set; }
        public string Developer { get; set; }
        public string EpicName { get; set; }
        public string EpicLink { get; set; }
        public int LeadTime { get; set; }
    }
}