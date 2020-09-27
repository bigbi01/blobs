using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Holds information about a single calculator operation
    /// </summary>
    public class Operation
    {
        #region Properties
        /// <summary>
        /// the left side of the operation
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// the right side of the operation
        /// </summary>
        public string RightSide { get; set; }
        /// <summary>
        /// the type of operation to perform
        /// </summary>
        public OperationsType OperationsType { get; set; }
        /// <summary>
        /// the inner operation to be perform before this operation
        /// </summary>
        public Operation InnerOperation { get; set; }
        #endregion

        public Operation()
        {
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }
    }
}
