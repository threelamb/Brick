/********************************************************************\
 * Copyright (c) 2015 yll All Rights Reserved.
 * Information Contained Herein is Proprietary and Confidential.
 * 
 * File: <IPersonBuilder.cs>
 * Author: <yll>
 * Date Created: <2/17/2015 6:37:53 PM>
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

namespace DesignPatterns._4_Builder
{
    /// <summary>
    /// IPersonBuilder
    /// </summary>
    interface IPersonBuilder
    {
        #region public
        void BuildHead();
        void BuildBody();
        void BuildFoot();

        Person BuildPerson();
        #endregion

        #region protected

        #endregion

        #region private

        #endregion

        #region Data

        #endregion
    }
}
