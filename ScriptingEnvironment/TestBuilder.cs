using ComponentOne.PO_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIMSAutomationSTE.ScriptingEnvironment
{
    internal class TestBuilder
    {
        PageOne page_One;
        Page_Zero page_Zero;
        InceptionPoint _results;
        public TestBuilder(InceptionPoint results) {
            _results = results;
            page_One = new PageOne(results);
            page_Zero = new Page_Zero(results);
        }

        public void TestBuilderCarrier()
        {

            //start of script
            if(page_Zero.RunTC001_TrueTrue() == false)
            {
                _results.Failed_Test("TB: Test Failed");
                return;
            }

            if(page_One.RunTC001_TrueFalse() == false)
            {
                _results.Failed_Test("TB: Test Failed");
                return;
            }


        }

    }
}
