using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPR.Models
{
    public class Person
    {
        #region Field

        #endregion

        #region Property
        public string Name { get; set; }
        #endregion

        #region Constructor
        public Person(string name)
        {
            this.Name = name;
        }
        #endregion
    }
}
