﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.BrandCommands
{
    public class UpdateBrandCommand
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
