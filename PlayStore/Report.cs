using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStore
{
    public class Report
    {
        public void GenerateReport()
        {
            string data = "Report1,Report2,Report3";
            string[] output= data.Split(',');
            foreach (string line in output)
            {
                Console.WriteLine(line);
            }
        }
        public void GetReport<T>(T report)
        {

        }
        public void Add<T1,T2>(T1 a,T2 b)
        {

        }
        //public void GetReport(string reportName)
        //{

        //}
        //public void GetReport(DateTime reportDate)
        //{

        //}
    }
}
