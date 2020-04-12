using System;
using System.Collections.Generic;
using System.Text;

namespace workflow_engine
{
    public class CallawebserviceprovidedbyathirdpartyActivity : IActivityType
    {
        public void Run(Activity activity)
        {
            Console.WriteLine("Call WebService by 3rd Party....");
        }
    }
}
