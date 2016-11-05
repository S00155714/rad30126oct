﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_attempt_2.ClubModels
{
    [Table("Club")]
    public class Club
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClubId { get; set; }
        public string ClubName { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreationDate { get; set; }

        public int adminID { get; set; }
        public virtual ICollection<Member> clubMembers { get; set; }
        public virtual ICollection<ClubEvent> clubEvents { get; set; }

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

        public Member Member
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
