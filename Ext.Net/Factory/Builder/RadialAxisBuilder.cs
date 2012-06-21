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
 * @version   : 2.0.0.rc1 - Community Edition (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class RadialAxis
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractAxis.Builder<RadialAxis, RadialAxis.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RadialAxis()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RadialAxis component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RadialAxis.Config config) : base(new RadialAxis(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RadialAxis component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual RadialAxis.Builder Steps(int steps)
            {
                this.ToComponent().Steps = steps;
                return this as RadialAxis.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual RadialAxis.Builder Maximum(int maximum)
            {
                this.ToComponent().Maximum = maximum;
                return this as RadialAxis.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public RadialAxis.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RadialAxis(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RadialAxis.Builder RadialAxis()
        {
            return this.RadialAxis(new RadialAxis());
        }

        /// <summary>
        /// 
        /// </summary>
        public RadialAxis.Builder RadialAxis(RadialAxis component)
        {
            return new RadialAxis.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RadialAxis.Builder RadialAxis(RadialAxis.Config config)
        {
            return new RadialAxis.Builder(new RadialAxis(config));
        }
    }
}