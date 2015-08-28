using System.Configuration;
using HelloRhinoETL.Operations;
using Rhino.Etl.Core;
using Rhino.Etl.Core.Operations;


namespace HelloRhinoETL
{
    public class MainProcess:EtlProcess
    {
        protected override void Initialize()
        {
            Register(new EmployeeRead(ConfigurationManager.AppSettings["InputFilePath"]));
            Register(new BranchingOperation().Add(new EmployeeWriteToDB("NorthWindConnection", "Employees")));
        }

        protected override void PostProcessing()
        {
            base.PostProcessing();

            foreach (var error in GetAllErrors())
            {
                throw error;
            }
        }
    }
}
