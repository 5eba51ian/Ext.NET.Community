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

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Portal
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractPanel.Builder<Portal, Portal.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Portal()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Portal component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Portal.Config config) : base(new Portal(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Portal component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Portal.Builder</returns>
            public virtual Portal.Builder Listeners(Action<PortalListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Portal.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEvent Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Portal.Builder</returns>
            public virtual Portal.Builder DirectEvents(Action<PortalDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Portal.Builder;
            }
			 
 			/// <summary>
			/// true to use overflow:'auto' on the components layout element and show scroll bars automatically when necessary, false to clip any overflowing content (defaults to false).
			/// </summary>
            public virtual Portal.Builder AutoScroll(bool autoScroll)
            {
                this.ToComponent().AutoScroll = autoScroll;
                return this as Portal.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Portal.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Portal(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Portal.Builder Portal()
        {
            return this.Portal(new Portal());
        }

        /// <summary>
        /// 
        /// </summary>
        public Portal.Builder Portal(Portal component)
        {
            return new Portal.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Portal.Builder Portal(Portal.Config config)
        {
            return new Portal.Builder(new Portal(config));
        }
    }
}