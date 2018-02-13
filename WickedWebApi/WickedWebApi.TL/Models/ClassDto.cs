﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WickedWebApi.BL.Models
{
    public class ClassDto
    {
        public int Id { get; set; }
        public SubjectDto Subject { get; set; }
        public ClassTypeEnum ClassType { get; set; }
    }
}