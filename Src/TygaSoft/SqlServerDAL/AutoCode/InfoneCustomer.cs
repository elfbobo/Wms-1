﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TygaSoft.IDAL;
using TygaSoft.Model;
using TygaSoft.DBUtility;

namespace TygaSoft.SqlServerDAL
{
    public partial class InfoneCustomer : IInfoneCustomer
    {
        #region ICustomer Member

        public int Insert(InfoneCustomerInfo model)
        {
            StringBuilder sb = new StringBuilder(300);
            sb.Append(@"insert into Customer (UserId,Coded,Named,ShortName,InCompany,ContactMan,ContactPhone,TelPhone,Fax,PostCode,Address,CompanyAbout,RecordDate,LastUpdatedDate)
			            values
						(@UserId,@Coded,@Named,@ShortName,@InCompany,@ContactMan,@ContactPhone,@TelPhone,@Fax,@PostCode,@Address,@CompanyAbout,@RecordDate,@LastUpdatedDate)
			            ");

            SqlParameter[] parms = {
                                       new SqlParameter("@UserId",SqlDbType.UniqueIdentifier),
new SqlParameter("@Coded",SqlDbType.VarChar,20),
new SqlParameter("@Named",SqlDbType.NVarChar,50),
new SqlParameter("@ShortName",SqlDbType.NVarChar,50),
new SqlParameter("@InCompany",SqlDbType.NVarChar,50),
new SqlParameter("@ContactMan",SqlDbType.NVarChar,20),
new SqlParameter("@ContactPhone",SqlDbType.VarChar,20),
new SqlParameter("@TelPhone",SqlDbType.VarChar,20),
new SqlParameter("@Fax",SqlDbType.VarChar,20),
new SqlParameter("@PostCode",SqlDbType.VarChar,50),
new SqlParameter("@Address",SqlDbType.NVarChar,256),
new SqlParameter("@CompanyAbout",SqlDbType.NVarChar),
new SqlParameter("@RecordDate",SqlDbType.DateTime),
new SqlParameter("@LastUpdatedDate",SqlDbType.DateTime)
                                   };
            parms[0].Value = model.UserId;
            parms[1].Value = model.Coded;
            parms[2].Value = model.Named;
            parms[3].Value = model.ShortName;
            parms[4].Value = model.InCompany;
            parms[5].Value = model.ContactMan;
            parms[6].Value = model.ContactPhone;
            parms[7].Value = model.TelPhone;
            parms[8].Value = model.Fax;
            parms[9].Value = model.PostCode;
            parms[10].Value = model.Address;
            parms[11].Value = model.CompanyAbout;
            parms[12].Value = model.RecordDate;
            parms[13].Value = model.LastUpdatedDate;

            return SqlHelper.ExecuteNonQuery(SqlHelper.InfoneDbConnString, CommandType.Text, sb.ToString(), parms);
        }

        public int InsertByOutput(InfoneCustomerInfo model)
        {
            StringBuilder sb = new StringBuilder(300);
            sb.Append(@"insert into Customer (Id,UserId,Coded,Named,ShortName,InCompany,ContactMan,ContactPhone,TelPhone,Fax,PostCode,Address,CompanyAbout,RecordDate,LastUpdatedDate)
			            values
						(@Id,@UserId,@Coded,@Named,@ShortName,@InCompany,@ContactMan,@ContactPhone,@TelPhone,@Fax,@PostCode,@Address,@CompanyAbout,@RecordDate,@LastUpdatedDate)
			            ");

            SqlParameter[] parms = {
                                       new SqlParameter("@Id",SqlDbType.UniqueIdentifier),
new SqlParameter("@UserId",SqlDbType.UniqueIdentifier),
new SqlParameter("@Coded",SqlDbType.VarChar,20),
new SqlParameter("@Named",SqlDbType.NVarChar,50),
new SqlParameter("@ShortName",SqlDbType.NVarChar,50),
new SqlParameter("@InCompany",SqlDbType.NVarChar,50),
new SqlParameter("@ContactMan",SqlDbType.NVarChar,20),
new SqlParameter("@ContactPhone",SqlDbType.VarChar,20),
new SqlParameter("@TelPhone",SqlDbType.VarChar,20),
new SqlParameter("@Fax",SqlDbType.VarChar,20),
new SqlParameter("@PostCode",SqlDbType.VarChar,50),
new SqlParameter("@Address",SqlDbType.NVarChar,256),
new SqlParameter("@CompanyAbout",SqlDbType.NVarChar),
new SqlParameter("@RecordDate",SqlDbType.DateTime),
new SqlParameter("@LastUpdatedDate",SqlDbType.DateTime)
                                   };
            parms[0].Value = model.Id;
            parms[1].Value = model.UserId;
            parms[2].Value = model.Coded;
            parms[3].Value = model.Named;
            parms[4].Value = model.ShortName;
            parms[5].Value = model.InCompany;
            parms[6].Value = model.ContactMan;
            parms[7].Value = model.ContactPhone;
            parms[8].Value = model.TelPhone;
            parms[9].Value = model.Fax;
            parms[10].Value = model.PostCode;
            parms[11].Value = model.Address;
            parms[12].Value = model.CompanyAbout;
            parms[13].Value = model.RecordDate;
            parms[14].Value = model.LastUpdatedDate;

            return SqlHelper.ExecuteNonQuery(SqlHelper.InfoneDbConnString, CommandType.Text, sb.ToString(), parms);
        }

        public int Update(InfoneCustomerInfo model)
        {
            StringBuilder sb = new StringBuilder(500);
            sb.Append(@"update Customer set UserId = @UserId,Coded = @Coded,Named = @Named,ShortName = @ShortName,InCompany = @InCompany,ContactMan = @ContactMan,ContactPhone = @ContactPhone,TelPhone = @TelPhone,Fax = @Fax,PostCode = @PostCode,Address = @Address,CompanyAbout = @CompanyAbout,RecordDate = @RecordDate,LastUpdatedDate = @LastUpdatedDate 
			            where Id = @Id
					    ");

            SqlParameter[] parms = {
                                     new SqlParameter("@Id",SqlDbType.UniqueIdentifier),
new SqlParameter("@UserId",SqlDbType.UniqueIdentifier),
new SqlParameter("@Coded",SqlDbType.VarChar,20),
new SqlParameter("@Named",SqlDbType.NVarChar,50),
new SqlParameter("@ShortName",SqlDbType.NVarChar,50),
new SqlParameter("@InCompany",SqlDbType.NVarChar,50),
new SqlParameter("@ContactMan",SqlDbType.NVarChar,20),
new SqlParameter("@ContactPhone",SqlDbType.VarChar,20),
new SqlParameter("@TelPhone",SqlDbType.VarChar,20),
new SqlParameter("@Fax",SqlDbType.VarChar,20),
new SqlParameter("@PostCode",SqlDbType.VarChar,50),
new SqlParameter("@Address",SqlDbType.NVarChar,256),
new SqlParameter("@CompanyAbout",SqlDbType.NVarChar),
new SqlParameter("@RecordDate",SqlDbType.DateTime),
new SqlParameter("@LastUpdatedDate",SqlDbType.DateTime)
                                   };
            parms[0].Value = model.Id;
            parms[1].Value = model.UserId;
            parms[2].Value = model.Coded;
            parms[3].Value = model.Named;
            parms[4].Value = model.ShortName;
            parms[5].Value = model.InCompany;
            parms[6].Value = model.ContactMan;
            parms[7].Value = model.ContactPhone;
            parms[8].Value = model.TelPhone;
            parms[9].Value = model.Fax;
            parms[10].Value = model.PostCode;
            parms[11].Value = model.Address;
            parms[12].Value = model.CompanyAbout;
            parms[13].Value = model.RecordDate;
            parms[14].Value = model.LastUpdatedDate;

            return SqlHelper.ExecuteNonQuery(SqlHelper.InfoneDbConnString, CommandType.Text, sb.ToString(), parms);
        }

        public int Delete(Guid id)
        {
            StringBuilder sb = new StringBuilder(250);
            sb.Append("delete from Customer where Id = @Id ");
            SqlParameter[] parms = {
                                     new SqlParameter("@Id",SqlDbType.UniqueIdentifier)
                                   };
            parms[0].Value = id;

            return SqlHelper.ExecuteNonQuery(SqlHelper.InfoneDbConnString, CommandType.Text, sb.ToString(), parms);
        }

        public bool DeleteBatch(IList<object> list)
        {
            StringBuilder sb = new StringBuilder(500);
            ParamsHelper parms = new ParamsHelper();
            int n = 0;
            foreach (string item in list)
            {
                n++;
                sb.Append(@"delete from Customer where Id = @Id" + n + " ;");
                SqlParameter parm = new SqlParameter("@Id" + n + "", SqlDbType.UniqueIdentifier);
                parm.Value = Guid.Parse(item);
                parms.Add(parm);
            }

            return SqlHelper.ExecuteNonQuery(SqlHelper.InfoneDbConnString, CommandType.Text, sb.ToString(), parms != null ? parms.ToArray() : null) > 0;
        }

        public InfoneCustomerInfo GetModel(Guid id)
        {
            InfoneCustomerInfo model = null;

            StringBuilder sb = new StringBuilder(300);
            sb.Append(@"select top 1 Id,UserId,Coded,Named,ShortName,InCompany,ContactMan,ContactPhone,TelPhone,Fax,PostCode,Address,CompanyAbout,RecordDate,LastUpdatedDate 
			            from Customer
						where Id = @Id ");
            SqlParameter[] parms = {
                                     new SqlParameter("@Id",SqlDbType.UniqueIdentifier)
                                   };
            parms[0].Value = id;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.InfoneDbConnString, CommandType.Text, sb.ToString(), parms))
            {
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        model = new InfoneCustomerInfo();
                        model.Id = reader.GetGuid(0);
                        model.UserId = reader.GetGuid(1);
                        model.Coded = reader.GetString(2);
                        model.Named = reader.GetString(3);
                        model.ShortName = reader.GetString(4);
                        model.InCompany = reader.GetString(5);
                        model.ContactMan = reader.GetString(6);
                        model.ContactPhone = reader.GetString(7);
                        model.TelPhone = reader.GetString(8);
                        model.Fax = reader.GetString(9);
                        model.PostCode = reader.GetString(10);
                        model.Address = reader.GetString(11);
                        model.CompanyAbout = reader.GetString(12);
                        model.RecordDate = reader.GetDateTime(13);
                        model.LastUpdatedDate = reader.GetDateTime(14);
                    }
                }
            }

            return model;
        }

