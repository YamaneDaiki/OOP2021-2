using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework.Models {
    //エンティティクラス
    public class Book {
        public int Id { get; set;  } //主キー
        [MaxLength(30)]
        public string Title { get; set; }
        [Required]
        public string Publisher { get; set; }

        public int PublishedYear { get; set; }
        public virtual Author Author { get; set; }
        }
    }

