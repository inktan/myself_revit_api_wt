﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicProjectMethods_
{

    public static class Precision_
    {
        #region Math

        /// <summary>
        /// 判断两个数据是否相等，计算机计算会产生不可避免的误差
        /// </summary>
        public static double Precison { get { return 1e-6; } }// 0.001 foot * 304.8 = 0.3048 mm）
        /// <summary>
        /// Revit中创建实体线的最短线段距离（the shortest distance 0.00256026455729167 foot * 304.8 = 0.7803686370624797 mm）
        /// </summary>
        public static double TheShortestDistance { get { return 3e-3; } }
        /// <summary>
        /// 这里给出角度容差值，源于，图形处理结果会发生尖角的情况
        /// </summary>
        public static double AnglePRECISION { get { return 1e-1; } }
        /// <summary>
        /// 重合的点，在坐标值放大的情况下，会造成出现距离影响clipper计算，Clipper接受大到±4.6e18的整数坐标，Revit接受的最大线段长度 9144000mm = 9.144km / 304.8 = +3e4f oot
        /// </summary>
        public static double clipperMultiple { get { return 1e14; } }
        #endregion

        #region Guid
        //public static Guid Guid_AutoGeneratedElementMgrSchema = new Guid("4d0ebcfe-7603-466e-9369-6298de31dd47");

        //public static Guid Guid_ElementListOfId = new Guid("3b5485ae-e02d-49ac-b7fb-72a001085b96");
        #endregion
    }
}
