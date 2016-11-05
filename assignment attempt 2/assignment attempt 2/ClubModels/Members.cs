using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_attempt_2.ClubModels
{
    [Table("Member")]
    public class Member
    {

        [Key,Column(Order =1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int memberID { get; set; }
        [Key, Column(Order = 2)]
        public string StudentID { get; set; }
        public int approved { get; set; }

        public ClubEvent ClubEvent
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}