using System;
using System.Collections.Generic;
using System.Text;

namespace workflow_engine
{
    class SendanemailtotheownerofthevideoActivity : IActivityType
    {
        public void Run(Activity activity)
        {
            Console.WriteLine("Notify the owner of the video....");
        }
    }
}
