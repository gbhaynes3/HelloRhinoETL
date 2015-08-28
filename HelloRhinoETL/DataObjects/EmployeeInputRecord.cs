using System;
using FileHelpers;

namespace HelloRhinoETL.DataObjects
{
    [DelimitedRecord(","), IgnoreFirst]
    public class EmployeeInputRecord
    {
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForRead)]
        public string Name;
        public string LastName { get { return Name.Split(',')[0].Substring(0, Math.Min(Name.Split(',')[0].Length, 20)); } }
        public string FirstName { get { return Name.Split(',')[1].Split(' ')[0].Substring(0, Math.Min(Name.Split(',')[1].Split(' ')[0].Length, 10)); } }
        public string JobTitle;
        public string Title { get { return JobTitle.Substring(0, Math.Min(JobTitle.Length, 30)); } }
        public string AgencyId;
        public string Agency;
        public string HireDate;
        public string AnnualSalary;
        public string GrossPay;
    }
}
