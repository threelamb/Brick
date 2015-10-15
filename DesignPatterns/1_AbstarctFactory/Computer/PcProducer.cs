/********************************************************************\
 * Copyright (c) 2015 yll All Rights Reserved.
 * Information Contained Herein is Proprietary and Confidential.
 * 
 * File: <PcProducer.cs>
 * Author: <yll>
 * Date Created: <2/15/2015 1:29:06 PM>
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
    /// PcProducer
    /// </summary>
    public class PcProducer : IComputerProducer
    {
        #region Generator
        public PcProducer()
        {
        }
        #endregion

        #region public
        public ICpu CreateCpu()
        {
            return new PcCpu();
        }

        public IRam CreateRam()
        {
            return new PcRam();
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
