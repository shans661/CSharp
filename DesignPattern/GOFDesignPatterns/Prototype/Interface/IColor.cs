using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Interface
{
    /// <summary>
    /// Interface to cerate color
    /// </summary>
    interface IColor
    {
        /// <summary>
        /// Creates RGB color
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <param name="a"></param>
        void CreateColor(int r, int g, int b, int a);

        /// <summary>
        /// Clone the existing color
        /// </summary>
        /// <returns></returns>
        IColor Clone();
    }
}
