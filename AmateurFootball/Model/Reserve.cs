//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmateurFootball.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserve
    {
        public int Id { get; set; }
        public int StadiumId { get; set; }
        public string STime { get; set; }
        public string Etime { get; set; }
        public Nullable<System.DateTime> ReserervAcsessDate { get; set; }
        public decimal Price { get; set; }
        public int CostumerId { get; set; }
        public Nullable<System.DateTime> MatchDate { get; set; }
    
        public virtual Costumer Costumer { get; set; }
        public virtual Stadium Stadium { get; set; }
    }
}
