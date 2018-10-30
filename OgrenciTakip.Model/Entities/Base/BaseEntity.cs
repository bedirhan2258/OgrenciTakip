
using OgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities.Base

{
    public class BaseEntity : IBaseEntity
    {
        //Database oluşturulerken Id kolonunu sıfırıncı  kolon yapar.
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        [Column(Order = 1), Required, StringLength(20)]
        public virtual string Kod { get; set; }
    }
}
