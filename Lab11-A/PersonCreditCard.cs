//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab11_A
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonCreditCard
    {
        public int BusinessEntityID { get; set; }
        public int CreditCardID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual CreditCard CreditCard { get; set; }
    }
}
