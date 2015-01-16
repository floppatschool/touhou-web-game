using System.Diagnostics;

namespace BulletMLLib
{
    /// <summary>
    /// 设置发射偏移量
    /// </summary>
    public class SetOffSetTask : BulletMLTask
    {
        #region Methods

        /// <summary>
        /// Initializes a new instance of the <see cref="BulletMLLib.BulletMLTask"/> class.
        /// </summary>
        /// <param name="node">Node.</param>
        /// <param name="owner">Owner.</param>
        public SetOffSetTask(OffSetNode node, BulletMLTask owner)
            : base(node, owner)
        {
            System.Diagnostics.Debug.Assert(null != Node);
            System.Diagnostics.Debug.Assert(null != Owner);
        }

        #endregion //Methods
    }
}
