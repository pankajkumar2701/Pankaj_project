using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace pankaj - project . Model{
    /// <summary> 
    /// Represents a customer entity with essential details
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Primary key for the Customer 
        /// </summary>
        [Key]
        [Required]
        public Guid CustomerId { get; set; }
        /// <summary>
        /// Name of the Customer 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Address of the Customer 
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Foreign key referencing the Country to which the Customer belongs 
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// Navigation property representing the associated Country
        /// </summary>
        [ForeignKey("Name")]
        [JsonIgnore]
        public Country Country { get; set; }
        /// <summary>
        /// Collection navigation property representing associated 
        /// </summary>
        public ICollection<Order> Orders { get; set; }
    }
}