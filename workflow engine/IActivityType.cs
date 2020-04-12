using System.Diagnostics;

namespace workflow_engine
{
    public interface IActivityType
    {
        //The engine simply calls this Execute method and this way it executes a series of activities in sequence.
        void Run(Activity activity);
    }
}