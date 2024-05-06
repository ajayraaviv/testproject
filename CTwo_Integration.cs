using NIMSAutomationSTE;
using System.Linq;

namespace NIMSAutomationSTE
{

    public class CTwo_Integration
    {

        private InceptionPoint MyResults;

        public CTwo_Integration(InceptionPoint results)
        {
            MyResults = results;
        }//end of constructor

        public Boolean Method_A_TrueFalse()
        {
            try
            {

            }
            catch
            {
                MyResults.Failed_Test("Method_A: Test Failed");
                return false;
            }
            MyResults.Successful_Test();
            return true;
        }

        public Boolean Method_A_TrueTrue()
        {
            try
            {

            }
            catch
            {

            }
            MyResults.Successful_Test();
            MyResults.Failed_Test("Method_A: False Positive OCCURED. ");
            return false;
        }

        public Boolean Method_B_TrueFalse()
        {
            try
            {

            }
            catch
            {
                MyResults.Failed_Test("Method_B: Test Failed");
                return false;
            }
            MyResults.Successful_Test();
            return true;
        }

        public Boolean Method_B_TrueTrue()
        {
            try
            {

            }
            catch
            {
                MyResults.Successful_Test();
                return true;
            }
            MyResults.Failed_Test("Method_B: False Positive OCCURED. ");
            return false;
        }

        public Boolean Method_C_TrueFalse()
        {
            try
            {

            }
            catch
            {
                MyResults.Failed_Test("Method_C: Test Failed");
                return false;
            }
            MyResults.Successful_Test();
            return true;
        }

        public Boolean Method_C_TrueTrue()
        {
            try
            {

            }
            catch
            {
                MyResults.Successful_Test();
                return true;
            }
            MyResults.Failed_Test("Method_C: False Positive OCCURED. ");
            return false;
        }

    }//end of class
}//end of namespace