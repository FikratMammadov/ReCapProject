﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{ 
    public class UserOperationClaim
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int OperationClaimId { get; set; }
        public OperationClaim OperationClaim { get; set; }
    }
}
