using NIMSAutomationSTE;

namespace ComponentOne.PO_Management
{
    internal class Page_Zero : BasePage
    {


        public Page_Zero(InceptionPoint results)
        {
            MyResults = results;
            Boom = new CTwo_Integration(MyResults);

        } //end of constructor

        public bool RunTC001_TrueFalse()
        {
            //validate the user can do this
            //where 'this' = Method 'C' = this button

            if (Boom.Method_A_TrueTrue() == false)
            {
                MyResults.Failed_Test("BZNESS Controls: Could Not Find Method 'A'. ");
                return false;
            }
            if (Boom.Method_B_TrueTrue() == false)
            {
                MyResults.Failed_Test("BZNESS Controls: Could Not Find Method 'B'. ");
                return false;
            }
            if (Boom.Method_C_TrueFalse() == false)
            {
                MyResults.Failed_Test("BZNESS Controls: Could Not Find Method 'C'. ");
                return false;
            }
            return true;
        }

        public bool RunTC001_TrueTrue()
        {
            //validate the user can do this
            //where 'this' = Method 'C' this button

            return true;

        }

    } //end of class
} //end of namespace
