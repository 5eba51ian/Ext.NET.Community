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
 * @version   : 2.0.0.rc2 - Community Edition (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class AbstractPanel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TAbstractPanel"></typeparam>
        /// <typeparam name="TBuilder"></typeparam>
        new public abstract partial class Builder<TAbstractPanel, TBuilder> : AbstractContainer.Builder<TAbstractPanel, TBuilder>
            where TAbstractPanel : AbstractPanel
            where TBuilder : Builder<TAbstractPanel, TBuilder>
        {
            //public virtual ToolbarCollection<TPanelBase, TBuilder> TopBar()
            //{
            //    return new ToolbarCollection<TPanelBase, TBuilder>(this.ToControl(), this as TBuilder);
            //}

            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder Buttons(Action<ButtonsCollectionBuilder<TAbstractPanel, TBuilder>> action)
            {
                action(new ButtonsCollectionBuilder<TAbstractPanel, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            
            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder ToolsBuilder(Action<ToolsCollectionBuilder<TAbstractPanel, TBuilder>> action)
            {
                action(new ToolsCollectionBuilder<TAbstractPanel, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            
            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder TopBarBuilder(Action<TBarCollectionBuilder<TAbstractPanel, TBuilder>> action)
            {
                action(new TBarCollectionBuilder<TAbstractPanel, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder BottomBarBuilder(Action<BBarCollectionBuilder<TAbstractPanel, TBuilder>> action)
            {
                action(new BBarCollectionBuilder<TAbstractPanel, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder FooterBarBuilder(Action<FBarCollectionBuilder<TAbstractPanel, TBuilder>> action)
            {
                action(new FBarCollectionBuilder<TAbstractPanel, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }
        }        
    }
}