/********************************************************************\
 * Copyright (c) 2015 yll All Rights Reserved.
 * Information Contained Herein is Proprietary and Confidential.
 * 
 * File: <ConcreateCreator2.cs>
 * Author: <yll>
 * Date Created: <2/13/2015 10:28:09 PM>
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

namespace DesignPatterns._1_AbstarctFactory
{
    /// <summary>
    /// ConcreateCreator2
    /// </summary>
    public class ConcreateCreator2 : ICreator
    {
        #region Generator
        public ConcreateCreator2()
        {
        }
        #endregion

        #region public
        public IProductA factoryA()
        {
            return new ProductA2();
        }

        public IProductB factoryB()
        {
            return new ProductB2();
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
