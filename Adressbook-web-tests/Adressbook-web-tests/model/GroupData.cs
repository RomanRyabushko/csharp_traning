using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAdressbookTests
{
    public class GroupData : IEquatable<GroupData>
    {
        private string name;
        private string header = "";
        private string footer = "";

        public GroupData(string name)
        {
            this.name = name;
        }

        public bool Equals(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Name == other.Name;
        }

        public int GetHashCode()
        {
            return Name.GetHashCode();
        }
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Header
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
            }

        }

        public string Footer
        {
            get
            {
                return footer;
            }
            set 
            {
                footer = value;
            }
        }
    }
}
