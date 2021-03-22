using System;
using System.Collections.Generic;
using System.Text;

namespace Vulild.Core.Orm
{
    public class DbFieldAttribute : Attribute
    {
        public string FieldName { get; set; }

        public string Type { get; set; }

        public string Length { get; set; }

        public bool IsNull { get; set; }
        //public DbFieldAttribute(string fieldName, string type, int length)
        //{
        //    this.FieldName = fieldName;
        //    this.Type = type;
        //    this.Length = length;
        //}
    }
}
