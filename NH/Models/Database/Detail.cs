//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NH.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Detail
    {
        internal int id;
        [Required(ErrorMessage = "Please provide ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide Room Number")]
        public int Room_Number { get; set; }
        [Required(ErrorMessage = "Please provide Room Catagory")]
        public string Room_Catagory { get; set; }
        [Required(ErrorMessage = "Please provide Price")]
        public int Price { get; set; }
    }
}