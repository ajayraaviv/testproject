using ComponentOne.PO_Management;
using NIMSAutomationSTE;
using NIMSAutomationSTE.ScriptingEnvironment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentOne
{
    public class LaunchAndRun
    {
        private InceptionPoint MyResults;

        public LaunchAndRun(InceptionPoint results)
        {
            MyResults = results;
        }

        static void Main(string[] args)
        {
            InceptionPoint results = new InceptionPoint();
            //launch url here

            // E2E test case called from scripting here
            Page_Zero Run_TC001_TF = new Page_Zero(results);

            Run_TC001_TF.RunTC001_TrueFalse();

            //Run_TC001_TF.RunTC001_TrueTrue();

            TestBuilder tb = new TestBuilder(results);

            tb.TestBuilderCarrier();


            // Assertion method
            Console.WriteLine(results.TestHandler_OutputMessage);

        }

    }// end of class
} //end of namespace
