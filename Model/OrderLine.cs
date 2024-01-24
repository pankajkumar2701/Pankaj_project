using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace pankaj - project . Model{
    /// <summary> 
    /// Represents a orderline entity with essential details
    /// </summary>
    public class OrderLine
    {
        /// <summary>
        /// Primary key for the OrderLine 
        /// </summary>
        [Key]
        [Required]
        public Guid OrderLineId { get; set; }
        /// <summary>
        /// Foreign key referencing the Order to which the OrderLine belongs 
        /// </summary>
        public Guid OrderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Order
        /// </summary>
        [ForeignKey("OrderID")]
        [JsonIgnore]
        public Order Order { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the OrderLine belongs 
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        [JsonIgnore]
        public Product Product { get; set; }
        /// <summary>
        /// Quantity of the OrderLine 
        /// </summary>
        public string Quantity { get; set; }
    }
}