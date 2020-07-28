using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace JQueryAJAX.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionID { get; set; }
        
        [MaxLength(12)]
        [Required(ErrorMessage = "This filed is requrired.")]
        [DisplayName("Account Number")]
        [Column(TypeName = "nvarchar(12)")]
        public string  AccountNumber{ get; set; }

        [Required(ErrorMessage = "This filed is requrired.")]
        [DisplayName("Beneficiary Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }

        [Required(ErrorMessage = "This filed is requrired.")]
        [DisplayName("Bank Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }

        [MaxLength(11)]
        [Required(ErrorMessage = "This filed is requrired.")]
        [DisplayName("SWIFT Code")]
        [Column(TypeName = "nvarchar(11)")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "This filed is requrired.")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
    }
}
