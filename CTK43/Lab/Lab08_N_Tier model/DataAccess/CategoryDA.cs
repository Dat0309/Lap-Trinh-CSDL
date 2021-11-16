using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDA
    {
        // lay tat ca du lieu trong database
        public List<Category> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Category_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<Category> list = new List<Category>();
            while(reader.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(reader["ID"]);
                category.Name = reader["Name"].ToString();
                category.Type = Convert.ToInt32(reader["Type"]);
                list.Add(category);
            }
            conn.Close();
            return list;
        }

        // them, xoa, sua theo thu tuc
        public int Insert_Update_Delete(Category category, int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Category_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = System.Data.ParameterDirection.InputOutput;
            cmd.Parameters.Add(IDPara).Value = category.ID;

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 200)
                .Value = category.Name;
            cmd.Parameters.Add("@Type", SqlDbType.Int)
                .Value = category.Type;
            cmd.Parameters.Add("@Action", SqlDbType.Int)
                .Value = action;

            int result = cmd.ExecuteNonQuery();
            if(result > 0)
            {
                return (int)cmd.Parameters["@ID"].Value;
            }
            return 0;

            conn.Close();
        }
    }
}
