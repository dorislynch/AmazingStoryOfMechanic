using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Amazing.Story.Of.Mechanic.RNAmazingStoryOfMechanic
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNAmazingStoryOfMechanicModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNAmazingStoryOfMechanicModule"/>.
        /// </summary>
        internal RNAmazingStoryOfMechanicModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNAmazingStoryOfMechanic";
            }
        }
    }
}
