﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo1.Models
{
	public class SysUser
	{
		public int ID { get; set; }
		public string  Username { get; set; }
		public string  Password { get; set; }
        public string Email { get; set; }
        public virtual ICollection<SysUserRole> SysUserRoles { get; set; }
	}
}