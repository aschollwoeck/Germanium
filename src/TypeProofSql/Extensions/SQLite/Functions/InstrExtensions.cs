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
    public static partial class TypeProofSqlInstrExtensions
    {
        public static InstrFunction Instr(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new InstrFunction(x, y);
        }
        public static InstrFunction Instr(this Int16 x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Int32 x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Int64 x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this UInt16 x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this UInt32 x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this UInt64 x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Decimal x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Double x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this String x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Char x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Boolean x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Byte x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this DateTime x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Single x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this ISelectColumn x, ISelectExpression y)
        {
            return new InstrFunction(x, y);
        }
    }
}
