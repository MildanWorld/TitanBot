﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitanBot
{
    public static partial class TBLocalisation
    {
        public static partial class Commands
        {
            public static class DbPurgeText
            {
                private const string BASE_PATH = Commands.BASE_PATH + "DBPURGE_";

                public const string SUCCESS = BASE_PATH + nameof(SUCCESS);

                public static IReadOnlyDictionary<string, string> Defaults { get; }
                    = new Dictionary<string, string>
                    {
                        { SUCCESS, "Attempted to drop all data from the `{0}` table" }
                    }.ToImmutableDictionary();
            }
        }
    }
}
