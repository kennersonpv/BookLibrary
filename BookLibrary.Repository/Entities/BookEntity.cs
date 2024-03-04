using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository.Entities
{
    public class BookEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("total_copies")]
        public int TotalCopies { get; set; }
        [Column("copies_in_use")]
        public int CopiesInUse { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("isbn")]
        public string ISBN { get; set; }
        [Column("category")]
        public string Category { get; set; }
    }
}
