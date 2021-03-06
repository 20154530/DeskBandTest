﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDeskBand.DeskBand.BandParts {
    /// <summary>
    /// Attributes that are used to define some properties of the deskband
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class BandRegistrationAttribute : Attribute {
        /// <summary>
        /// Name of the deskband in the toolbar menu.
        /// </summary>
        /// <value>
        /// The name is used to select the deskband from the toolbars menu.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Request ShowDeskBand after succesfully registered deskband
        /// </summary>
        public bool ShowDeskBand { get; set; }
    }
}
