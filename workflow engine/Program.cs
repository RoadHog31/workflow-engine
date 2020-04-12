using System;
using System.Collections.Generic;

namespace workflow_engine
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var workFlow = new WorkFlow();
            workFlow.RegisterNewActivity(new CallawebserviceprovidedbyathirdpartyActivity());
            workFlow.RegisterNewActivity(new ChangethestatusofthevideorecordinthedatabasetoProcessingActivity());
            workFlow.Execute(new Activity());
            
        }
    }
}
