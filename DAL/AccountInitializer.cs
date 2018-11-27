using MvcDemo1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcDemo1.DAL
{
    public class AccountInitializer : DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            var users = new List<SysUser> {
            new SysUser {Username="Admin",Password="123456",Email="Admin@qq.com"},
            new SysUser {Username="rc",Password="123456",Email="rc@qq.com" },
            };
            //users.ForEach(s => context.SysUsers.Add(s));
            //context.SaveChanges();
            var roles = new List<SysRole>(){
                new SysRole(){RoleName="Administrator",RoleDesc="Administrator have full authorization to perform system administration."},
                new SysRole(){RoleName="General User",RoleDesc="General User can access the data they are authorized for."}
            };

            var userroles = new List<SysUserRole>()            {
                new SysUserRole(){SysRoleID=1,SysUserID=1},
                new SysUserRole(){SysRoleID=2,SysUserID=2}
            };
            context.SysUsers.AddRange(users);
            context.SysRoles.AddRange(roles);
            context.SysUserRoles.AddRange(userroles);
            context.SaveChanges();
        }
    }
}