using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class TestShowViewModel
    {
        public TestShowViewModel()
        {
            this.AllUpToInc = new List<string>();
            this.AllOddUpToInc = new List<string>();
            this.AllEvenUpToInc = new List<string>();
            this.AllExcept = new List<string>();
            this.AllFibonacci = new List<string>();
        }


       public IEnumerable<string> AllUpToInc { get; set; }
       public IEnumerable<string> AllOddUpToInc { get; set; }
       public IEnumerable<string> AllEvenUpToInc { get; set; }
       public IEnumerable<string> AllExcept { get; set; }
       public IEnumerable<string> AllFibonacci { get; set; }
    }
}