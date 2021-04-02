using System;
namespace Giraffe
{
    public class Testing
    {
        private Guid id;

        public Testing (Guid aId)
        {
            Id = aId;
        }
        
        public Guid Id
        {
            get{ return id;}
            set
            {
                id = value;
            }
        }
    }
}
