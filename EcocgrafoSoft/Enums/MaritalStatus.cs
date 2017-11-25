using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcocgrafoSoft.Enums
{
    using System.ComponentModel;

    /// <summary>
    /// Enumerator for Marital status
    /// </summary>
    public enum MaritalStatus
    {
        /// <summary>
        /// MaritalStatus - Married
        /// </summary>
        [Description("Married")]
        Married = 1,

        /// <summary>
        /// MaritalStatus - Single
        /// </summary>
        [Description("Single")]
        Single
    }
}