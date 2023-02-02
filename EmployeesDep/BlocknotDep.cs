using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace EmployeesDep
{
    class BlocknotDep: IEnumerable<Department>
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
        

        public bool SaveToFile2()
        {
            try
            {
               using 
                    StreamWriter streamWriter = new StreamWriter(FileName1);
                foreach (Department dep in this.deps)
                {
                    streamWriter.WriteLine(dep.Name);
                }
                return true;

            }
            catch(Exception ex)
            {
                return false;
            }

        }

        public void LoadFromFile2()
        {
            this.deps.Clear();

            using (StreamReader streamReader = new StreamReader(FileName1))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }
        }

        public IEnumerator<Department> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
