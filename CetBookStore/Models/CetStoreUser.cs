using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class CetStoreUser :IdentityUser<int>
    {
        public DateTime BirthDate { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }

        public string AvatarFileName { get; set; }

    }

    public class CetStoreRole : IdentityRole<int>
    {
    public bool CanEnterComment { get; set; }    
    public bool CanDeleteComment { get; set; }

    }
}
