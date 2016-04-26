﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Onism.Cldr.Extensions;

namespace Onism.Cldr.Schema
{
    public class CldrLocaleFilter
    {
        private readonly Regex filterRegex;

        public CldrLocaleFilter(IEnumerable<string> include, IEnumerable<string> exclude)
        {
            var toInclude = include.Select(WildcardToRegex).JoinStrings("|");
            var toExclude = exclude.Select(WildcardToRegex).JoinStrings("|");
            
            this.filterRegex = new Regex($"(?!^({toExclude})$)^({toInclude})$", RegexOptions.IgnoreCase);
        }

        public bool IsMatch(string locale) => this.filterRegex.IsMatch(locale);

        private static string WildcardToRegex(string pattern)
        {
            return Regex.Escape(pattern)
                .Replace(@"\*", ".*")
                .Replace(@"\?", ".");
        }
    }
}