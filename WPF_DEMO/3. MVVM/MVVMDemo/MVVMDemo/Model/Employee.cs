using MVVMDemo.Common;

namespace MVVMDemo.Model
{
    class Employee : CommonBase
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value;
                
            }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value;
                
            }
        }

    }
}
