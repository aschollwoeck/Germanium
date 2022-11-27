using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Columns;
using System.Linq;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlDescExtensions
    {
        public static DescStatement Desc(this OrderByStatement stmt)
        {
            return new DescStatement(stmt.QueryBuilder);
        }
        public static DescStatement Desc(this CollateStatement stmt)
        {
            return new DescStatement(stmt.QueryBuilder);
        }
    }
}