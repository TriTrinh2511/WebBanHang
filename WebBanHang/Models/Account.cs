using System;
using System.Collections.Generic;

namespace WebBanHang.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? PassWord { get; set; }
        public string Active { get; set; } = null!;
        public string? FullName { get; set; }
        public int RoleId { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual Role Role { get; set; } = null!;
    }
}
