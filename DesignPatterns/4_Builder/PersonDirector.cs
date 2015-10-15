/********************************************************************\
 * Copyright (c) 2015 yll All Rights Reserved.
 * Information Contained Herein is Proprietary and Confidential.
 * 
 * File: <PersonDirector.cs>
 * Author: <yll>
 * Date Created: <2/17/2015 6:50:16 PM>
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
    /// PersonDirector
    /// </summary>
    class PersonDirector
    {
        #region Generator
        public PersonDirector()
        {
        }
        #endregion

        #region public
        public Person ConstructPerson(IPersonBuilder pb)
        {
            pb.BuildHead();
            pb.BuildBody();
            pb.BuildFoot();
            return pb.BuildPerson();
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
