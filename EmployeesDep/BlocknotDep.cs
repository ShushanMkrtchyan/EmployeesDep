using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDep
{
    class BlocknotDep
    {
        public const string FileName1 = "BlocknotDep.txt";

        private List<Department> deps;
        public BlocknotDep()
        {
            deps = new List<Department>();
        }

        public void Add(Department dep)
        {
            this.deps.Add(dep);
        }

        //public bool SaveToFile()
        //{
        //    try
        //    {
        //        StreamWriter streamWriter = new StreamWriter(FileName1);
        //        foreach (Department dep in this.deps)
        //        {
        //            streamWriter.WriteLine(dep);
        //        }
        //        return true;

        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //}

        //public void LoadFromFile()
        //{
        //    this.deps.Clear();

        //    using (StreamReader streamReader = new StreamReader(FileName1))
        //    {
        //        string line;
        //        while ((line = streamReader.ReadLine()) != null)
        //        {
        //            Console.WriteLine(line);
        //        }

        //    }
        //}
    }
}
