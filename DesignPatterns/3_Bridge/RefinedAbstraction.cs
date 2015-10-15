/********************************************************************\
 * Copyright (c) 2015 yll All Rights Reserved.
 * Information Contained Herein is Proprietary and Confidential.
 * 
 * File: <RefinedAbstraction.cs>
 * Author: <yll>
 * Date Created: <2/17/2015 5:11:12 PM>
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

namespace DesignPatterns._3_Bridge
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    class RefinedAbstraction : Abstraction
    {
        #region Generator
        public RefinedAbstraction()
        {
        }
        #endregion

        #region public
        override public void Operation()
        {
            implementor.Operation();
            //Todo
        }
        #endregion

        #region protected

        #endregion

        #region private

        #endregion

        #region Data

        #endregion
    }
}
