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
    public partial class HtmlEditorButtonTip
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<HtmlEditorButtonTip, HtmlEditorButtonTip.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new HtmlEditorButtonTip()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HtmlEditorButtonTip component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HtmlEditorButtonTip.Config config) : base(new HtmlEditorButtonTip(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(HtmlEditorButtonTip component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual HtmlEditorButtonTip.Builder Title(string title)
            {
                this.ToComponent().Title = title;
                return this as HtmlEditorButtonTip.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual HtmlEditorButtonTip.Builder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as HtmlEditorButtonTip.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual HtmlEditorButtonTip.Builder Cls(string cls)
            {
                this.ToComponent().Cls = cls;
                return this as HtmlEditorButtonTip.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTip.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.HtmlEditorButtonTip(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTip.Builder HtmlEditorButtonTip()
        {
            return this.HtmlEditorButtonTip(new HtmlEditorButtonTip());
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTip.Builder HtmlEditorButtonTip(HtmlEditorButtonTip component)
        {
            return new HtmlEditorButtonTip.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTip.Builder HtmlEditorButtonTip(HtmlEditorButtonTip.Config config)
        {
            return new HtmlEditorButtonTip.Builder(new HtmlEditorButtonTip(config));
        }
    }
}