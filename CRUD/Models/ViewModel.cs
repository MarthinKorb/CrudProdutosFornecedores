using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class ViewModel
    {
        public String nomeProduto { get; set; }

        public String nomeFornecedor { get; set; }

        public decimal ? valor { get; set; }
    }
}