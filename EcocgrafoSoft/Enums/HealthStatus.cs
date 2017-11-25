using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcocgrafoSoft.Enums
{
    using System.ComponentModel;

    /// <summary>
    /// Enumerator for Health status
    /// </summary>
    public enum HealthStatus
    {
        /// <summary>
        /// HealthStatus - Excellent
        /// </summary>
        [Description("Excellent")]
        Excellent = 1,

        /// <summary>
        /// HealthStatus - Good
        /// </summary>
        [Description("Good")]
        Good,

        /// <summary>
        /// HealthStatus - Average
        /// </summary>
        [Description("Average")]
        Average,

        /// <summary>
        /// HealthStatus - Poor
        /// </summary>
        [Description("Poor")]
        Poor
    }
}
