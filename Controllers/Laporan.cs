using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication7.Controllers
{
    class Laporan
    {
        Config.Connection connection;

        public Laporan()
        {
            this.connection = Config.Connection.getInstance();
        }

        public DataTable SaleReportByDay(string day)
        {
            try
            {
                DataTable data = new DataTable();
                MySqlDataReader response;
                if (day == null)
                {
                    response = Config.Connection.getInstance().Query("SELECT medicines.name as `Nama Obat`, SUM(transaction_details.qty) as `Jumlah`, units.unit as `Satuan` ,SUM(transaction_details.price) as `Harga`,SUM(transaction_details.price) - SUM(medicine_stocks.purchase_price) * SUM(transaction_details.qty) as `Pendapatan`, DATE(transaction_details.createdAt) as `Tanggal` FROM transaction_details INNER JOIN medicines ON transaction_details.medicine_id = medicines.id INNER JOIN transactions ON transaction_details.transaction_id = transactions.id INNER JOIN units ON transaction_details.unit_id = units.id INNER JOIN medicine_stocks ON transaction_details.medicine_id = medicine_stocks.medicine_id WHERE DATE(transaction_details.createdAt) = DATE(NOW()) GROUP BY transaction_details.createdAt, medicines.name;");
                }
                else
                {
                    response = Config.Connection.getInstance().Query("SELECT medicines.name as `Nama Obat`, SUM(transaction_details.qty) as `Jumlah`, units.unit as `Satuan` ,SUM(transaction_details.price) as `Harga`,SUM(transaction_details.price) - SUM(medicine_stocks.purchase_price) * SUM(transaction_details.qty) as `Pendapatan`, DATE(transaction_details.createdAt) as `Tanggal` FROM transaction_details INNER JOIN medicines ON transaction_details.medicine_id = medicines.id INNER JOIN transactions ON transaction_details.transaction_id = transactions.id INNER JOIN units ON transaction_details.unit_id = units.id INNER JOIN medicine_stocks ON transaction_details.medicine_id = medicine_stocks.medicine_id WHERE DATE(transaction_details.createdAt) = " + "'" + day + "' " + "GROUP BY transaction_details.createdAt, medicines.name;");
                }
                data.Load(response);
                return data;
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);
                throw;
            }
        }
        public DataTable SaleReportByMonth(string month, string year)
        {
            try
            {
                DataTable data = new DataTable();
                MySqlDataReader response = Config.Connection.getInstance().Query("SELECT medicines.name as `Nama Obat`, SUM(transaction_details.qty) as `Jumlah`, units.unit as `Satuan` ,SUM(transaction_details.price) as `Harga`,SUM(transaction_details.price) - SUM(medicine_stocks.purchase_price) * SUM(transaction_details.qty) as `Pendapatan`, DATE(transaction_details.createdAt) as `Tanggal` FROM transaction_details INNER JOIN medicines ON transaction_details.medicine_id = medicines.id INNER JOIN transactions ON transaction_details.transaction_id = transactions.id INNER JOIN units ON transaction_details.unit_id = units.id INNER JOIN medicine_stocks ON transaction_details.medicine_id = medicine_stocks.medicine_id WHERE MONTH(transaction_details.createdAt) = " + "'" + month + "' " + "AND YEAR(transaction_details.createdAt) = " + "'" + year + "' " + "GROUP BY transaction_details.createdAt;");

                data.Load(response);
                return data;
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);
                throw;
            }
        }

        public DataTable SaleReportByYear(string year)
        {
            try
            {
                DataTable data = new DataTable();
                MySqlDataReader response = Config.Connection.getInstance().Query("SELECT medicines.name as `Nama Obat`, SUM(transaction_details.qty) as `Jumlah`, units.unit as `Satuan` ,SUM(transaction_details.price) as `Harga`,SUM(transaction_details.price) - SUM(medicine_stocks.purchase_price) * SUM(transaction_details.qty) as `Pendapatan`, DATE(transaction_details.createdAt) as `Tanggal` FROM transaction_details INNER JOIN medicines ON transaction_details.medicine_id = medicines.id INNER JOIN transactions ON transaction_details.transaction_id = transactions.id INNER JOIN units ON transaction_details.unit_id = units.id INNER JOIN medicine_stocks ON transaction_details.medicine_id = medicine_stocks.medicine_id WHERE YEAR(transaction_details.createdAt) = '"+ year + "'" + "GROUP BY transaction_details.createdAt, medicines.name;");

                

                data.Load(response);
                return data;
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);
                throw;
            }
        }
    }
}
