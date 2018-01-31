using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Controllers.CsvParser;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        CsvReader reader = new CsvReader();
        string filePath = "D:\\work\\web\\_jira-software-API\\ESS - Empty SynergyCode (Ortec1).csv";
        //public List<Models.Issue> ReadTheEntireFile(string line)
        List<Models.Issue> issuesList = new List<Models.Issue>();

        [HttpGet]
        [Route("issues")]
        public List<Models.Issue> getAllIssues() {
            return reader.ReadAllIssuesFromFile(filePath);
        }

        [HttpPut]
        [Route("update")]
        public Models.Issue updateIssue(Models.Issue issueToUpdate)
        {
            //operations
            return issueToUpdate;
        }

    }
}
