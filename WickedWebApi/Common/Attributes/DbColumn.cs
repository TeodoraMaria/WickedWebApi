using System;

namespace Common.Attributes
{
    public class DbColumnAttribute:Attribute
    {
        public string ColumnName { get; set; }

        public DbColumnAttribute(string columnName)
        {
            ColumnName = columnName;
        }
    }
}
