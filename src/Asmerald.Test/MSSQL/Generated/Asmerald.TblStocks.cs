/*
This file was automatically generated by Asmerald.Generate library / executable.
It is not recommened to make manual changes in this file as any changes to this file will be overwritten when the next generation happens.
In case you need modifications please refer to adjusting the generation process itself.
This is possible by creating your own executable project and referencing or forking Asmerald.Generate library / executable.
*/

using System;
using Asmerald;
using Asmerald.Columns;

namespace master
{
    public partial class production
    {
        public static TblStocks stocks() => new TblStocks();
        public class TblStocks : ITable{
            string ITable.Name() => "production.stocks";
            public Col_Store_id Store_id() => new Col_Store_id();
            public Col_Product_id Product_id() => new Col_Product_id();
            public Col_Quantity Quantity() => new Col_Quantity();
            public static Col_Store_id Store_id(string tableAlias = "") => new Col_Store_id(tableAlias);
            public static Col_Product_id Product_id(string tableAlias = "") => new Col_Product_id(tableAlias);
            public static Col_Quantity Quantity(string tableAlias = "") => new Col_Quantity(tableAlias);
            public class Col_Store_id : IntegerColumn<TblStocks>, ISelectColumn<TblStocks>, ISelectColumnAlias<TblStocks>
            {
                private readonly string _name = "store_id";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Store_id() { }
                public Col_Store_id(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblStocks> As(string name) => new AliasColumn<TblStocks>(this, name);
                public override ISelectColumn<TblStocks> Count() => new CountColumn<TblStocks>(this);
            }
            public class Col_Product_id : IntegerColumn<TblStocks>, ISelectColumn<TblStocks>, ISelectColumnAlias<TblStocks>
            {
                private readonly string _name = "product_id";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Product_id() { }
                public Col_Product_id(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblStocks> As(string name) => new AliasColumn<TblStocks>(this, name);
                public override ISelectColumn<TblStocks> Count() => new CountColumn<TblStocks>(this);
            }
            public class Col_Quantity : IntegerColumn<TblStocks>, ISelectColumn<TblStocks>, ISelectColumnAlias<TblStocks>
            {
                private readonly string _name = "quantity";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Quantity() { }
                public Col_Quantity(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblStocks> As(string name) => new AliasColumn<TblStocks>(this, name);
                public override ISelectColumn<TblStocks> Count() => new CountColumn<TblStocks>(this);
            }
        }
    }
}