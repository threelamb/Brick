/********************************************************************\
 * Copyright (c) 2015 yll All Rights Reserved.
 * Information Contained Herein is Proprietary and Confidential.
 * 
 * File: <ConcreteBuilder.cs>
 * Author: <yll>
 * Date Created: <2/17/2015 6:44:21 PM>
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
    /// ConcreteBuilder
    /// </summary>
    class ManBuilder : IPersonBuilder
    {
        #region Generator
        public ManBuilder()
        {
            person = new Man();
        }
        #endregion

        #region public
        Person person;
        public void BuildHead()
        {
            person.SetHead();
        }

        public void BuildBody()
        {
            person.SetBody();
        }

        public void BuildFoot()
        {
            person.SetFoot();
        }

        public Person BuildPerson()
        {
            return person;
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
