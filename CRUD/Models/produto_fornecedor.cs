//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class produto_fornecedor
    {
        public int id { get; set; }
        public int id_produto { get; set; }
        public int id_fornecedor { get; set; }
    
        public virtual fornecedor fornecedor { get; set; }
        public virtual produto produto { get; set; }
    }
}