//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DFSP.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MyDBEntities : DbContext
    {
        public MyDBEntities()
            : base("name=MyDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    
        public virtual int AddStudent(Nullable<int> id, string name, Nullable<int> marks)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var marksParameter = marks.HasValue ?
                new ObjectParameter("Marks", marks) :
                new ObjectParameter("Marks", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddStudent", idParameter, nameParameter, marksParameter);
        }
    
        public virtual int DeleteStudent(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteStudent", idParameter);
        }
    
        public virtual ObjectResult<Student> SelectAllStudent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Student>("SelectAllStudent");
        }
    
        public virtual ObjectResult<Student> SelectAllStudent(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Student>("SelectAllStudent", mergeOption);
        }
    
        public virtual ObjectResult<Student> SelectById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Student>("SelectById", idParameter);
        }
    
        public virtual ObjectResult<Student> SelectById(Nullable<int> id, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Student>("SelectById", mergeOption, idParameter);
        }
    
        public virtual int UpdateStudent(Nullable<int> id, string name, Nullable<int> marks)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var marksParameter = marks.HasValue ?
                new ObjectParameter("Marks", marks) :
                new ObjectParameter("Marks", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateStudent", idParameter, nameParameter, marksParameter);
        }
    }
}
