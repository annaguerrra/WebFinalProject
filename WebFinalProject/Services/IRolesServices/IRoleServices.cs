using WebFinalProject.Models;

namespace WebFinalProject.Services.IRolesServices;

public class IRolesServices
{
   public void RoleDefinition(Role role)
   {
      if (role.ID == 1)
         role.Name = "Audience";

      else if (role.ID == 2)
         role.Name = "Painter";

      else if (role.ID == 3)
         role.Name = "Administrator";

      else if (role.ID == 4)
         role.Name = "Owner";

      else
         Console.WriteLine("This role ID doesn't exist.");
   }
}