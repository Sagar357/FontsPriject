using FontsPriject.Models;
using FontsPriject.utils;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FontsPriject.Services
{
    public class FontService
    {

        public Font_List getFontList() 
        {
            Font_List fontList = null;
            using (SqlConnection db = ConnectionHelper.getConnection())
            {
                db.Open();
                DataSet ds = new DataSet();
                
                ds = SqlHelper.ExecuteDataset(db, CommandType.StoredProcedure, "prcGetFontList");
      //         ds = SqlHelper.ExecuteDataset(db,CommandType.StoredProcedure,"prcGetFontSize");
                if (ds.Tables.Count > 0)
                {
                    fontList = new Font_List();
                    foreach (DataTable dt in ds.Tables)
                    {
        
                        foreach (DataRow dr in dt.Rows)
                        {
                            Font_Models obj = new Font_Models();
                            if (!string.IsNullOrEmpty(dr["fontId"].ToString()))
                            {
                                obj.fontId = Convert.ToInt32(dr["fontId"].ToString());
                            }
                            else
                            {
                                obj.fontId = 0;
                            }
                            if (!string.IsNullOrEmpty(dr["fontFamily"].ToString()))
                            {
                                obj.fontFamily = dr["fontFamily"].ToString();
                            }
                            else
                            {
                                obj.fontFamily = "";
                            }


                            fontList.list.Add(obj);
                        }
                    }
                }
                fontList.message = "success";
            }

            return fontList;
        }
            
    }
}