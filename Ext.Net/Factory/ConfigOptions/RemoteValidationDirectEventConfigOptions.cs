/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 2.0.0 - Community Edition (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RemoteValidationDirectEvent
    {
        /// <summary>
        /// 
        /// </summary>
		[Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                
                list.Add("validationBuffer", new ConfigOption("validationBuffer", null, 500, this.ValidationBuffer ));
                list.Add("showBusy", new ConfigOption("showBusy", null, true, this.ShowBusy ));
                list.Add("busyTip", new ConfigOption("busyTip", null, "Validating...", this.BusyTip ));
                list.Add("busyIconClsProxy", new ConfigOption("busyIconClsProxy", new SerializationOptions("busyIconCls"), "", this.BusyIconClsProxy ));
                list.Add("busyIconCls", new ConfigOption("busyIconCls", null, "loading-indicator", this.BusyIconCls ));
                list.Add("validationEvent", new ConfigOption("validationEvent", new SerializationOptions(JsonMode.ToLower), "keyup", this.ValidationEvent ));
                list.Add("eventOwner", new ConfigOption("eventOwner", new SerializationOptions(JsonMode.ToLower), ValidationEventOwner.Input, this.EventOwner ));
                list.Add("initValueValidation", new ConfigOption("initValueValidation", new SerializationOptions(JsonMode.ToLower), InitValueValidation.Valid, this.InitValueValidation ));

                return list;
            }
        }
    }
}