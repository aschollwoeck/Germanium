using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;
using TypeProofSql.Statements;

namespace TypeProofSql.Statements.SQLite
{
    public class UpdateOr<T>Statement : UpdateOrStatement
        where T : ITable, new()
    {
        public UpdateOr(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}