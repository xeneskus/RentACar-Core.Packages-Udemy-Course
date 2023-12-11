using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories
{
    public class Entity<TId>
    {
        public TId Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }//girmek zorunda degiliz
        public DateTime? DeletedDate { get; set; } //girmek zorunda degiliz
        public Entity()
        {
            Id = default;//defaultu neyse  o verilsin boşken mesela 0 mı int 0 verilsin
        }
        public Entity(TId id) 
        {
            Id=id;
        }
    }
}
