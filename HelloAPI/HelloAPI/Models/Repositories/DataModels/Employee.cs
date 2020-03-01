using System.ComponentModel.DataAnnotations;

namespace HelloAPI.Models.Repositories
{
    /// <summary>
    /// 従業員テーブルのデータモデル
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// 従業員ID
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// 従業員名
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 住所
        /// </summary>
        [MaxLength(100)]
        public string Address { get; set; }

        /// <summary>
        /// 電話番号
        /// </summary>
        [MaxLength(13)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 備考
        /// </summary>
        [MaxLength(200)]
        public string Remarks { get; set; }

        /// <summary>
        /// 所属会社
        /// </summary>
        public Company Company { get; set; }
    }
}