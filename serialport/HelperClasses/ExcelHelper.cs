/*
 * 
 * 
 * 功能说明：
 * 
 * 创建标识：
 * 
 * 修改标识：师文佼 2014-08-23
 * 修改说明：增加导出到Excel方法
 * 
 * */
using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using System.IO;

namespace serialport
{
    /// <summary>
    /// Excle文件处理助手
    /// </summary>
    public class ExcelHelper
    {
        /// <summary>
        /// 读取Excel文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static DataTable ImportExcelToDataTable(string fileName)
        {
            //连接定义
            //string xlsDriver = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0;";
            string xlsDriver = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0;";
            OleDbConnection cn = new OleDbConnection(string.Format(xlsDriver, fileName));
            cn.Open();

            try
            {
                DataTable schema = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                //取得第一个表名    
                string tableName = schema.Rows[0]["TABLE_NAME"].ToString();
                //读取数据
                OleDbDataAdapter da = new OleDbDataAdapter("select * from [" + tableName + "] ", cn);
                DataTable dtExcel = new DataTable();
                //数据放入到ds中
                da.Fill(dtExcel);
                da.Dispose();
                cn.Dispose();
                //返回
                return dtExcel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Dispose();
                }
            }
        }

        /// <summary>
        /// 将DataTable导出到Execl文档
        /// </summary>
        /// <param name="dt">传入一个DataTable数据集</param>
        /// <returns>返回一个Bool类型的值，表示是否导出成功</returns>
        /// True表示导出成功，Flase表示导出失败
        public static bool DataTableToExcel(DataTable dt, string Outpath)
        {
            bool result = false;
            IWorkbook workbook = null;
            FileStream fs = null;
            IRow row = null;
            ISheet sheet = null;
            ICell cell = null;

            try
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    workbook = new HSSFWorkbook();
                    sheet = workbook.CreateSheet("Sheet0");//创建一个名称为Sheet0的表
                    int rowCount = dt.Rows.Count;//行数
                    int columnCount = dt.Columns.Count;//列数
                    sheet.SetColumnWidth(0, 30 * 256);
                    sheet.SetColumnWidth(1, 30 * 256);
                    sheet.SetColumnWidth(2, 30 * 256);
                    //设置列头
                    row = sheet.CreateRow(0);//excel第一行设为列头

                    for (int c = 0; c < columnCount; c++)
                    {

                        cell = row.CreateCell(c);
                        cell.SetCellValue(dt.Columns[c].ColumnName);
                    }

                    //设置每行每列的单元格,
                    for (int i = 0; i < rowCount; i++)
                    {
                        row = sheet.CreateRow(i + 1);
                        for (int j = 0; j < columnCount; j++)
                        {
                            cell = row.CreateCell(j);//excel第二行开始写入数据
                            cell.SetCellValue(dt.Rows[i][j].ToString());
                        }
                    }
                    //向outPath输出数据
                    using (fs = File.OpenWrite(Outpath))
                    {
                        workbook.Write(fs);//向打开的这个xls文件中写入数据
                        result = true;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                if (fs != null)
                {
                    fs.Close();
                }
                return false;
            }
        }


        /// <summary>
        /// 绑定DataGridView数据到DataTable
        /// </summary>
        /// <param name="dgv">复制数据的DataGridView</param>
        /// <returns>返回的绑定数据后的DataTable</returns>
        public static DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            // 列强制转换
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }
            // 循环行
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                object Cells0 = dgv.Rows[count].Cells[0].Value;
                if (Cells0 == null)
                    Cells0 = "False";

                if (!Convert.ToBoolean(Cells0))
                    continue;

                object Cells2 = dgv.Rows[count].Cells[2].Value;
                if (Cells2 == null)
                    Cells2 = "";

                if (string.IsNullOrWhiteSpace(Cells2.ToString()))
                    continue;

                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }



    }
}
