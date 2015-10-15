/********************************************************************\
 * Copyright (c) 2015 yll All Rights Reserved.
 * Information Contained Herein is Proprietary and Confidential.
 * 
 * File: <Client.cs>
 * Author: <yll>
 * Date Created: <2/17/2015 5:15:20 PM>
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
    /// Client
    /// </summary>
    class Client
    {
        #region Generator
        public Client()
        {
        }
        #endregion

        #region public
        public static void Do()
        {
            Abstraction abstraction = new RefinedAbstraction();
            abstraction.implementor = new ConcreteImplementorA();
            abstraction.Operation();

            abstraction.implementor = new ConcreteImplementorB();
            abstraction.Operation();
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
