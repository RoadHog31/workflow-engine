using System;
using System.Collections.Generic;
using System.Text;

namespace workflow_engine
{
    public class UploadavideotoacloudstorageActivity : IActivityType
    {        

        public void Run(Activity activity)
        {
            Console.WriteLine("Upload Video....");
        }
    }
}
