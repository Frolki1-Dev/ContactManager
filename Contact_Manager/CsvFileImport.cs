using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Contact_Manager.Models;

namespace Contact_Manager
{
    /**
     * Helps us to import the csv file and create the objects in the data container
     */
    class CsvFileImport
    {
        /**
         * Starts the import process
         */
        public static void StartImport(string type, string path)
        {
            try
            {
                // Read the file out
                DataTable dt = new DataTable();
                string[] lines = File.ReadAllLines(path);

                if (lines.Length < 1)
                {
                    // File has no content
                    throw new IOException("Die angegebende Datei hat kein Inhalt.");
                }

                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }

                    dt.Rows.Add(dr);
                }

                // Loop through all data rows
                foreach (DataRow row in dt.Rows)
                {
                    switch (type)
                    {
                        case DataContainer.Customers:
                            ImportCustomer(row);
                            break;
                        case DataContainer.Employees:
                            ImportEmployee(row);
                            break;
                        case DataContainer.Trainees:
                            ImportTrainee(row);
                            break;
                        default:
                            // Stop the execution
                            return;
                    }
                }

                MessageBox.Show("Import wurde erfolgreich durchgeführt.", "Import erfolgreich", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Es muss eine Datei angegeben werden!", "Datei fehlt", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unebaknner Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /**
         * Import the customer with the give data row
         */
        private static void ImportCustomer(DataRow row)
        {
            Customer customer = new Customer(
                row[0].ToString().Trim(),
                row[3].ToString().Trim(),
                row[4].ToString().Trim(),
                ConvertStringToDateTime(row[11].ToString()),
                Convert.ToInt32(row[2]),
                row[1].ToString().Trim(),
                row[9].ToString().Trim(),
                true,
                row[14].ToString().Trim(),
                Convert.ToInt32(row[15]),
                row[5].ToString().Trim(),
                row[6].ToString().Trim(),
                row[8].ToString().Trim(),
                row[7].ToString().Trim(),
                row[16].ToString().Trim(),
                row[10].ToString().Trim(),
                row[12].ToString().Trim(),
                row[13].ToString().Trim(),
                new List<CustomerNotes>()
            );
            DataContainer.AddModel(DataContainer.Customers, customer);
        }

        /**
         * Import the employee with the give data row
         */
        private static void ImportEmployee(DataRow row)
        {
            Employee employee = new Employee(
                row[0].ToString().Trim(),
                row[3].ToString().Trim(),
                row[4].ToString().Trim(),
                ConvertStringToDateTime(row[9].ToString()),
                Convert.ToInt32(row[2]),
                row[1].ToString().Trim(),
                row[16].ToString().Trim(),
                row[20].ToString().Trim().Length < 1,
                row[10].ToString().Trim(),
                Convert.ToInt32(row[11]),
                row[5].ToString().Trim(),
                row[6].ToString().Trim(),
                row[15].ToString().Trim(),
                row[7].ToString().Trim(),
                row[12].ToString().Trim(),
                "None",
                row[14].ToString().Trim(),
                row[8].ToString().Trim(),
                row[14].ToString().Trim(),
                ConvertStringToDateTime(row[19].ToString()), // TODO
                ConvertStringToDateTime(row[20].ToString()), // TODO
                Convert.ToInt32(row[17]),
                row[18].ToString().Trim(),
                Convert.ToInt32(row[21])
            );
            DataContainer.AddModel(DataContainer.Employees, employee);
        }

        /**
         * Import the trainee with the give data row
         */
        private static void ImportTrainee(DataRow row)
        {
            Trainee trainee = new Trainee(
                row[0].ToString().Trim(),
                row[3].ToString().Trim(),
                row[4].ToString().Trim(),
                ConvertStringToDateTime(row[9].ToString()),
                Convert.ToInt32(row[2]),
                row[1].ToString().Trim(),
                row[16].ToString().Trim(),
                row[19].ToString().Trim().Length < 1,
                row[10].ToString().Trim(),
                Convert.ToInt32(row[11]),
                row[5].ToString().Trim(),
                row[6].ToString().Trim(),
                row[15].ToString().Trim(),
                row[7].ToString().Trim(),
                row[12].ToString().Trim(),
                "None",
                row[14].ToString().Trim(),
                row[8].ToString().Trim(),
                row[13].ToString().Trim(),
                ConvertStringToDateTime(row[18].ToString()),
                ConvertStringToDateTime(row[19].ToString()),
                100,
                row[17].ToString().Trim(),
                5,
                Convert.ToInt32(row[20]),
                Convert.ToInt32(row[21])
            );
            DataContainer.AddModel(DataContainer.Trainees, trainee);
        }

        /**
         * Helps us to convert the date sting to a DateTime object
         */
        private static DateTime ConvertStringToDateTime(string dateTimeValue)
        {
            if (dateTimeValue.Trim().Length < 1)
            {
                return DateTime.Now;
            }

            return DateTime.Parse(dateTimeValue.Trim(), new CultureInfo("de_CH"));
        }
    }
}