using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace pankaj - project . Model{
    /// <summary> 
    /// Represents a country entity with essential details
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Primary key for the Country 
        /// </summary>
        [Key]
        public Guid CountryId { get; set; }
        /// <summary>
        /// Code of the Country 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Name of the Country 
        /// </summary>
        public string Name { get; set; }
    }
}