using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PandoLogic.Jobs.Api.Models
{
    [Table("TblJobs")]
    public class JobData
    {
        [Key]
        public int Id { get; set; }
        public int Active { get; set; }
        public int Views { get; set; }
        public int Predicted { get; set; }
        public DateTime Date { get; set; }
    }
}
