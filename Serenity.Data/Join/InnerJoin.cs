﻿
using System.Collections.Generic;

namespace Serenity.Data
{
    /// <summary>
    /// INNER JOIN type
    /// </summary>
    /// <seealso cref="Serenity.Data.Join" />
    public class InnerJoin : Join
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InnerJoin"/> class.
        /// </summary>
        /// <param name="toTable">To table.</param>
        /// <param name="alias">The alias.</param>
        /// <param name="onCriteria">The ON criteria.</param>
        /// <param name="hint">The table hint.</param>
        public InnerJoin(string toTable, string alias, ICriteria onCriteria, string hint = null)
            : base(null, toTable, alias, onCriteria, hint)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InnerJoin"/> class.
        /// </summary>
        /// <param name="joins">The joins.</param>
        /// <param name="toTable">To table.</param>
        /// <param name="alias">The alias.</param>
        /// <param name="onCriteria">The ON criteria.</param>
        /// <param name="hint">The table hint.</param>
        public InnerJoin(IDictionary<string, Join> joins, string toTable, string alias, ICriteria onCriteria, string hint = null)
            : base(joins, toTable, alias, onCriteria, hint)
        {
        }

        /// <summary>
        /// Gets the SQL keyword.
        /// </summary>
        /// <returns></returns>
        public override string GetKeyword()
        {
            return "INNER JOIN";
        }
    }
}