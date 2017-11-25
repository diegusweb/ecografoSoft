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
        [Description("Masculino")]
        Masculino = 1,

        /// <summary>
        /// Occupation - Engineer
        /// </summary>
        [Description("Femenino")]
        Femenino,

    }
}
