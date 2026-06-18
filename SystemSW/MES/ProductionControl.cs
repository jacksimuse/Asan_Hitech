using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MES
{
    public partial class ProductionControl : UserControl
    {
        private const string CsvFilePath = @"C:\Users\메카트로닉스\Desktop\SystemSW\PCB_PLC\bin\Debug\production_data.csv";

        public ProductionControl()
        {
            InitializeComponent();
            this.Load += new EventHandler(ProductionControl_Load);
        }

        private void ProductionControl_Load(object sender, EventArgs e)
        {
            LoadCsvData();
        }

        private void LoadCsvData()
        {
            try
            {
                if (!File.Exists(CsvFilePath))
                {
                    MessageBox.Show($"데이터 파일이 존재하지 않습니다.\n경로: {CsvFilePath}", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dt = LoadCsvToDataTable(CsvFilePath);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CSV 데이터를 로드하는 중 오류가 발생했습니다.\n오류 내용: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable LoadCsvToDataTable(string filePath)
        {
            DataTable dt = new DataTable();

            // 다른 프로세스(PLC 프로그램 등)가 파일을 쓰고 있는 중에도 안전하게 읽을 수 있도록 FileShare.ReadWrite 권한을 부여하여 엽니다.
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
            {
                string headerLine = sr.ReadLine();
                if (string.IsNullOrEmpty(headerLine))
                {
                    return dt;
                }

                // 헤더 정의
                string[] headers = headerLine.Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header.Trim());
                }

                // 데이터 행 파싱
                while (!sr.EndOfStream)
                {
                    string dataLine = sr.ReadLine();
                    if (string.IsNullOrWhiteSpace(dataLine))
                    {
                        continue;
                    }

                    string[] fields = dataLine.Split(',');
                    if (fields.Length == headers.Length)
                    {
                        dt.Rows.Add(fields);
                    }
                }
            }

            return dt;
        }
    }
}

