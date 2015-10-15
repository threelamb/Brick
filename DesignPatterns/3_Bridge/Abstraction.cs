/********************************************************************\
 * Copyright (c) 2015 yll All Rights Reserved.
 * Information Contained Herein is Proprietary and Confidential.
 * 
 * File: <Abstraction.cs>
 * Author: <yll>
 * Date Created: <2/17/2015 5:07:18 PM>
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
    /// Abstraction
    /// </summary>
    class Abstraction
    {
        #region Generator
        public Abstraction()
        {
        }
        #endregion

        #region public
        public IImplementor implementor
        { get; set; }

        virtual public void Operation()
        {
            implementor.Operation();
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
