/********************************************************************\
 * Copyright (c) 2015 yll All Rights Reserved.
 * Information Contained Herein is Proprietary and Confidential.
 * 
 * File: <MacProducer.cs>
 * Author: <yll>
 * Date Created: <2/15/2015 1:30:35 PM>
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

namespace DesignPatterns._1_AbstarctFactory.Computer
{
    /// <summary>
    /// MacProducer
    /// </summary>
    public class MacProducer : IComputerProducer
    {
        #region Generator
        public MacProducer()
        {
        }
        #endregion

        #region public
        public ICpu CreateCpu()
        {
            return new MacCpu();
        }

        public IRam CreateRam()
        {
            return new MacRam();
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
