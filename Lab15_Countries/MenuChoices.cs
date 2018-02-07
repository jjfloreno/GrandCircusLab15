using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_Countries
{
    public enum MenuChoices
    {
        [Description("Display Countries")] Display = 1,
        [Description("Add Country")] Add,
        [Description("Delete Country")] Delete,
        [Description("Exit Program")] Exit
    }
}