        public IList<InfoneCustomerInfo> GetList(int pageIndex, int pageSize, out int totalRecords, string sqlWhere, params SqlParameter[] cmdParms)
        {
            StringBuilder sb = new StringBuilder(500);
            sb.Append(@"select count(*) from Customer ");
            if (!string.IsNullOrEmpty(sqlWhere)) sb.AppendFormat(" where 1=1 {0} ", sqlWhere);
            totalRecords = (int)SqlHelper.ExecuteScalar(SqlHelper.InfoneDbConnString, CommandType.Text, sb.ToString(), cmdParms);

            if (totalRecords == 0) return new List<InfoneCustomerInfo>();

            sb.Clear();
            int startIndex = (pageIndex - 1) * pageSize + 1;
            int endIndex = pageIndex * pageSize;

            sb.Append(@"select * from(select row_number() over(order by LastUpdatedDate desc) as RowNumber,
			          Id,UserId,Coded,Named,ShortName,InCompany,ContactMan,ContactPhone,TelPhone,Fax,PostCode,Address,CompanyAbout,RecordDate,LastUpdatedDate
					  from Customer ");
            if (!string.IsNullOrEmpty(sqlWhere)) sb.AppendFormat(" where 1=1 {0} ", sqlWhere);
            sb.AppendFormat(@")as objTable where RowNumber between {0} and {1} ", startIndex, endIndex);

            IList<InfoneCustomerInfo> list = new List<InfoneCustomerInfo>();

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.InfoneDbConnString, CommandType.Text, sb.ToString(), cmdParms))
            {
                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        InfoneCustomerInfo model = new InfoneCustomerInfo();
                        model.Id = reader.GetGuid(1);
                        model.UserId = reader.GetGuid(2);
                        model.Coded = reader.GetString(3);
                        model.Named = reader.GetString(4);
                        model.ShortName = reader.GetString(5);
                        model.InCompany = reader.GetString(6);
                        model.ContactMan = reader.GetString(7);
                        model.ContactPhone = reader.GetString(8);
                        model.TelPhone = reader.GetString(9);
                        model.Fax = reader.GetString(10);
                        model.PostCode = reader.GetString(11);
                        model.Address = reader.GetString(12);
                        model.CompanyAbout = reader.GetString(13);
                        model.RecordDate = reader.GetDateTime(14);
                        model.LastUpdatedDate = reader.GetDateTime(15);

                        list.Add(model);
                    }
                }
            }

            return list;
        }

        public IList<InfoneCustomerInfo> GetList(int pageIndex, int pageSize, string sqlWhere, params SqlParameter[] cmdParms)
        {
            StringBuilder sb = new StringBuilder(500);
            int startIndex = (pageIndex - 1) * pageSize + 1;
            int endIndex = pageIndex * pageSize;

            sb.Append(@"select * from(select row_number() over(order by LastUpdatedDate desc) as RowNumber,
			           Id,UserId,Coded,Named,ShortName,InCompany,ContactMan,ContactPhone,TelPhone,Fax,PostCode,Address,CompanyAbout,RecordDate,LastUpdatedDate
					   from Customer ");
            if (!string.IsNullOrEmpty(sqlWhere)) sb.AppendFormat(" where 1=1 {0} ", sqlWhere);
            sb.AppendFormat(@")as objTable where RowNumber between {0} and {1} ", startIndex, endIndex);

            IList<InfoneCustomerInfo> list = new List<InfoneCustomerInfo>();

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.InfoneDbConnString, CommandType.Text, sb.ToString(), cmdParms))
            {
                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        InfoneCustomerInfo model = new InfoneCustomerInfo();
                        model.Id = reader.GetGuid(1);
                        model.UserId = reader.GetGuid(2);
                        model.Coded = reader.GetString(3);
                        model.Named = reader.GetString(4);
                        model.ShortName = reader.GetString(5);
                        model.InCompany = reader.GetString(6);
                        model.ContactMan = reader.GetString(7);
                        model.ContactPhone = reader.GetString(8);
                        model.TelPhone = reader.GetString(9);
                        model.Fax = reader.GetString(10);
                        model.PostCode = reader.GetString(11);
                        model.Address = reader.GetString(12);
                        model.CompanyAbout = reader.GetString(13);
                        model.RecordDate = reader.GetDateTime(14);
                        model.LastUpdatedDate = reader.GetDateTime(15);

                        list.Add(model);
                    }
                }
            }

            return list;
        }

        public IList<InfoneCustomerInfo> GetList(string sqlWhere, params SqlParameter[] cmdParms)
        {
            StringBuilder sb = new StringBuilder(500);
            sb.Append(@"select Id,UserId,Coded,Named,ShortName,InCompany,ContactMan,ContactPhone,TelPhone,Fax,PostCode,Address,CompanyAbout,RecordDate,LastUpdatedDate
                        from Customer ");
            if (!string.IsNullOrEmpty(sqlWhere)) sb.AppendFormat(" where 1=1 {0} ", sqlWhere);
            sb.Append("order by LastUpdatedDate desc ");

            IList<InfoneCustomerInfo> list = new List<InfoneCustomerInfo>();

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.InfoneDbConnString, CommandType.Text, sb.ToString(), cmdParms))
            {
                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        InfoneCustomerInfo model = new InfoneCustomerInfo();
                        model.Id = reader.GetGuid(0);
                        model.UserId = reader.GetGuid(1);
                        model.Coded = reader.GetString(2);
                        model.Named = reader.GetString(3);
                        model.ShortName = reader.GetString(4);
                        model.InCompany = reader.GetString(5);
                        model.ContactMan = reader.GetString(6);
                        model.ContactPhone = reader.GetString(7);
                        model.TelPhone = reader.GetString(8);
                        model.Fax = reader.GetString(9);
                        model.PostCode = reader.GetString(10);
                        model.Address = reader.GetString(11);
                        model.CompanyAbout = reader.GetString(12);
                        model.RecordDate = reader.GetDateTime(13);
                        model.LastUpdatedDate = reader.GetDateTime(14);

                        list.Add(model);
                    }
                }
            }

            return list;
        }

        public IList<InfoneCustomerInfo> GetList()
        {
            StringBuilder sb = new StringBuilder(300);
            sb.Append(@"select Id,UserId,Coded,Named,ShortName,InCompany,ContactMan,ContactPhone,TelPhone,Fax,PostCode,Address,CompanyAbout,RecordDate,LastUpdatedDate 
			            from Customer
					    order by LastUpdatedDate desc ");

            IList<InfoneCustomerInfo> list = new List<InfoneCustomerInfo>();

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.InfoneDbConnString, CommandType.Text, sb.ToString()))
            {
                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        InfoneCustomerInfo model = new InfoneCustomerInfo();
                        model.Id = reader.GetGuid(0);
                        model.UserId = reader.GetGuid(1);
                        model.Coded = reader.GetString(2);
                        model.Named = reader.GetString(3);
                        model.ShortName = reader.GetString(4);
                        model.InCompany = reader.GetString(5);
                        model.ContactMan = reader.GetString(6);
                        model.ContactPhone = reader.GetString(7);
                        model.TelPhone = reader.GetString(8);
                        model.Fax = reader.GetString(9);
                        model.PostCode = reader.GetString(10);
                        model.Address = reader.GetString(11);
                        model.CompanyAbout = reader.GetString(12);
                        model.RecordDate = reader.GetDateTime(13);
                        model.LastUpdatedDate = reader.GetDateTime(14);

                        list.Add(model);
                    }
                }
            }

            return list;
        }

        #endregion
    }
}
