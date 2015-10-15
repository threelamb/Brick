/********************************************************************\
 * Copyright (c) 2015 yll All Rights Reserved.
 * Information Contained Herein is Proprietary and Confidential.
 * 
 * File: <Adapter.cs>
 * Author: <yll>
 * Date Created: <2/17/2015 3:42:18 PM>
 * 
 * CLR Version：4.5
 * 
 * Modified by: <>; <>; <>
 * 
 * Description: <Brief description (or list) of contents of the file>
\********************************************************************/

#region Referencing namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace DesignPatterns._2_Adapter.ObjectAdapter
{
    /// <summary>
    /// Adapter
    /// </summary>
    class Adapter : ITarget
    {
        #region Generator
        public Adapter()
        {
            adaptee = new Adaptee();
        }
        #endregion

        #region public
        public void Request()
        {
            this.adaptee.SpecificRequest();
            //Todo
        }
        #endregion

        #region protected

        #endregion

        #region private
        Adaptee adaptee;
        #endregion

        #region Data

        #endregion
    }
}
