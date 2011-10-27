﻿/*
   Copyright 2009-2010 Gary Bortosky

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

namespace Bortosky.Google.Visualization.Columns
{
    using System;
    using System.Data;

    internal class DateGoogleDataColumn : GoogleDataColumn
    {
        #region Constructors and Destructors

        /// 
        /// <param name="column"></param>
        internal DateGoogleDataColumn(DataColumn column) : base(column)
        {
        }

        #endregion

        #region Properties

        protected internal override string GoogleDataType
        {
            get { return "date"; }
        }

        #endregion

        #region Methods

        /// 
        /// <param name="row"></param>
        protected internal override string SerializedValue(DataRow row)
        {
            var d = (DateTime) row[subjectColumn];
            return string.Format("new Date({0}, {1}, {2})", d.Year, d.Month - 1, d.Day);
        }

        #endregion
    }
}