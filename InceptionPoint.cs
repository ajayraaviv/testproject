using System.Collections.Specialized;

namespace NIMSAutomationSTE
{
    public class InceptionPoint
    {

        private Int32 mBadCount, mGoodCount;
        private StringCollection mErrorLog;

        public InceptionPoint()
        {
            mErrorLog = new StringCollection();
        }//end of constructor

        public void Successful_Test()
        {
            mGoodCount++;
        }
        public void Failed_Test(String FoundErrorM)
        {
            mBadCount++;
            mErrorLog.Add(FoundErrorM);

        }

        public Int32 SuccessfulTask_Count
        {
            get { return mGoodCount; }
        }

        public Int32 FailedTask_Count
        {
            get
            {
                return mBadCount;
            }
        }

        public StringCollection My_ErrorLog
        {
            get
            {
                return mErrorLog;
            }

        }

        public string TestHandler_OutputMessage
        {
            get
            {
                if (mBadCount == 0)
                {
                    return (String)null;
                }
                String Generate_OutputMessage;

                Generate_OutputMessage = "\r\n\r\n" + Convert.ToString(mBadCount) + "test(s) failed.";

                if (mBadCount > 1)
                {
                    Generate_OutputMessage += " ";
                }

                Generate_OutputMessage += "\r\n\r\n" + Convert.ToString(mGoodCount) + "test(s) passed";

                Generate_OutputMessage += "\r\n\r\n This specific Set: \r\n";

                foreach (String MyGeneratedM in mErrorLog)
                {
                    Generate_OutputMessage += "\r\n" + MyGeneratedM + "\r\n";
                }
                return Generate_OutputMessage;
            }
        }

    }//end of class

}//end of namespace