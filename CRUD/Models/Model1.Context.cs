﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Database1Entities : DbContext
    {
        public Database1Entities()
            : base("name=Database1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<fornecedor> fornecedor { get; set; }
        public virtual DbSet<produto> produto { get; set; }
        public virtual DbSet<produto_fornecedor> produto_fornecedor { get; set; }
    
        public virtual int InserirProdutoFornecedor(Nullable<int> id_produto, Nullable<int> id_fornecedor)
        {
            var id_produtoParameter = id_produto.HasValue ?
                new ObjectParameter("id_produto", id_produto) :
                new ObjectParameter("id_produto", typeof(int));
    
            var id_fornecedorParameter = id_fornecedor.HasValue ?
                new ObjectParameter("id_fornecedor", id_fornecedor) :
                new ObjectParameter("id_fornecedor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InserirProdutoFornecedor", id_produtoParameter, id_fornecedorParameter);
        }
    
        public virtual ObjectResult<produto_SearchProducts_Result> produto_SearchProducts(string productName)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<produto_SearchProducts_Result>("produto_SearchProducts", productNameParameter);
        }
    
        public virtual ObjectResult<produto> spSearchProducts(string productName)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<produto>("spSearchProducts", productNameParameter);
        }
    
        public virtual ObjectResult<produto> spSearchProducts(string productName, MergeOption mergeOption)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<produto>("spSearchProducts", mergeOption, productNameParameter);
        }
    
        public virtual int produto_updateProduto(Nullable<int> id_produto, string productName, Nullable<decimal> valor)
        {
            var id_produtoParameter = id_produto.HasValue ?
                new ObjectParameter("id_produto", id_produto) :
                new ObjectParameter("id_produto", typeof(int));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("produto_updateProduto", id_produtoParameter, productNameParameter, valorParameter);
        }
    
        public virtual ObjectResult<produto> spUpdateProduto(Nullable<int> id_produto, string productName, Nullable<decimal> valor)
        {
            var id_produtoParameter = id_produto.HasValue ?
                new ObjectParameter("id_produto", id_produto) :
                new ObjectParameter("id_produto", typeof(int));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<produto>("spUpdateProduto", id_produtoParameter, productNameParameter, valorParameter);
        }
    
        public virtual ObjectResult<produto> spUpdateProduto(Nullable<int> id_produto, string productName, Nullable<decimal> valor, MergeOption mergeOption)
        {
            var id_produtoParameter = id_produto.HasValue ?
                new ObjectParameter("id_produto", id_produto) :
                new ObjectParameter("id_produto", typeof(int));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<produto>("spUpdateProduto", mergeOption, id_produtoParameter, productNameParameter, valorParameter);
        }
    
        [DbFunction("Database1Entities", "Produto_CountProducts")]
        public virtual IQueryable<Nullable<int>> Produto_CountProducts(Nullable<int> id_fornecedor)
        {
            var id_fornecedorParameter = id_fornecedor.HasValue ?
                new ObjectParameter("id_fornecedor", id_fornecedor) :
                new ObjectParameter("id_fornecedor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Nullable<int>>("[Database1Entities].[Produto_CountProducts](@id_fornecedor)", id_fornecedorParameter);
        }
    }
}