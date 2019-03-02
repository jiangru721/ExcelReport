﻿using NpoiRow = NPOI.SS.UserModel.IRow;

namespace ExcelReport.Driver.NPOIDriver.Extends
{
    internal static class RowExtend
    {
        public static Row GetAdapter(this NpoiRow row)
        {
            return new Row(row);
        }
    }
}