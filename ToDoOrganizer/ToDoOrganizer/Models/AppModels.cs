//================================================================
// AppDomainClasses.cs 
// 10. to bring in class IdentityUser 
//================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework; // 10

namespace ToDoOrganizer.Models {
 
  public class AppModels {

    //================================================================
    // Since we are using Entity Framework Code First, EF will create 
    // the right keys between Users and ToDo table.
    //================================================================


    //================================================================
    // class MyUser, derived from class IdentityUser 
    // CREATE TABLE MyUser (HomeTown, ToDoes);
    // 10. ToDoes is an ICollection of _ToDo objects
    //================================================================
    public class MyUser : IdentityUser {
      public string HomeTown { get; set; }
      public virtual ICollection<ToDo> ToDoes { get; set; } // 10
    } // MyUser



    //================================================================
    // class ToDo with 4 insance variables:
    // CREATE TABLE ToDo (Id, Description, IsDone, User);
    //================================================================
    public class ToDo {
      public int Id { get; set; }
      public string Description { get; set; }
      public bool IsDone { get; set; }
      public virtual MyUser User { get; set; }
    } // ToDo

  } // AppModels
} // ToDo.Models