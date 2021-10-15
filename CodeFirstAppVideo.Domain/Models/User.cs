using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstAppVideo.Domain.Models
{
    public class User : IdentityUser<Guid>
    {

    }

    public class Role: IdentityRole<Guid> { 
    
    }

    public class UserClaim : IdentityUserClaim<Guid> { }
    public class UserToken : IdentityUserToken<Guid> { }
    public class UserLogin : IdentityUserLogin<Guid> { }
    public class UserRole : IdentityUserRole<int> { }
    public class RoleClaim : IdentityRoleClaim<int> { }
}
