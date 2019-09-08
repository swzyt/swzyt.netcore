using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Book")]
    public partial class Book
    {
        public Book()
        {


        }
        /// <summary>
        /// Desc:id
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true)]
        public long Tid { get; set; }

        /// <summary>
        /// Desc:标题
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Title { get; set; }

        /// <summary>
        /// Desc:作者
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Writer { get; set; }

    }
}
