using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace pankaj - project . Model{
    /// <summary> 
    /// Represents a product entity with essential details
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Primary key for the Product 
        /// </summary>
        [Key]
        public Guid ProductId { get; set; }
        /// <summary>
        /// Name of the Product 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Code of the Product 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Price of the Product 
        /// </summary>
        public string Price { get; set; }
        /// <summary>
        /// Collection navigation property representing associated 
        /// </summary>
        public ICollection<OrderLine> OrderLines { get; set; }
        /// <summary>
        /// Collection navigation property representing associated 
        /// </summary>
        public ICollection<Sales> Saless { get; set; }
    }
}