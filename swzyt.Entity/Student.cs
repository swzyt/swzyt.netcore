using System;

namespace swzyt.Entity
{
    /// <summary>
    /// 学生实体
    /// </summary>
    public class Student
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Tid { get; set; }
        /// <summary>
        /// 班级id
        /// </summary>
        public int ClassId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
    }
}
