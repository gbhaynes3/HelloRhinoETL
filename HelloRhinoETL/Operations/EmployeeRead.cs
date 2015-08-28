using System.Collections.Generic;
using HelloRhinoETL.DataObjects;
using Rhino.Etl.Core;
using Rhino.Etl.Core.Files;
using Rhino.Etl.Core.Operations;

namespace HelloRhinoETL.Operations
{
    public class EmployeeRead: AbstractOperation
    {
        private readonly string _filePath = string.Empty;

        public EmployeeRead(string filePath)
        {
            _filePath = filePath;
        }

        public override IEnumerable<Row> Execute(IEnumerable<Row> rows)
        {
            using (var file = FluentFile.For<EmployeeInputRecord>().From(_filePath))
            {
                foreach (var obj in file)
                {
                    yield return Row.FromObject(obj);
                }
            }
        }
    }
}
