﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_IS_21zp.Model
{
    class SearchResult
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public SearchType Type { get; set; }

        public SearchResult(long id, string fullName, SearchType type)
        {
            Id = id;
            FullName = fullName;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Id} - {FullName} - {Type}" ;
        }
    }
}
