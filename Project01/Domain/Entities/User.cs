﻿using Project01.Domain.Common.BaseEntities;

namespace Project01.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
