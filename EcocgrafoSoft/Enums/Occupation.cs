using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcocgrafoSoft.Enums
{
    public enum Occupation
    {
        /// <summary>
        /// Occupation - Doctor
        /// </summary>
        [Description("Doctor")]
        Doctor = 1,

        /// <summary>
        /// Occupation - Engineer
        /// </summary>
        [Description("Engineer")]
        Engineer,

        /// <summary>
        /// Occupation - Professor
        /// </summary>
        [Description("Professor")]
        Professor,
    }
}
