//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderCenter.Data.Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class S_File
    {
        public string FileID { get; set; }
        public string ProjectCode { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public string FileLocation { get; set; }
        public string FileCompressLocation { get; set; }
        public int FileType { get; set; }
        public string Creator { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    }
}
