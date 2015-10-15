/********************************************************************\
 * Copyright (c) 2015 yll All Rights Reserved.
 * Information Contained Herein is Proprietary and Confidential.
 * 
 * File: <ComputerProducer.cs>
 * Author: <yll>
 * Date Created: <2/15/2015 1:27:37 PM>
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
    /// ComputerProducer
    /// </summary>
    public interface IComputerProducer
    {
        #region public
        ICpu CreateCpu();
        IRam CreateRam();
        #endregion

        #region protected

        #endregion

        #region private

        #endregion

        #region Data

        #endregion
    }
}
