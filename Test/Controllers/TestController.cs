using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    [Authorize]
    public class TestController : Controller
    {
        public ActionResult Index()
        {

            TestViewModel TestViewModel = new TestViewModel();
            return View(TestViewModel);
        }

        public List<string> GetAllUpToInc(int input)
        {
            List<string> T = new List<string>();
            for (int i = 0;i <= input; i++)
            {
                T.Add(i.ToString());
            }

            return T.ToList();
        }

        public List<string> GetAllOddUpToInc(int input)
        {
            List<string> T = new List<string>();
            for (int i = 1; i + 2 <= input; i = i + 2)
            {
                T.Add(i.ToString());
            }

            return T.ToList();
        }

        public List<string> GetAllEvenUpToInc(int input)
        {
            List<string> T = new List<string>();
            for (int i = 0; i + 2 <= input; i = i + 2)
            {
                T.Add(i.ToString());
            }

            return T.ToList();
        }

        public List<string> GetAllExcept(int input)
        {
            List<int> T = new List<int>();
            List<string> t = new List<string>();
            for (int i = 0; i <= input; i++)
            {
                T.Add(i);
            }

            for (int i = 0;i <  (T.Count()) ;i++)
            {
                if ((T.ElementAt(i) % 3 == 0) && (T.ElementAt(i) % 5 == 0))
                {
                    t.Add("Z");
                }
                else if (T.ElementAt(i) % 5 == 0)
                {
                    t.Add("E");
                }
                else if (T.ElementAt(i) % 3 == 0)
                {
                    t.Add("C");
                }
                else
                {
                    t.Add(T.ElementAt(i).ToString());
                }
            }

            return t.ToList();
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public List<string> GetAllFibonacci(int input)
        {
            List<string> T = new List<string>();
            for (int i = 0; i <= input; i++)
            {
                T.Add(Fibonacci(i).ToString());
            }

            return T.ToList();
        }





        [HttpPost]
        public ActionResult Calculate(TestViewModel Test)
        {
            TestShowViewModel TestShowViewModel = new TestShowViewModel();
            try {
                if (ModelState.IsValid)
                {
                    if (Test.input >= 0)
                    {

                        TestShowViewModel.AllUpToInc = GetAllUpToInc(Test.input);
                        TestShowViewModel.AllOddUpToInc = GetAllOddUpToInc(Test.input);
                        TestShowViewModel.AllEvenUpToInc = GetAllEvenUpToInc(Test.input);
                        TestShowViewModel.AllExcept = GetAllExcept(Test.input);
                        TestShowViewModel.AllFibonacci = GetAllFibonacci(Test.input);
                        return View("Results", TestShowViewModel);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Please enter a Positive number");
                    }
                }
                 else
                    {
                         ModelState.AddModelError("", "An error occured. Please try again");
                    }
            }
                catch(Exception)
                {
                     ModelState.AddModelError("", "An error occured. Please try again");
                }
            return View("Index");
            }

           
     


	}
}