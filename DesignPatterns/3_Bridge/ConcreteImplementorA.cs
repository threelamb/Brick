/********************************************************************\
 * Copyright (c) 2015 yll All Rights Reserved.
 * Information Contained Herein is Proprietary and Confidential.
 * 
 * File: <ConcreteImplementorA.cs>
 * Author: <yll>
 * Date Created: <2/17/2015 5:13:31 PM>
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
    /// ConcreteImplementorA
    /// </summary>
    class ConcreteImplementorA : IImplementor
    {
        #region Generator
        public ConcreteImplementorA()
        {
        }
        #endregion

        #region public

        #endregion

        #region protected
        public void Operation()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region private

        #endregion

        #region Data

        #endregion


    }
}
