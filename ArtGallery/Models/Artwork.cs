//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtGallery.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artwork
    {
        public int Artwork_Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Size { get; set; }
        public Nullable<int> Category_Id { get; set; }
        public string Status { get; set; }
        public string ImagePath { get; set; }
    }
}
