using System.Collections.Generic;

namespace workflow_engine
{
   
    public class WorkFlow 
    {
        private readonly IList<IActivityType> _activityType;

        public WorkFlow( )
        {
            _activityType = new List<IActivityType>();
        }

        
        public void Execute(Activity activityType)
        {
            if (_activityType == null)
            {
                throw new System.NotImplementedException();
            }
            foreach (var item in _activityType)
            {
                item.Run(new Activity());
            }
            
        }

        public void RegisterNewActivity(IActivityType item)
        {
            _activityType.Add(item);
        }

        
    }
    
}
