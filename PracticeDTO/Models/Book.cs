//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticeDTO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }  // 
        public Nullable<int> Pages { get; set; } //
        public Nullable<System.DateTime> Publish_Date { get; set; } //
        public int Auther_Id { get; set; }
    
        public virtual Auther Auther { get; set; }
    }
}
