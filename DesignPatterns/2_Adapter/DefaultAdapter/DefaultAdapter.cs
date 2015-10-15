/********************************************************************\
 * Copyright (c) 2015 yll All Rights Reserved.
 * Information Contained Herein is Proprietary and Confidential.
 * 
 * File: <DefaultAdapter.cs>
 * Author: <yll>
 * Date Created: <2/17/2015 4:37:40 PM>
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

namespace DesignPatterns._2_Adapter.DefaultAdapter
{
    /// <summary>
    /// DefaultAdapter
    /// </summary>
    class DefaultAdapter : ITarget
    {
        #region Generator
        public DefaultAdapter()
        {
        }
        #endregion

        #region public
        public void f1()
        {
            throw new NotImplementedException();
        }

        public void f2()
        {
            throw new NotImplementedException();
        }

        public void f3()
        {
            throw new NotImplementedException();
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
