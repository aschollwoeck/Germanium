using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Columns;
using System.Linq;
using TypeProofSql.Statements;
using TypeProofSql.Functions.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlUpperExtensions
    {
        public static UpperFunction Upper(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new UpperFunction(x);
        }
        public static UpperFunction Upper(this Int16 x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Int32 x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Int64 x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this UInt16 x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this UInt32 x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this UInt64 x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Decimal x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Double x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this String x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Char x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Boolean x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Byte x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this DateTime x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Single x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this ISelectColumn x)
        {
            return new UpperFunction(x);
        }
    }
}
