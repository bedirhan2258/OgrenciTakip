

using System;

namespace OgrenciTakip.Model.Attributes
{
    public class ZorunluAlan : Attribute
    {
        public string Description { get; }

        public string ControlName { get; }

        /// <summary>
        /// Validation İşlemleri sırasında zorunlu olan alanları işaretlemek için kullanılacak.
        /// </summary>
        /// <param name="description">Uyarı mesajında gösterilecek olan açıklama</param>
        /// <param name="controlName">Uyarı mesajı sonrası focuslanılacak control adı</param>
        /// 
        public ZorunluAlan(string description, string controlName)
        {
            Description = description;
            ControlName = controlName;
        }
    }
}
