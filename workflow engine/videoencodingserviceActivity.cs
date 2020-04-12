using System;
using System.Collections.Generic;
using System.Text;

namespace workflow_engine
{
    public class videoencodingserviceActivity : IActivityType
    {
        public void Run(Activity activity)
        {
            Console.WriteLine("Video encoding....");
        }

        
    }
}
