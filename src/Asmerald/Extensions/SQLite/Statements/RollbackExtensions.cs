using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.SQLite;

namespace Asmerald.SQLite
{
    public static partial class TypeProofSqlRollbackExtensions
    {
        public static InsertRollbackStatement Rollback(this InsertOrStatement stmt)
        {
            return new InsertRollbackStatement(stmt.QueryBuilder);
        }
        public static UpdateRollbackStatement<T> Rollback<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateRollbackStatement<T>(stmt.QueryBuilder);
        }
    }
}