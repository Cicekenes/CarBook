﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.ContactQueries
{
    public class GetContactByIdQuery
    {
        public string Id { get; set; }

        public GetContactByIdQuery(string id)
        {
            Id = id;
        }
    }
}
