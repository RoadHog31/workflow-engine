using System;
using System.Collections.Generic;
using System.Text;

namespace workflow_engine
{
    public class ChangethestatusofthevideorecordinthedatabasetoProcessingActivity : IActivityType
    {
        public void Run(Activity activity)
        {
            Console.WriteLine("Change the ststus of video recorder....");
        }
    }
}
