using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication7.Models
{
    class Medicine
    {
        private string registration_number;
        private string name;
        private string expired;

        public int Id { get; set; }

        public string RegistrationNumber
        {
            get { return registration_number; }
            set { registration_number = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Expired
        {
            get { return expired; }
            set { expired = value; }
        }
    }
}
