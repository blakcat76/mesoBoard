//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mesoBoard.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThreadView
    {
        public int ThreadViewID { get; set; }
        public int ThreadID { get; set; }
        public int UserID { get; set; }
    
        public virtual User User { get; set; }
        public virtual Thread Thread { get; set; }
    }
}