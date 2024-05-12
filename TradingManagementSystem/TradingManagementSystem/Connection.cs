using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace TradingManagementSystem;

internal class Connection
{
    private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ki 2 nam 2\lap trinh window\DoAn\TradingManagementSystem\TradingManagementSystem\Database1.mdf;Integrated Security=True";
    public static SqlConnection GetSqlConnection()
    {
        return new SqlConnection(stringConnection);
    }

    public DataTable GetData(string tableName, string columnName)
    {
        DataTable dataTable = new DataTable();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        string sqlstr = $"select {columnName} from {tableName}";
        SqlDataAdapter adapter = new SqlDataAdapter(sqlstr, conn);
        adapter.Fill(dataTable);
        return dataTable;
    }
    public DataTable GetDataByName(string table, string columnName, string DK)
    {
        DataTable dataTable = new DataTable();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        string sqlstr = $"select {columnName} from {table} where TenSP = N'{DK}' ";
        SqlDataAdapter adapter = new SqlDataAdapter(sqlstr, conn);
        adapter.Fill(dataTable);
        return dataTable;
    }
    public void SuaSanPham(string tableName, string set, string DK)
    {
        string updateSP = $"UPDATE {tableName} SET {set}  WHERE TenSP = {DK}";
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        SqlCommand command = new SqlCommand(updateSP, conn);
        conn.Open();
        int rowsAffected = command.ExecuteNonQuery();
        if (rowsAffected > 0)
        {
            MessageBox.Show("Sửa sản phẩm thành công.");
            // Thực hiện các hành động khác nếu cần sau khi mua thành công.
        }
        else
        {
            MessageBox.Show("Sửa sản phẩm không thành công.");
        }
    }
    public void XoaSanPham(string tableName, string DK)
    {
        string xoaSP = $"DELETE FROM {tableName} WHERE TenSP = {DK}";
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        SqlCommand command = new SqlCommand(xoaSP, conn);
        conn.Open();
        int rowsAffected = command.ExecuteNonQuery();
        if (rowsAffected > 0)
        {
            MessageBox.Show("Xóa sản phẩm thành công.");
            // Thực hiện các hành động khác nếu cần sau khi mua thành công.
        }
        else
        {
            MessageBox.Show("Không tìm thấy sản phẩm cần xóa hoặc xóa không thành công.");
        }
    }
    public void MuaSanPham(string tableName, string DK)
    {
        string xoaSP = $"DELETE FROM {tableName} WHERE TenSP = {DK}";
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn );
        SqlCommand command = new SqlCommand(xoaSP, conn);
        conn.Open();
        int rowsAffected = command.ExecuteNonQuery();
        if (rowsAffected > 0)
        {
            MessageBox.Show("Mua sản phẩm thành công.");
            // Thực hiện các hành động khác nếu cần sau khi mua thành công.
        }
        else
        {
            MessageBox.Show("Không tìm thấy sản phẩm cần mua hoặc mua không thành công.");
        }
    }
    public void Insert(string tableName, string values)
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        conn.Open();
        string sqlstr = $"insert into {tableName} values {values}";
        SqlCommand command = new SqlCommand(sqlstr, conn);  
        command.ExecuteNonQuery();      
        conn.Close();
    }
    public DataTable GetData_Condition(string table, string columnName, string DK)
    {

        DataTable dataTable = new DataTable();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        string sqlstr = $"select {columnName} from {table} where {DK} ";



        SqlDataAdapter adapter = new SqlDataAdapter(sqlstr, conn);
        adapter.Fill(dataTable);
        return dataTable;
    }
    public void deleteROw(string tableName, string condition) {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        conn.Open();
        string sqlstr = $"Delete from {tableName} where {condition}";
        SqlCommand command = new SqlCommand(sqlstr, conn);
        command.ExecuteNonQuery();
        conn.Close();
    }

}    
