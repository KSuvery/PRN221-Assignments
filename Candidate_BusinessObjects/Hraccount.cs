﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Candidate_BusinessObjects
{
    public partial class Hraccount
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int? MemberRole { get; set; }
    }
}
