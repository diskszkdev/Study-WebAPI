using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloAPI.Models.Repositories
{
    /// <summary>
    /// 会社テーブルのデータモデル
    /// </summary>
    public class Company
    {
        /// <summary>
        /// 会社ID
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// 会社名
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string CompanyName { get; set; }

        /// <summary>
        /// 住所
        /// </summary>
        [MaxLength(100)]
        public string Address { get; set; }

        /// <summary>
        /// 備考
        /// </summary>
        [MaxLength(200)]
        public string Remarks { get; set; }

        /// <summary>
        /// 所属従業員
        /// </summary>
        public ICollection<Employee> Employees { get; set; }
    }
}