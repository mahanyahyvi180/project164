using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp54
{
    namespace teacher
    { 
        public class cEmployee
        {
            public string firstname;
            public string lastname;
            public string identity;

            public cEmployee()
            {
                firstname = "ali";
                lastname = "yahyavi";
            }

            public string Concatinate()
            {
                return firstname + ' ' + lastname;
            }
 
          
           
            }
    }
}
