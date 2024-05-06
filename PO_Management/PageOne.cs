using NIMSAutomationSTE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentOne.PO_Management
{
    internal class PageOne : BasePage
    {

        public PageOne(InceptionPoint results)
        {
            MyResults = results;
            Boom = new CTwo_Integration(MyResults);

        } //end of constructor

        public bool RunTC001_TrueFalse()
        {
            //validate the user can do this
            //where 'this' = Method 'C' = this button

            return false;
        }

        public bool RunTC001_TrueTrue()
        {
            //validate the user can do this
            //where 'this' = Method 'C' this button

            return true;

        }
    }
}
