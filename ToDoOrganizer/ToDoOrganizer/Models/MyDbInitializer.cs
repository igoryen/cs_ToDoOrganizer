//==========================================================================
// 30. contains definition of class DropCreateDatabaseAlways<>
//==========================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; // 30

namespace ToDoOrganizer.Models {
 
  public class MyDbInitializer : DropCreateDatabaseAlways<MyDbContext> {
    //==========================================================================
    // method Seed() -- used to initialize tables
    //==========================================================================
    protected override void Seed(MyDbContext context) {

      //==========================================================================
      // Create a UserManager from ASP.NET Identity system.
      // The UserManager will let us do operations on the User such as 
      // Create, List, Edit and Verify the user. 
      //==========================================================================
      var UserManager = new UserManager<MyUser>(new UserStore<MyUser>(context));

      //==================================================================================
      // Create a RoleManager from ASP.NET Identity system which lets us operate on Roles.
      //==================================================================================
      var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

      string name = "Admin";
      string password = "123456";

      //==================================================================================
      // If Role Admin does not exist, create it
      //==================================================================================
      if (!RoleManager.RoleExists(name)) {
        var roleresult = RoleManager.Create(new IdentityRole(name));
      }

      //Create User=Admin with password=123456
      var user = new MyUser();
      user.UserName = name;
      var adminresult = UserManager.Create(user, password);

      //Add User Admin to Role Admin
      if (adminresult.Succeeded) {
        var result = UserManager.AddToRole(user.Id, name);
      }
      base.Seed(context);
    }
  }
}